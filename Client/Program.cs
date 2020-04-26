using Grpc.Core;
using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 16842;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);
            var client = new Generated.ZodiacService.ZodiacServiceClient(channel);
            Console.Write("Introduceti data nasterii: ");
            var datdateRead = Console.ReadLine();
            DateTime date;
            try
            {
                string formats = "MM/dd/yyyy";
                date = DateTime.ParseExact(datdateRead, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);

                var response = client.ZodiacSign(new Generated.BirthdayRequest
                {
                    Data = datdateRead
                });
                Console.WriteLine(response.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data.");
                //Console.WriteLine(e.Message);
            }

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
