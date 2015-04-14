namespace Shapes.Interfaces
{
    interface IShape
    {
        int Width { get; }
        int Height { get; }
        double CalculateSurface();
    }
}
