using System;
using System.Collections.Generic;

namespace CoffeeOrder;

public record ReadyToServe(string CoffeeType, DateTime StartedAt, DateTime ReadyAt, IReadOnlyList<string> Ingredients) : Coffee(CoffeeType)
{
    public Delivered Deliver(string deliveredBy, DateTime deliveredAt)
    {
        return new Delivered(CoffeeType, StartedAt, ReadyAt, deliveredAt, deliveredBy, Ingredients);
    }
}
