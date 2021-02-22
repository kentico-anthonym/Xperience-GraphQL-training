using GraphQL;
using GraphQL.Types;
using DGModels.Types;
using System;

namespace DGModels
{
    public class DancingGoatQuery : ObjectGraphType<object>
    {
        public DancingGoatQuery(DancingGoatData data)
        {
            Name = "Query";

            Func<IResolveFieldContext, string, object> GetCoffeeFunc = (context, id) => data.GetCoffeeByIdAsync(int.Parse(id));

            Func<IResolveFieldContext, string, object> GetBrewerFunc = (context, id) => data.GetBrewerByIdAsync(int.Parse(id));

            FieldDelegate<CoffeeModel>(
                  "coffee",
                  arguments: new QueryArguments(
                      new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the coffee" }
                      ),
                  resolve: GetCoffeeFunc
                  );

            FieldDelegate<BrewerModel>(
                "brewer",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the brewer" }
            ),
            resolve: GetBrewerFunc
            );
        }

    }
}
