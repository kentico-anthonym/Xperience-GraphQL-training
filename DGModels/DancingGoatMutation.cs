using GraphQL.Types;

namespace DGModels
{
    public class DancingGoatMutation : ObjectGraphType
    {
        public DancingGoatMutation(DancingGoatData data)
        {
            Name = "Mutation";
        }
    }
}
