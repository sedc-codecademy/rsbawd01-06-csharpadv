namespace StaticClasses.Helpers
{
    public static class MathHelpers
    {
        public static int CountOfAddUsage = 0;
        public static int CountOfSubtractUsage = 0;
        public static int CountOfMultiplyUsage = 0;
        public static int CountOfDivideUsage = 0;

        public static double Add(double x, double y) 
        {
            CountOfAddUsage++;
            return x + y;
        }

        public static double Subtract(double x, double y) 
        {
            CountOfSubtractUsage++;
            return x - y; 
        }

        public static double Multiply(double x, double y) 
        {
            CountOfMultiplyUsage++;
            return x * y; 
        }

        public static double Divide(double x, double y) 
        {
            CountOfDivideUsage++;
            return x / y;
        }
    }
}
