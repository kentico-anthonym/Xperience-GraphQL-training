using GraphQL.Types;

namespace DGModels.Types
{
    public class CoffeeModel : ObjectGraphType<CoffeeProduct>
    {
        public CoffeeModel(DancingGoatData data)
        {
            Name = "Coffee";
            Description = "";

            Field(h => h.Id).Description("The id of the coffee product");
            Field(h => h.Name, nullable: true).Description("The name of coffee");
            Field(h => h.Farm).Description("");
            Field(h => h.Country).Description("");
            Field(h => h.Variety).Description("");
            Field(h => h.Processing).Description("Processing choice.");
            Field(h => h.Altitude).Description("Feet above sea-level.");
            Field(h => h.IsDecaf).Description("");

            Interface<ProductInterface>();
        }
    }
}
