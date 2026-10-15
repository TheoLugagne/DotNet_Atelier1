namespace DotNet_Atelier1;

public class Door : Tile
{
    private Key? Key { get; set; }
    private DoorState State { get; set; }

    public Door(Key? key)
    {
        Key = key;
        State = DoorState.Closed;
    }

    private bool IsOpen() => State == DoorState.Open;
    private void Open()
    {
        if (State == DoorState.Closed && Key is not null)
        {
            State = DoorState.Open;
            Key = null;
        }
    }

    public override bool IsTraversable
    {
        get => IsOpen();
    }

    public override bool Pass()
    {
        Open();
        return IsTraversable;
    }
}