using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the temperature in Celsius");
    int celsius = Convert.ToInt32(Console.ReadLine());

    double farenheit = ((celsius * 1.8) + 32);

    Console.WriteLine("Farenheit equivalent for " + celsius + " degree celsius is " + farenheit );

    if (farenheit < 32) {
      Console.WriteLine("This temperature is below freezing temperature of 32 degrees farenheit");
    }else if (farenheit > 212) {
      Console.WriteLine("This temperature is above boiling temperature of 212 degrees farenheit");
    }
  }
}