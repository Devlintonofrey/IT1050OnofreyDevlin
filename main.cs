using System;

public class Program
{
	public static void Main()
	{
    /*temperature in celsius. If temperature is below freezing, display "This temperature is below freezing of 32 degree Farenheit" otherwise do nothing. 
    If temperature is above boiling, display "This temperature is above boiling point of 212 degree Farenheit" otherwise do nothing.
    */

		double fahrenheit, celsius;

		Console.WriteLine("Enter the Celsius value : ");
		celsius = Convert.ToInt32(Console.ReadLine());

		fahrenheit = (celsius * 9)/5 + 32;

		Console.WriteLine("Fahrenheit : {0}",fahrenheit);

        //Comparison >, <, ==, <=, >=
    if (fahrenheit < 32 )
    {
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
    }

    if (fahrenheit > 212 )
    {
      Console.WriteLine("This temperature is above boiling");
    }


	}
}
