namespace DotNet_Atelier1;

public class Door(Key? key) : Tile
{
    private Key? Key { get; set; } = key;
    private DoorState State { get; set; } = DoorState.Closed;
    
    public Door(char c) : this(null) {}

    private bool IsOpen() => State == DoorState.Open;
    private void Open()
    {
        if (!(State == DoorState.Closed && Key is not null)) return;
        State = DoorState.Open;
        Key = null;
    }

    public override bool IsTraversable => IsOpen();

    public override bool Pass()
    {
        Open();
        return IsTraversable;
    }

    public override char Display() => '/';
}