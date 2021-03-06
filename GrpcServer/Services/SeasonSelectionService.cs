﻿using Grpc.Core;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace GrpcServer.Services
{
    public class SeasonSelectionService : SeasonSelection.SeasonSelectionBase
    {
        public override Task<SeasonResponse> GetSeason(SeasonRequest request, ServerCallContext context)
        {
            string startDate;
            string endDate;
            string season;
            string pattern = "MM/dd/yyyy";
            var file = File.ReadAllLines("Seasons.txt");

            DateTime requestParsed;
            DateTime startParsed;
            DateTime endParsed;

            for (var i = 0; i < file.Length; i += 3)
            {
                startDate = file.ElementAt(i).ToString();
                endDate = file.ElementAt(i + 1).ToString();
                season = file.ElementAt(i + 2).ToString();

                if (DateTime.TryParseExact(startDate, pattern, null, DateTimeStyles.None, out startParsed)
                   && DateTime.TryParseExact(endDate, pattern, null, DateTimeStyles.None, out endParsed)
                   && DateTime.TryParseExact(request.Date, pattern, null, DateTimeStyles.None, out requestParsed))
                {
                    if (((startParsed.Month < requestParsed.Month) ||
                        (startParsed.Month == requestParsed.Month && startParsed.Day <= requestParsed.Day)) &&
                        ((endParsed.Month > requestParsed.Month) ||
                        (endParsed.Month == requestParsed.Month) && endParsed.Day >= requestParsed.Day))
                    {
                        return Task.FromResult(new SeasonResponse { Season = season });
                    }

                }

            }
            return Task.FromResult(new SeasonResponse { Season = "Could not find a season for this date!" });

        }
    }
}
