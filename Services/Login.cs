using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;
using System.Net;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

[assembly: Dependency(typeof(Services.Login))]
namespace Services
{
    public class Login : ILogin<LoginData>
    {
        private string errorText = string.Empty;
        private ImageSource imgSrc;

        HttpClient client;

        public async Task<LoginData[]> GetLoginDataAsync()
        {
            throw new NotImplementedException();

            //client = new System.Net.Http.HttpClient();

            //client.BaseAddress = new Uri("http://api.geonames.org/");

            var response = await client.GetAsync("earthquakesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&username=bertt&maxRows=20");

            var LoginJson = response.Content.ReadAsStringAsync().Result;

            var rootobject = JsonConvert.DeserializeObject<RootobjectLoging>(LoginJson);

            return rootobject.LoginDataObjects;
        }

        public Login(string baseAdress)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAdress);
            client.MaxResponseContentBufferSize = 256000;
        }

        public async void SendAsync(string UriAdresse)
        {
            try
            {
                Stream stream = await GetStreamAsync(UriAdresse);
                // await GetStreamAsync("https://developer.xamarin.com/demo/IMG_1996.JPG");


                if (Device.OS == TargetPlatform.WinPhone ||
                    Device.OS == TargetPlatform.Windows)
                {
                    MemoryStream memStream = new MemoryStream();
                    stream.CopyTo(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    stream = memStream;
                }

                //imgSrc = ImageSource.FromStream(() => stream);
            }
            catch (Exception exc)
            {
                errorText = exc.Message;
            }
        }

        async Task<Stream> GetStreamAsync(string uri)
        {
            TaskFactory factory = new TaskFactory();
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = await factory.FromAsync<WebResponse>(request.BeginGetResponse,
                                                                        request.EndGetResponse,
                                                                        null);
            return response.GetResponseStream();
        }


        private const string Url = "http://www.nactem.ac.uk/software/acromine/dictionary.py?sf={0}";
        public async Task<List<REQ>> GetResult(string SearchString,string url)
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync(string.Format(url, SearchString));
                return JsonConvert.DeserializeObject<List<REQ>>(json.ToString());
            }
            catch (System.Exception exception)
            {
                return null;
            }
        }

        public async Task SaveTodoItemAsync (REQ item, bool isNewItem = false)
		{
			// RestUrl = http://developer.xamarin.com:8081/  api/todoitems
			var uri = new Uri (string.Format (Constants.RestUrl, string.Empty));

			try {
				var json = JsonConvert.SerializeObject (item);
				var content = new StringContent (json, Encoding.UTF8, "application/json");

				HttpResponseMessage response = null;
				if (isNewItem) {
					response = await client.PostAsync (uri, content);
				} else {
					response = await client.PutAsync (uri, content);
				}
				
				if (response.IsSuccessStatusCode) {
					Debug.WriteLine (@"				TodoItem successfully saved.");
				}
				
			} catch (Exception ex) {
				Debug.WriteLine (@"				ERROR {0}", ex.Message);
			}
		}
        public void Disscus()
        {
            var httpClient = new HttpClient();
            //HttpContent content = new StringContent(JsonConvert.SerializeObject(toPost), Encoding.UTF8, WebConstants.ContentTypeJson);

            //if (!Equals(headers, null))
            //{
            //    foreach (var header in headers)
            //    {
            //        content.Headers.Add(header.Key, header.Value);
            //    }
            //}

            //var response = await httpClient.PostAsync(new Uri(url), content, ct);

            //if (response.IsSuccessStatusCode)
            //{
            //    return await response.Content.ReadAsStringAsync();
            //}
        }
    }
}

