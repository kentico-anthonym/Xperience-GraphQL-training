﻿using System.Collections.Generic;
using System.Security.Claims;

namespace DG_GraphQL.Middleware
{
    public class GraphQLUserContext : Dictionary<string, object>
    {
        public ClaimsPrincipal User { get; set; }
    }
}
