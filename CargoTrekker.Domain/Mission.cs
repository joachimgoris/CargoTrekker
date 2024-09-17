namespace CargoTrekker.Domain;

public record Mission(int Reward, string Name)
{
    public IList<Objective> Objectives { get; set; } = [];

    public void AddObjective(Objective objective)
    {
        Objectives.Add(objective);
    }
}
