using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.RequestHelpers;
using Microsoft.AspNetCore.Http;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(
            this HttpResponse response,
            MetaData metaData
        )
        {
            var option =
                new JsonSerializerOptions {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

            response
                .Headers
                .Add("Pagination", JsonSerializer.Serialize(metaData, option));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}
