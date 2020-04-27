using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Globalization;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput = ReadDate();

                var channel = GrpcChannel.ForAddress("https://localhost:8888");
                var seasonService = new SeasonSelection.SeasonSelectionClient(channel);
                var requestedSeason = seasonService.GetSeason(new SeasonRequest { Date = userInput });

                Console.WriteLine("\nThe season for this date is "+requestedSeason.Season.ToString());

                switch (requestedSeason.Season)
                {
                    case "Winter":
                        var winterService = new WinterSelection.WinterSelectionClient(channel);
                        Console.WriteLine("Your sign is " + winterService.WinterSignSelection(new WinterRequest { Date = userInput }).Sign.ToString());
                        break;
                    case "Spring":
                        var springService = new SpringSelection.SpringSelectionClient(channel);
                        Console.WriteLine("Your sign is " + springService.SpringSignSelection(new SpringRequest { Date = userInput }).Sign.ToString());
                        break;
                    case "Summer":
                        var summerService = new SummerSelection.SummerSelectionClient(channel);
                        Console.WriteLine("Your sign is " + summerService.SummerSignSelection(new SummerRequest { Date = userInput }).Sign.ToString());
                        break;
                    case "Autumn":
                        var autumnService = new AutumnSelection.AutumnSelectionClient(channel);
                        Console.WriteLine("Your sign is " + autumnService.AutumnSignSelection(new AutumnRequest { Date = userInput }).Sign.ToString());
                        break;

                }
               
            }
        }


        public static string ReadDate()
        {
            
            Console.WriteLine("\nEnter a date (MM/DD/YYYY): ");
            string input = Console.ReadLine();
            string pattern = "MM/dd/yyyy";

            DateTime parsedDate;

            while (!DateTime.TryParseExact(input, pattern, null, DateTimeStyles.None, out parsedDate))
            {

                Console.WriteLine("Wrong input, enter another date: ");
                input = Console.ReadLine();
            }

            return input;

        }

        
    }
}
