using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++) 
            {
                Console.WriteLine(i + ":" + args[i]);
            }

            float height = GetInputAndParseFloat("身長を入力してください(m)");
            float weight = GetInputAndParseFloat("体重を入力してください(kg)");
            float bmi = CalcBMI(height, weight);

            Console.WriteLine("BMIは" + bmi + "です。");
        }
        static float GetInputAndParseFloat(string log)
        {
            bool parseSuccess = false;
            float parsedValue = 0f;
            while (!parseSuccess)
            {
                Console.WriteLine(log);
                string input = Console.ReadLine();
                parseSuccess = float.TryParse(input, out parsedValue);

                if (!parseSuccess)
                    Console.WriteLine("数値を入力して下さい。");
            }
            return parsedValue;
        }
        static float CalcBMI(float height, float weight)
        {
            return weight / (height * height);
        }
    }
}
