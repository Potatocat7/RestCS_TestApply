using System;
using System.Text;
using System.Net.Http;

namespace CS_study_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var comment = "あいうえお";
            //var content = new ByteArrayContent(Encoding.UTF8.GetBytes(comment));

            var content = new StringContent(comment, Encoding.UTF8);
 
            HttpClient client = new HttpClient();
            while ( true )
            {
                //var res = client.GetAsync("http://localhost:8080/").Result;
                var res = client.PostAsync("http://localhost:8080/a",content).Result;
                var text = res.Content.ReadAsStringAsync().Result;
                if(text != null){
                    Console.WriteLine($"{text}");
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}

