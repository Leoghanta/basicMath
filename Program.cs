namespace ConsoleApp15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BasicMath basicMath = new BasicMath();
			Console.WriteLine("Basic Math Examples");
			Console.WriteLine($"5 + 7 = {basicMath.Add(5, 7)}");
			Console.WriteLine($"8 - 4 = {basicMath.Subtract(8, 4)}");
			Console.WriteLine($"7 * 6 = {basicMath.Multiply(7, 6)}");
			Console.WriteLine($"9 / 3 = {basicMath.Divide(9, 3)}");

		}
	}
}