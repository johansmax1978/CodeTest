using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp3.Entity;
using ConsoleApp3.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
	[TestClass]
	public class PersonProviderFactoryTester
	{
		[TestMethod]
		public void Create__expect__PersonProvider()
		{
			Mock<IStringListProvider> slMock = new Mock<IStringListProvider>();
			Mock<IPersonParser> ppMock = new Mock<IPersonParser>();

			PersonProviderFactory teste = new PersonProviderFactory(slMock.Object, ppMock.Object);
			var result = teste.Create();
			Assert.IsInstanceOfType(result,typeof(PersonProvider));

		}
	}
}
