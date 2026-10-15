namespace DotNet_Atelier1;

public class Wall : Tile
{
    public override bool IsTraversable
    {
        get => false;
    }

    public override bool Pass() => IsTraversable;
}