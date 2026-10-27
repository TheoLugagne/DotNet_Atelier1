namespace DotNet_Atelier1;

public class Wall(WallOrientation orientation) : Tile
{
    private static WallOrientation OrientationFromChar(char c) => c switch
    {
        '-' => WallOrientation.Horizontal,
        '|' => WallOrientation.Vertical,
        '+' => WallOrientation.Cross,
        _ => throw new ArgumentException("Invalid wall character")
    };
    public Wall(char c) : this(OrientationFromChar(c)) {}
    public override bool IsTraversable => false;
    public override bool Pass() => IsTraversable;
    public override char Display() => orientation switch
    {
        WallOrientation.Horizontal => '-',
        WallOrientation.Vertical => '|',
        WallOrientation.Cross => '+',
        _ => throw new ArgumentException("Invalid wall orientation")
    };
}