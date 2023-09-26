using System;

namespace DelegateExample
{
    public class MathOperator
    {
        public float Add(float a, float b) => a + b;
        public float Sub(float a, float b) => a - b;
        public float Mul(float a, float b) => a * b;
    }
    
    internal class Program
    {
        public static Action<string> writeSomething;
        public static void Main()
        {
            var mathOperator = new MathOperator();
            
            writeSomething?.Invoke("Hello");
        }

        public static void WriteSomething(string message)
        {
            Console.WriteLine(message);
        }
      
        


    }
}