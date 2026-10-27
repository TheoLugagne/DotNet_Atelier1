namespace DotNet_Atelier1;

public static class CollectableHelper
{
    public static ICollectable? FromChar(char c) => c switch
    {
        'k' => new Key(),
        _ => null
    };
}