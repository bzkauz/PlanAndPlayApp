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

        public Login()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://api.geonames.org/");
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
    }
}

