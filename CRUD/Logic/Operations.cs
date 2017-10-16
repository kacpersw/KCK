using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CRUD.Logic
{
    class Operations
    {
        private HttpWebRequest httpWebRequest;


        public Operations()
        {
            httpWebRequest = (HttpWebRequest)WebRequest.Create("http://resevation.azurewebsites.net/api/rooms");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
        }

        public void postMethod()
        {
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string json = "json={\"date\":\"2014-08-28\"}";
            //    Console.WriteLine(json);
            //    streamWriter.Write(json);
            //}

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
                Console.ReadKey();
            }
     

        }
    }
}
