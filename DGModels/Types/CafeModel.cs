using GraphQL.Types;

namespace DGModels.Types
{
    public class CafeModel : ObjectGraphType<DG_Cafe>
    {
        public CafeModel()
        {
            Name = "Cafe";

            Field(h => h.Id).Description("The id of the coffee product");
            Field(h => h.Name, nullable: true).Description("The name of coffee");
            Field(h => h.Street).Description("");
            Field(h => h.City).Description("");
            Field(h => h.Country).Description("");
            Field(h => h.ZipCode).Description("");
            Field(h => h.Phone).Description("");
            Field(h => h.Email).Description("");
            Field(h => h.IsRoastery).Description("");
            Field(h => h.IsPartner).Description("");
        }
    }
}
