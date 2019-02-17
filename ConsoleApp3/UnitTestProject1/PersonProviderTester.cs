using System;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp3.Entity;
using ConsoleApp3.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Moq;

namespace UnitTestProject1
{
	[TestClass]
	public class PersonProviderTester
	{
		[TestMethod]
		public void Read_3_person_valid__expect__3_person_returned()
		{
			Mock<IStringListProvider> slMock = new Mock<IStringListProvider>();
			slMock.Setup(provider => provider.GetStrings())
				.Returns(new string[] {"Johan Sebastian", "Andre Satya", "Lucy Darnawan"});
			PersonParser pp = new PersonParser();
			PersonProvider teste = new PersonProvider(slMock.Object, pp);
			var result = teste.GetPeople().ToList();
			Assert.IsNotNull(result);
			slMock.Verify(mock => mock.GetStrings(), Times.Once);
			Assert.AreEqual(3, result.Count);
			Assert.AreEqual("Johan Sebastian", result[0].ToString());
			Assert.AreEqual("Andre Satya", result[1].ToString());
			Assert.AreEqual("Lucy Darnawan", result[2].ToString());

		}

		[TestMethod]
		public void Read_3_item_2_person_valid__expect__2_person_returned()
		{
			Mock<IStringListProvider> slMock = new Mock<IStringListProvider>();
			slMock.Setup(provider => provider.GetStrings())
				.Returns(new string[] {"Johan Sebastian", "Andre Satya", ""});
			PersonParser pp = new PersonParser();
			PersonProvider teste = new PersonProvider(slMock.Object, pp);
			var result = teste.GetPeople().ToList();
			Assert.IsNotNull(result);
			slMock.Verify(mock => mock.GetStrings(), Times.Once);
			Assert.AreEqual(2, result.Count);
			Assert.AreEqual("Johan Sebastian", result[0].ToString());
			Assert.AreEqual("Andre Satya", result[1].ToString());

		}

		[TestMethod]
		public void write_2_person_valid__expect__2_person_written_as_2_line()
		{
			Mock<IStringListProvider> slMock = new Mock<IStringListProvider>();
			List<string> list = new List<string>();
			slMock.Setup(provider => provider.SaveString(It.IsNotNull<IEnumerable<string>>()))
				.Callback(delegate(IEnumerable<string> x) { list.AddRange(x); });
			PersonParser pp = new PersonParser();
			PersonProvider teste = new PersonProvider(slMock.Object, pp);
			var list2 = new List<Person>()
			{
				new Person() {FirstName = "A", LastName = "B"},
				new Person() {FirstName = "C", LastName = "D"}
			};
			teste.SavePeople(list2);
			slMock.Verify(mock => mock.SaveString(It.IsNotNull<IEnumerable<string>>()), Times.Once);
			Assert.AreEqual(2, list.Count);
		}
	}
}
