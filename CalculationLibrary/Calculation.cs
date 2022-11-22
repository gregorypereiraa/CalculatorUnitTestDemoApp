namespace CalculationLibrary;

public class Calculation
{
     public double Add(double x, double y)
    {
        return x + y;
    }

     public double Substract(double x, double y)
     {
         return x - y;
     }

     public double Divide(double x, double y)
     {
         int output = 0;
         if (y != 0)
         { 
             return x/y;
         }
         return output;

     }

     public double Multiply(double x, double y)
     {
         return x * y;
     }
}