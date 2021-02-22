using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace DG_GraphQL.Middleware
{
    public class GraphQLSettings
    {
        public PathString Path { get; set; } = "/api/graphql";

        public Func<HttpContext, IDictionary<string, object>> BuildUserContext { get; set; }

        public bool EnableMetrics { get; set; }
    }
}
