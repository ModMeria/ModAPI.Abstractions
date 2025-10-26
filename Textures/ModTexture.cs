namespace ModAPI.Abstractions.Textures;

public class ModTexture
{
    public int X;
    public int Y;

    public ModTexture(int x, int y)
    {
        X = x;
        Y = y;
    }

    public ModTexture()
    {
        X = 64;
        Y = 0;
    }
}