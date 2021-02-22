using DGModels;
using DGModels.Types;
using GraphQL.Types;

namespace DGModels.Types
{
    public class BrewerModel : ObjectGraphType<BrewerProduct>
    {
        public BrewerModel(DancingGoatData data)
        {
            Name = "Brewer";
            Description = "";

            Field(x => x.Id).Description("The id of the brewer product");
            Field(x => x.Name, nullable: true).Description("The name of brewer");
            Field(x => x.DishwasherSafe, nullable: true).Description("Is this brewer dishwasher safe?");

            Interface<ProductInterface>();
        }
    }
}
