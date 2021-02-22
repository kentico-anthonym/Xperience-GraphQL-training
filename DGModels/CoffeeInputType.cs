using GraphQL.Types;
using DGModels.Types;

namespace DGModels
{
    public class CoffeeInputType : InputObjectGraphType<CoffeeProduct>
    {
        public CoffeeInputType()
        {
            Name = "CoffeeInput";
            Field(x => x.Name);
            Field(x => x.Farm);
            Field(x => x.Variety);
            Field(x => x.Country);
            Field(x => x.Processing);
            Field(x => x.Altitude);
            Field(x => x.IsDecaf);

        }
    }
}
