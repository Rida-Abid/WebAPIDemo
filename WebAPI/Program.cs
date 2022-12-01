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
                Console.WriteLine("Please enter 3 numbers:  ");
            }
            else
            {
                


            }
            var demo = new Demo();
            var result = await demo.call("https://pakistan-stock-exchange-data-portal.p.rapidapi.com/psx/top-3",
                "350db33d16msh554790632a4543cp19e989jsna537cb041e1c",
                "pakistan-stock-exchange-data-portal.p.rapidapi.com");
            
            Console.WriteLine(result);

        }

    }
}
