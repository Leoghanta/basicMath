using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
	public class BasicMath
	{
		/// <summary>
		/// Add two numbers together
		/// </summary>
		/// <param name="num1">Integer to add</param>
		/// <param name="num2">Integer to add</param>
		/// <returns></returns>
		public double Add (int num1, int num2)
		{
			return num1 + num2;
		}

		/// <summary>
		/// Subtract num2 from num1
		/// </summary>
		/// <param name="num1">original int</param>
		/// <param name="num2">int to subtract</param>
		/// <returns></returns>
		public double Subtract (int num1, int num2)
		{
			return num1 - num2;
		}

		/// <summary>
		/// Multiply two numbers together
		/// </summary>
		/// <param name="num1">Int to multiply</param>
		/// <param name="num2">Int to multiply</param>
		/// <returns></returns>
		public double Multiply (int num1, int num2)
		{
			return num1 * num2;
		}

		/// <summary>
		/// Divide numerator by demonminator
		/// </summary>
		/// <param name="numerator">Top number of division as int</param>
		/// <param name="denominator">divisor number as int</param>
		/// <returns></returns>
		public double Divide (int numerator, int denominator)
		{
			return numerator / denominator;
		}

	}
}
