using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CompanyCommunicationLibray
{
	internal class SocketHelper
	{
		public delegate void ConnectCallback();

		public delegate void SendCallback();

		private static SocketHelper socketHelper=null;

		private Socket socket;

		internal bool IsConnected()
		{
			bool flag = this.socket == null;
			return !flag && this.socket.Connected;
		}

		internal static SocketHelper GetInstance()
		{
			bool flag = SocketHelper.socketHelper == null;
			SocketHelper result;
			if (flag)
			{
				result = new SocketHelper();
			}
			else
			{
				result = SocketHelper.socketHelper;
			}
			return result;
		}

		internal string SendSync(string msg)
		{
			bool flag = this.socket.IsBound && this.socket.Connected;
			if (flag)
			{
				try
				{
					byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(msg);
					this.socket.Send(bytes, bytes.Length, SocketFlags.None);
					byte[] array = new byte[1000000];
					this.socket.ReceiveTimeout = 60000;
					int num = this.socket.Receive(array);
					bool flag2 = num > 0;
					if (flag2)
					{
						return Encoding.GetEncoding("UTF-8").GetString(array);
					}
					throw new Exception("接受到空数据!");
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
			throw new Exception("未连接服务，请先连接!");
		}

		internal void SendAsync(string msg, SocketHelper.SendCallback sendSuccessCallback, SocketHelper.SendCallback sendFailCallback)
		{
			bool flag = this.socket.IsBound && this.socket.Connected;
			if (flag)
			{
				byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(msg);
				IAsyncResult asyncResult = this.socket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, delegate(IAsyncResult r)
				{
					bool flag5 = sendSuccessCallback != null;
					if (flag5)
					{
						sendSuccessCallback();
					}
				}, this.socket);
				bool flag2 = asyncResult.AsyncWaitHandle.WaitOne(5000, true);
				bool flag3 = !flag2;
				if (flag3)
				{
					bool flag4 = sendFailCallback != null;
					if (flag4)
					{
						sendFailCallback();
					}
					this.Closed();
				}
			}
		}

		internal void Connect(string serverIp, int serverPort, SocketHelper.ConnectCallback connectSuccessCallback, SocketHelper.ConnectCallback connectFailedCallback)
		{
			this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPAddress address = IPAddress.Parse(serverIp);
			IPEndPoint remoteEP = new IPEndPoint(address, serverPort);
			IAsyncResult asyncResult = this.socket.BeginConnect(remoteEP, delegate(IAsyncResult asyncConnect)
			{
				bool flag4 = !this.socket.Connected;
				if (flag4)
				{
					bool flag5 = connectFailedCallback != null;
					if (flag5)
					{
						connectFailedCallback();
					}
				}
				else
				{
					bool flag6 = connectSuccessCallback != null;
					if (flag6)
					{
						connectSuccessCallback();
					}
				}
			}, this.socket);
			bool flag = asyncResult.AsyncWaitHandle.WaitOne(5000, true);
			bool flag2 = !flag;
			if (flag2)
			{
				this.Closed();
				bool flag3 = connectFailedCallback != null;
				if (flag3)
				{
					connectFailedCallback();
				}
			}
		}

		internal void Closed()
		{
			bool flag = this.socket != null && this.socket.Connected;
			if (flag)
			{
				this.socket.Shutdown(SocketShutdown.Both);
				this.socket.Close();
			}
			this.socket = null;
		}
	}
}
