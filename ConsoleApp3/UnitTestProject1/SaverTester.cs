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
	public class SaverTester
	{
		[TestMethod]
		public void Send__expect__save_person_called()
		{
			Mock<IPersonProvider> ppMock = new Mock<IPersonProvider>();
			var list = new List<Person>();
			ppMock.Setup(pp => pp.SavePeople(It.IsNotNull<IEnumerable<Person>>())).Callback(delegate(IEnumerable<Person> people) { list.AddRange(people); });

var teste = new Saver(ppMock.Object);
			var list2 = new List<Person>()
			{
				new Person() {FirstName = "A", LastName = "B"},
				new Person() {FirstName = "C", LastName = "D"}
			};
			teste.Send(list2);
			Assert.AreEqual(2, list.Count);
			ppMock.Verify( mock=> mock.SavePeople(It.IsNotNull<IEnumerable<Person>>()), Times.Once );


		}
	}
}
