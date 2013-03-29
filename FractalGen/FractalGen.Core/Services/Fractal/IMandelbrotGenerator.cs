namespace FractalGen.Core.Services
{
    public interface IMandelbrotGenerator
    {
        IMandelbrot Generate(int width, int height);
    }
}