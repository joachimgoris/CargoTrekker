namespace CargoTrekker.Domain;

public record Objective(Location Destination, CargoType CargoType, int Amount);
