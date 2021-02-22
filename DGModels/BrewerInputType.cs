using GraphQL.Types;
using DGModels.Types;

namespace DGModels
{
    public class BrewerInputType : InputObjectGraphType<BrewerProduct>
    {
        public BrewerInputType()
        {
            Name = "BrewerInput";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.DishwasherSafe);
        }
    }
}