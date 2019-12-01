using System;
using Maverick_Home_work.Interfaces;
using Maverick_Home_work.Modes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Maverick_Home_work
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void calculate_LessThanOneYearEmployee_Bonus()
		{
            var fakeLogger = Substitute.For<ILogger>();
            var fakeSalaryRepo = Substitute.For<ISalaryRepo>();
            //if my monthly salary is 1200, working year is 0.5, my bonus should be 600
            var lessThanOneYearEmployee = new LessThanOneYearEmployee(fakeLogger, fakeSalaryRepo)
			{
				Id = 91,
				//Console.WriteLine("your StartDate should be :{0}", DateTime.Today.AddDays(365/2*-1));
				Today = new DateTime(2018, 1, 27),
				StartWorkingDate = new DateTime(2017, 7, 29)
			};

			var actual = lessThanOneYearEmployee.GetYearlyBonus();
			Assert.AreEqual(600, 600);
		}
	}
}