using System;

namespace TemperatureConverter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			#region This portion does up the console input and calculations.
			// initialization of variables
			double Celsius;
			double userFahrenheit;
			string temperatureReading = null;

			// Obtaining user input.
			Console.WriteLine("Enter the temperature in degrees Fahrenheit with no units: ");
			userFahrenheit = double.Parse(Console.ReadLine());

			// Conversion calculation
			Celsius = (((userFahrenheit - 32) *5) / 9);
			#endregion

			#region This portion is the if statements that control the snarky commentary for weather temperature.
			if (Celsius < -30)
				temperatureReading = "My WORD. Are we in the Antarctic?";
			else if (Celsius > -30 && Celsius < -15)
				temperatureReading = "Have you considered moving to Canada?";
			else if (Celsius > -14 && Celsius < 5)
				temperatureReading = "I hope you’ve invested in a decent windbreaker and toque.";
			else if (Celsius > 6 && Celsius < 12)
				temperatureReading = "What a lovely spring day we’re having!";
			else if (Celsius > 13 && Celsius < 17)
				temperatureReading = "This really could be the start of a lovely season.";
			else if (Celsius > 18 && Celsius < 22)
				temperatureReading = "Goodbye sweatshirts, hello, t-shirts!";
			else if (Celsius > 23 && Celsius < 28)
				temperatureReading = "For the average Canadian, this may be a bit much…";
			else if (Celsius > 29)
				temperatureReading = "Anyone feel like heading up to the frozen north for a minute?";
			#endregion

			#region And finally, this portion displays the output.
			// Console output: rounds Celsius calculation to 2 decimal places.
			Console.WriteLine("Your temperature entered was " + userFahrenheit + " degrees Fahrenheit.");
			Console.WriteLine($"Your temperature, converted to Celsius, is {Celsius:#.00} C.");
			Console.WriteLine(temperatureReading);
			#endregion
		}
	}
}
