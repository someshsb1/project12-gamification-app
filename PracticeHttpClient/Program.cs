using System.Net;
using System.Text;

namespace PracticeHttpClient
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			//Task t = new Task(HTTP_GET);
			Task t = new Task(HttpGetPractice.HRequestAsync);
			t.Start();
			Console.ReadLine();
        }

		static async void HTTP_GET()
		{
			//var TARGETURL = "http://en.wikipedia.org/";
			var TARGETURL = "https://e45z.4.ucc.md/sap/opu/odata/sap/ZUCC_GBM_SRV/MM_FSet(Id=2,User='LEARN-031')?$format=json&sap-client=111";

			HttpClientHandler handler = new HttpClientHandler()
			{
				Proxy = new WebProxy("http://127.0.0.1"),
				UseProxy = false,
			};

			Console.WriteLine("GET: + " + TARGETURL);

			// ... Use HttpClient.            
			HttpClient client = new HttpClient(handler);

			//var byteArray = Encoding.ASCII.GetBytes("username:password1234");
			//client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

			//HttpResponseMessage response = await client.GetAsync(TARGETURL);
			//HttpContent content = response.Content;


			var byteArray = Encoding.ASCII.GetBytes("eadeborna:Gamification123");
			client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
			//var response = await _client.GetFromJsonAsync<object>($"/MM_FSet(Id=2,User='LEARN-031')?$format=json&sap-client=111");
			var response = await client.GetAsync(TARGETURL);
			//ViewBag.Err = response;
			Console.WriteLine(response);
			HttpContent content = response.Content;

			// ... Check Status Code                                
			Console.WriteLine("Response StatusCode: " + (int)response.StatusCode);

			// ... Read the string.
			string result = await content.ReadAsStringAsync();

			// ... Display the result.
			if (result != null && result.Length >= 50)
			{
				Console.WriteLine(result.Substring(0, 50) + "...");
			}
		}

    }

}