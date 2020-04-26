using Generated;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ZodiacService : Generated.ZodiacService.ZodiacServiceBase
    {
        private string testDate(string date)
        {
            string formats = "MM/dd/yyyy";

            DateTime dateUsed = DateTime.ParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);

            int size = Server.listZodiacSigns.Count;
            for (int i = 0; i < size; ++i)
            {
                if (dateUsed.Month == Int32.Parse(Server.listZodiacSigns[i].StartMonth)
                    && dateUsed.Day >= Int32.Parse(Server.listZodiacSigns[i].StartDay)
                    || dateUsed.Month == Int32.Parse(Server.listZodiacSigns[i].EndMonth)
                    && dateUsed.Day <= Int32.Parse(Server.listZodiacSigns[i].EndDay))
                {
                    return Server.listZodiacSigns[i].Sign;
                }
            }

            return String.Empty;
        }

        public override Task<OperationResponse> ZodiacSign(Generated.BirthdayRequest request, ServerCallContext context)
        {
            Console.WriteLine(request.Data);
            var response = new OperationResponse();
            return Task.FromResult(new OperationResponse() { Message = testDate(request.Data) });
        }
    }
}
