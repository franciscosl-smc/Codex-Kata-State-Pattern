using System;
using System.Collections.Generic;

namespace CoffeeOrder;

public record NewOrder(string CoffeeType) : Coffee(CoffeeType)
{
    public InPreparation Accept(DateTime startedAt)
    {
        return new InPreparation(CoffeeType, startedAt, new List<string>());
    }
}
