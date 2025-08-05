namespace CargoTrekker.Domain;

public class Cargo
{
    // public static ICollection<CargoType> Commodities =>
    // [
    //     CargoType.Aluminium,
    //     CargoType.Corundum,
    //     CargoType.Stims,
    //     CargoType.Tin,
    //     CargoType.Titanium,
    //     CargoType.AgriculturalSupplies,
    //     CargoType.Gold
    // ];

    // public static ICollection<ScuSize> ScuSizes =>
    //     [
    //     ScuSize.One,
    //     ScuSize.Two,
    //     ScuSize.Four,
    //     ScuSize.Eight,
    //     ScuSize.Sixteen,
    //     ScuSize.TwentyFour,
    //     ScuSize.ThirtyTwo
    //     ];

    public CargoType Commodity { get; set; }
    public int Amount { get; set; }
    public ScuSize ScuSize { get; set; }
}