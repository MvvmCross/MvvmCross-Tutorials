namespace TipCalc.Core
{
    public interface ICalculation
    {
        double TipAmount(double subTotal, int generosity);
    }
}
