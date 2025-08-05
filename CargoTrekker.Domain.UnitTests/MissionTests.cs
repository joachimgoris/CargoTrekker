namespace CargoTrekker.Domain.UnitTests;

public class MissionTests
{
    [Test]
    public async Task MissionWithOneObjective()
    {
        // Arrange
        var location = new Location
        {
            Station = "Orison",
            System = "Stanton",
            Planet = "Crusader"
        };
        
        // Act
        var mission = new Mission(10000, "Aluminium for Orison");
        mission.AddObjective(new Objective(location, CargoType.Aluminium, 10));

        // Assert
        await Assert.That(mission.Objectives.Count).IsEqualTo(1);
        await Assert.That(mission.Objectives.First().CargoType).IsEqualTo(CargoType.Aluminium);
        await Assert.That(mission.Objectives.First().Amount).IsEqualTo(10);
    }

    [Test]
    public async Task MissionWithManyObjectivesWithDifferentCargo()
    {
        // Arrange
        var location = new Location
        {
            Station = "Orison",
            System = "Stanton",
            Planet = "Crusader"
        };
        
        // Act
        var mission = new Mission(10000, "Building materials for Orison");
        mission.AddObjective(
            new Objective(location, CargoType.Aluminium, 10));
        mission.AddObjective(
            new Objective(location, CargoType.Titanium, 10));
        
        // Assert
        await Assert.That(mission.Objectives.Count).IsEqualTo(2);
        await Assert.That(mission.Objectives.First().CargoType).IsEqualTo(CargoType.Aluminium);
        await Assert.That(mission.Objectives.First().Amount).IsEqualTo(10);
        await Assert.That(mission.Objectives.Last().CargoType).IsEqualTo(CargoType.Titanium);
        await Assert.That(mission.Objectives.Last().Amount).IsEqualTo(10);
    }

    [Test]
    public async Task MissionWithManyObjectivesWithDifferentCargoInDifferentLocations()
    {
        var greenGladeStation = new Location
        {
            Station = "HUR-L1 Green Glade Station",
            System = "Stanton",
            Planet = "Hurston"
        };
        var faithfulDreamStation = new Location
        {
            Station = "HUR-L2 Faithful Dream Station",
            System = "Stanton",
            Planet = "Hurston"
        };

        // Act
        var mission = new Mission(20000, "Stims");
        mission.AddObjective(new Objective(greenGladeStation, CargoType.Stims, 10));
        mission.AddObjective(new Objective(faithfulDreamStation, CargoType.Stims, 10));
        
        // Assert
        await Assert.That(mission.Objectives.Count).IsEqualTo(2);
        await Assert.That(mission.Objectives.First().CargoType).IsEqualTo(CargoType.Stims);
        await Assert.That(mission.Objectives.First().Amount).IsEqualTo(10);
        await Assert.That(mission.Objectives.First().Destination).IsEqualTo(greenGladeStation);
        await Assert.That(mission.Objectives.Last().CargoType).IsEqualTo(CargoType.Stims);
        await Assert.That(mission.Objectives.Last().Amount).IsEqualTo(10);
        await Assert.That(mission.Objectives.Last().Destination).IsEqualTo(faithfulDreamStation);
    }
}