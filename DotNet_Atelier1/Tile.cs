namespace DotNet_Atelier1;

public abstract class Tile
{
    public abstract bool IsTraversable { get; }
    public abstract bool Pass();
}