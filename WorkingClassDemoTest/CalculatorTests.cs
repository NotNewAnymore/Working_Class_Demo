using Microsoft.VisualStudio.TestTools.UnitTesting;
using Working_Class_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_Class_Demo.Tests
{
	[TestClass()]
	public class CalculatorTests
	{
		//Arrange - Make methods independant
		//Act - Call Method
		//Assert
		[TestMethod()]
		public void AddTestSucess()
		{
			//Arrange
			Calculator calc = new Calculator();
			double number1 = 2;
			double number2 = 2;
			double expected = 4;

			//Act
			double outcome = calc.add(number1, number2);

			//Assert
			Assert.AreEqual(expected, outcome);
			//Assert.AreEqual(10,10);
			//Assert.Fail();
		}
		[TestMethod()]
		public void AddTestFail()
		{
			//Arrange
			Calculator calc = new Calculator();
			double number1 = 2;
			double number2 = 2;
			double notexpected = 5;
			//Act
			double outcome = calc.add(number1, number2);
			//Assert
			Assert.AreNotEqual(notexpected, outcome);
		}//AddTestFail()
		[TestMethod()]
		public void MultTestSucess()
		{
			//Arrange
			Calculator calc = new Calculator();
			double number1 = 2;
			double number2 = 10;
			double expected = 20;

			//Act
			double outcome = calc.mult(number1, number2);

			//Assert
			Assert.AreEqual(expected, outcome);
		}

		[TestMethod()]
		public void MultTestFail()
		{
			//Arrange
			Calculator calc = new Calculator();
			double number1 = 2;
			double number2 = 10;
			double expected = 0;

			//Act
			double outcome = calc.mult(number1, number2);

			//Assert
			Assert.AreNotEqual(expected, outcome);
		}
	}
}