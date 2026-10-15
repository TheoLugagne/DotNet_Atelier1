namespace DotNet_Atelier1;

public class Room : Tile
{
    private ICollectable? Collectable;
    
    public Room(ICollectable? collectable) { Collectable = collectable; }
    
    public override bool IsTraversable
    {
        get => true;
    }
    
    public override bool Pass() => IsTraversable;
}