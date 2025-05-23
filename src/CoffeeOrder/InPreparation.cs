using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeOrder;

public record InPreparation(string CoffeeType, DateTime StartedAt, IReadOnlyList<string> Ingredients) : Coffee(CoffeeType)
{
    public InPreparation AddIngredient(string ingredient)
    {
        var newIngredients = Ingredients.Concat(new[] { ingredient }).ToList();
        return new InPreparation(CoffeeType, StartedAt, newIngredients);
    }

    public ReadyToServe MarkReady(DateTime readyAt)
    {
        return new ReadyToServe(CoffeeType, StartedAt, readyAt, Ingredients);
    }
}
