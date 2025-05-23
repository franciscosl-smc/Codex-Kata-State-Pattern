using System;
using System.Collections.Generic;

namespace CoffeeOrder;

public record Delivered(
    string CoffeeType,
    DateTime StartedAt,
    DateTime ReadyAt,
    DateTime DeliveredAt,
    string DeliveredBy,
    IReadOnlyList<string> Ingredients) : Coffee(CoffeeType);
