namespace CalculatorApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("1.ededi daxil ediniz");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.ededi daxil ediniz");
            int number2 = int.Parse(Console.ReadLine());

            int addResult =  add(number1,number2,5);     

            Console.WriteLine($"Tolamananin neticesi {addResult}");

            int subtractionResult = substraction(number1,number2);

            Console.WriteLine($"Cixmanim neticesi {subtractionResult}");

            int multiplyResult = multiply(number1,number2);
            Console.WriteLine($"Vurmanin neticesi {multiplyResult}");

            float divideResult =divide(number1,number2);
            Console.WriteLine($"Bolmenin neticesi {divideResult}");


        }




        public static int add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
      
        public static int add(int num1, float num2)
        {
            int result = num1 + (int)num2;
            return result;
        }
        public static int add(int num1, int num2,int num3) {
            int result =num1 + num2+num3;
            return result;
        }

        public static int substraction(int num1, int num2) { 
        
            int result = num1 - num2;
            return result;
        
        }

        public static int multiply(int num1, int num2)
        {
            int result=num1 * num2;
            return result;
            
        }

        public static float divide(float num1, float num2) {
        
             float result = num1 / num2;
             return result;
        }
    }
}