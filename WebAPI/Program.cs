using System;
using WebAPI.Controllers;

namespace WebAPI
{
    public class Program
    {


        static async Task Main(string[] args)
        {

            if (args.Length != 3)
            {
                Console.WriteLine("Please enter Url, API Key and Host ");
            }
            else
            {
                string url = args[0];
                string key = args[1];
                string host = args[2];
                var demo = new Demo();
                var result = await demo.Call(url, key, host);
                Console.WriteLine(result);

            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

    }
}
