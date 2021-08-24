using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.CallApi
{
    public static class loginCall
    {
        private static readonly string baseURL = "http://192.168.81.1:8080/";
        public static async Task<string> Login(string id,string password)
        {
            var inputData=new Dictionary<string,string>
            {
                { "ID",id.ToString() },
                { "Password",password}
            };
            var input = new FormUrlEncodedContent(inputData);
            using(HttpClient client=new HttpClient())
            {
                using (HttpResponseMessage res= await client.PostAsync(baseURL+ "Res/log",input))
                {
                    HttpStatusCode code = res.StatusCode;
                    if ((int)code == 200)
                    {
                        string data = "Successfull";
                        return data;
                    }
                    else return "error";
                    
                }
            }
        }
    }
}
