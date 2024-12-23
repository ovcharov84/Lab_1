namespace Lab_1
{
    public class Calculator : IAdd, IDivide, ISubtract, IMultiply
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
