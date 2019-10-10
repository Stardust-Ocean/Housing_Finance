using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CompanyCommunicationLibray
{
	public class P2SClient
	{
		public delegate void ConnectCallback();

		public delegate void SendCallback();

		[CompilerGenerated]
		private static class Callsite
		{
			public static CallSite<Func<CallSite, object, string, object>> Callsite1;

			public static CallSite<Func<CallSite, object, string, object>> Callsite2;

			public static CallSite<Func<CallSite, Type, object, object>> Callsite3;

			public static CallSite<Func<CallSite, object, JToken>> Callsite4;
		}

		private SocketHelper socketHelper;

		private List<string> transList = new List<string>
		{
			"P5201CL08-pad",
			"P5201CL03-pad",
			"P5201CL05-pad",
			"",
			"P5201CL07-pad",
			"findList"
		};

		public P2SClient()
		{
			this.socketHelper = new SocketHelper();
		}

		public void Connect(P2SClient.ConnectCallback connectsuccesscallback = null, P2SClient.ConnectCallback connectfailcallback = null)
		{
			this.socketHelper.Connect("127.0.0.1", 8777, delegate
			{
				bool flag = connectsuccesscallback != null;
				if (flag)
				{
					connectsuccesscallback();
				}
			}, delegate
			{
				bool flag = connectfailcallback != null;
				if (flag)
				{
					connectfailcallback();
				}
			});
		}

		public string SendRequest(string transaction_id, string jsonData, string _fw_service_id = "simpleTransaction")
		{
			bool flag = this.transList.Contains(transaction_id);
			string result;
			if (flag)
			{
				object obj = JsonConvert.DeserializeObject(jsonData);
				if (P2SClient.Callsite.Callsite1 == null)
				{
					P2SClient.Callsite.Callsite1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "_fw_service_id", typeof(P2SClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				P2SClient.Callsite.Callsite1.Target(P2SClient.Callsite.Callsite1, obj, _fw_service_id);
				if (P2SClient.Callsite.Callsite2 == null)
				{
					P2SClient.Callsite.Callsite2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "transaction_id", typeof(P2SClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				P2SClient.Callsite.Callsite2.Target(P2SClient.Callsite.Callsite2, obj, transaction_id);
				JObject jObject = new JObject();
				jObject["Ovrlsttn_Trck_No"] = Guid.NewGuid().ToString("N");
				jObject["Service_Name"] = "P2SRequest";
				JObject arg_1B7_0 = jObject;
				string arg_1B7_1 = "jsonData";
				if (P2SClient.Callsite.Callsite4 == null)
				{
					P2SClient.Callsite.Callsite4 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(JToken), typeof(P2SClient)));
				}
				Func<CallSite, object, JToken> arg_1B2_0 = P2SClient.Callsite.Callsite4.Target;
				CallSite arg_1B2_1 = P2SClient.Callsite.Callsite4;
				if (P2SClient.Callsite.Callsite3 == null)
				{
					P2SClient.Callsite.Callsite3 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "SerializeObject", null, typeof(P2SClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_1B7_0[arg_1B7_1] = arg_1B2_0(arg_1B2_1, P2SClient.Callsite.Callsite3.Target(P2SClient.Callsite.Callsite3, typeof(JsonConvert), obj));
                try
                {
                    result = this.socketHelper.SendSync(jObject.ToString());
                }catch(Exception e){
                    result = e.Message;
                }
			}
			else{
				result = "交易请求超出请求限制!";
			}
			return result;
		}
	}
}
