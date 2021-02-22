using CMS.DocumentEngine.Types.DancingGoatMvc;
using DGModels.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGModels
{
    public class DancingGoatData
    {
        private readonly List<CoffeeProduct> _coffees = null;
        private readonly List<BrewerProduct> _brewers = null;

        public DancingGoatData()
        {
            _coffees = CoffeeProvider.GetCoffees().Select(x => new CoffeeProduct()
            {
                Id = x.CoffeeID,
                Altitude = x.CoffeeAltitude,
                Country = x.CoffeeCountry,
                Farm = x.CoffeeFarm,
                IsDecaf = x.CoffeeIsDecaf,
                Name = x.DocumentName,
                Processing = x.CoffeeProcessing,
                Variety = x.CoffeeVariety
            }).ToList();

            _brewers = BrewerProvider.GetBrewers().Select(x => new BrewerProduct()
            {
                Id = x.BrewerID,
                DishwasherSafe = x.BrewerIsDishwasherSafe,
                Name = x.DocumentName
            }).ToList();
        }

        public Task<CoffeeProduct> GetCoffeeByIdAsync(int id)
        {
            return Task.FromResult(_coffees.FirstOrDefault(c => c.Id == id));
        }

        public Task<BrewerProduct> GetBrewerByIdAsync(int id)
        {
            return Task.FromResult(_brewers.FirstOrDefault(b => b.Id == id));
        }
    }
}
