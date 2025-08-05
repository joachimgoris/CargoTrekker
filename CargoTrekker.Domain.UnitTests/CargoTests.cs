namespace CargoTrekker.Domain.UnitTests;

public class CargoTests
{
    [Test]
    public async Task Cargo_SuccessfullyCreates()
    {
        var cargo = new Cargo
        {
            Commodity = CargoType.Aluminium,
            Amount = 10,
            ScuSize = ScuSize.Eight,
        };

        await Assert.That(cargo.Commodity).IsEqualTo(CargoType.Aluminium);
        await Assert.That(cargo.Amount).IsEqualTo(10);
        await Assert.That(cargo.ScuSize).IsEqualTo(ScuSize.Eight);
    }
}