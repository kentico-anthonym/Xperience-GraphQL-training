using GraphQL.Types;

namespace DGModels.Types
{
    public class ProductInterface : InterfaceGraphType<DancingGoatProduct>
    {
        public ProductInterface()
        {
            Name = "Product";

            Field(d => d.Id).Description("The id of the product");
            Field(d => d.Name, nullable: true).Description("The name of the product");
        }
    }
}
