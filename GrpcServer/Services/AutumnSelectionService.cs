using Grpc.Core;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class AutumnSelectionService : AutumnSelection.AutumnSelectionBase
    {
        public override Task<AutumnResponse> AutumnSignSelection(AutumnRequest request, ServerCallContext context)
        {
            string startDate;
            string endDate;
            string sign;
            string pattern = "MM/dd/yyyy";
            var file = File.ReadAllLines("Autumn.txt");

            DateTime requestParsed;
            DateTime startParsed;
            DateTime endParsed;

            for (var i = 0; i < file.Length; i += 3)
            {
                startDate = file.ElementAt(i).ToString();
                endDate = file.ElementAt(i + 1).ToString();
                sign = file.ElementAt(i + 2).ToString();

                if (DateTime.TryParseExact(startDate, pattern, null, DateTimeStyles.None, out startParsed)
                    && DateTime.TryParseExact(endDate, pattern, null, DateTimeStyles.None, out endParsed)
                    && DateTime.TryParseExact(request.Date, pattern, null, DateTimeStyles.None, out requestParsed))
                {
                    if (((startParsed.Month < requestParsed.Month) ||
                        (startParsed.Month == requestParsed.Month && startParsed.Day <= requestParsed.Day)) &&
                        ((endParsed.Month > requestParsed.Month) ||
                        (endParsed.Month == requestParsed.Month) && endParsed.Day >= requestParsed.Day))
                    {
                        return Task.FromResult(new AutumnResponse { Sign = sign });
                    }

                }

            }
            return Task.FromResult(new AutumnResponse { Sign = "Could not find a sign for this date!" });

        }
    }
}
