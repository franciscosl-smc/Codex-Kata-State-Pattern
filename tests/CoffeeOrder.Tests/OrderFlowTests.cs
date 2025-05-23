using System;
using Shouldly;
using Xunit;

namespace CoffeeOrder.Tests;

public class OrderFlowTests
{
    [Fact]
    public void Happy_path_should_transition_through_all_states()
    {
        var now = new DateTime(2024, 1, 1, 8, 0, 0);
        var order = new NewOrder("Espresso");

        var inPrep = order.Accept(now);
        inPrep.CoffeeType.ShouldBe("Espresso");
        inPrep.StartedAt.ShouldBe(now);
        inPrep.Ingredients.ShouldBeEmpty();

        var withMilk = inPrep.AddIngredient("Milk");
        withMilk.Ingredients.ShouldContain("Milk");

        var readyAt = now.AddMinutes(5);
        var ready = withMilk.MarkReady(readyAt);
        ready.ReadyAt.ShouldBe(readyAt);
        ready.Ingredients.ShouldContain("Milk");

        var deliveredAt = readyAt.AddMinutes(1);
        var delivered = ready.Deliver("Alice", deliveredAt);
        delivered.DeliveredBy.ShouldBe("Alice");
        delivered.DeliveredAt.ShouldBe(deliveredAt);
        delivered.Ingredients.ShouldContain("Milk");
    }
}
