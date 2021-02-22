namespace DGModels.Types
{
    public enum GrinderEnum
    {
        Electric,
        Manual
    }

    public abstract class DancingGoatProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CoffeeProduct : DancingGoatProduct
    {
        public string Farm { get; set; }
        public string Country { get; set; }
        public string Variety { get; set; }
        public string Processing { get; set; }
        public int Altitude { get; set; }
        public bool IsDecaf { get; set; }
    }

    public class Grinder : DancingGoatProduct
    {
        public int Power { get; set; }
    }

    public class BrewerProduct : DancingGoatProduct
    {
        public bool DishwasherSafe { get; set; }
    }

    public class DG_Cafe : DancingGoatProduct
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsRoastery { get; set; }
        public bool IsPartner { get; set; }
    }
}
