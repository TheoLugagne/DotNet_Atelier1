namespace DotNet_Atelier1;

public class Room(ICollectable? collectable) : Tile, IDisplayable
{
    public Room(char c) : this(CollectableHelper.FromChar(c)) {}
    
    public override bool IsTraversable => true;
    
    public override bool Pass() => IsTraversable;
    public override char Display() => collectable is null ? ' ' : collectable.Display();
    
}