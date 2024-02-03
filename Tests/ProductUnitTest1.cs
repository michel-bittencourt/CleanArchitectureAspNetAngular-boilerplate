using Domain.Entities;
using FluentAssertions;

namespace Tests;

public class ProductUnitTest1
{
    [Fact(DisplayName = "Create product with valid state")]
    public void CreateProduct_ValidParameters_ResultObjectValidState()
    {
        Action action = () => new Product("Name", "Description", 50, 100, 5, default, default, 1);
        action.Should()
            .NotThrow<ArgumentNullException>();
    }
}