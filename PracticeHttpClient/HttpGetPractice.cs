using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeHttpClient
{
	public class HttpGetPractice
	{
		public static async void HRequestAsync()
		{
			var userName = "eadeborna";
			var passwd = "Gamification123";
			var url = "https://e45z.4.ucc.md/sap/opu/odata/sap/ZUCC_GBM_SRV/MM_FSet(Id=2,User='LEARN-031')?$format=json&sap-client=111";

			// use this handler to allow untrusted SSL Certificates
			var handler = new HttpClientHandler();
			handler.ClientCertificateOptions = ClientCertificateOption.Manual;
			handler.ServerCertificateCustomValidationCallback =
				(httpRequestMessage, cert, cetChain, policyErrors) =>
				{
					return true;
				};

			using var client = new HttpClient(handler);

			var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
				Convert.ToBase64String(authToken));

			var result = await client.GetAsync(url);

			var content = await result.Content.ReadAsStringAsync();
			dynamic json1 = JsonConvert.DeserializeObject<object>(content);
			//JObject json = new JObject();
			JObject json = JObject.Parse(content);
			Console.WriteLine(content);
			Console.WriteLine("------------------------");
			Console.WriteLine(json1);
			Console.WriteLine(json1.GetType());
			Console.WriteLine("------------------------");

			Console.WriteLine((string)json["d"]["Id"]);

			SapViewModel data = new SapViewModel()
			{
				Data = new D()
				{
					Id = (int)json["d"]["Id"],
					User = (string)json["d"]["User"],
					Step1 = (string)json["d"]["Step1"],
					Step2 = (string)json["d"]["Step2"],
					Step3 = (string)json["d"]["Step3"],
					Step4 = (string)json["d"]["Step4"],
					Step5 = (string)json["d"]["Step5"],
					Step6 = (string)json["d"]["Step6"],
					Step7 = (string)json["d"]["Step7"],
					Step8 = (string)json["d"]["Step8"],
					Step9 = (string)json["d"]["Step9"],
					Step10 = (string)json["d"]["Step10"],
					Step11= (string)json["d"]["Step11"],
					Step12 = (string)json["d"]["Step12"],
					Step13 = (string)json["d"]["Step13"],
					FulfillmentMandatory = (string)json["d"]["FulfillmentMandatory"],
					FulfillmentAll = (string)json["d"]["FulfillmentAll"]
				}
			};
				Console.WriteLine(data.Data.FulfillmentMandatory);
				var offset = data.Data.Step10.Substring(1,2);
				//var offset = data.Data.Step10.IndexOf(':');
				//offset = data.Data.Step10.IndexOf(':', offset + 1);
				//var resulst = data.Data.Step10.IndexOf(':', offset + 1);
				Console.WriteLine(offset);
		}
	}
}
