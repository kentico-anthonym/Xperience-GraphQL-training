using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DGModels
{
    public class DancingGoatSchema : Schema
    {
        public DancingGoatSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<DancingGoatQuery>();
            Mutation = provider.GetRequiredService<DancingGoatMutation>();
        }
    }
}
