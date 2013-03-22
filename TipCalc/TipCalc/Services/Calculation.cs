namespace TipCalc.Core.Services
{
    public class Calculation : ICalculation
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return (generosity*subTotal)/100.0;
        }
    }
}