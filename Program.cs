using System;

public class Program {
    public static void Main(string[] args) {
        int num1 = ConvertStringToInt(InputNum1());
        int num2 = ConvertStringToInt(InputNum2());
        int num3 = ConvertStringToInt(InputNum3());
        int result = num1 + num2 + num3;

        Console.WriteLine("Sum: {0}",result);
    }

    public static string InputNum1() {
        Console.Write("Please input number 1: ");
        return Console.ReadLine();
    }

    public static string InputNum2() {
        Console.Write("Please input number 2: ");
        return Console.ReadLine();
    }

    public static string InputNum3() {
        Console.Write("Please input number 3: ");
        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value) {
        if (int.TryParse(value, out int number)) {
            return number;
        }

        throw new Exception("Please input Number.");
    }
}