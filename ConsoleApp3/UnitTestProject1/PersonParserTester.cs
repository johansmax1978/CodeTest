using System;
using ConsoleApp3.Entity;
using ConsoleApp3.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class PersonParserTester
	{
		[TestMethod]
		public void String_Empty__expect__false_p_isnull()
		{
			var teste = new PersonParser();
			Person p;
			var result = teste.TryToParse(string.Empty, out p);
			Assert.AreEqual(false, result);
			Assert.IsNull(p);

		}

		[TestMethod]
		public void String_contain_first_name__expect__false_p_isnull()
		{
			var teste = new PersonParser();
			Person p;
			var result = teste.TryToParse("Johan", out p);
			Assert.AreEqual(false, result);
			Assert.IsNull(p);

		}

		[TestMethod]
		public void String_contain_2_name__expect__true_p_firstname_and_lastname_contain_value()
		{
			var teste = new PersonParser();
			Person p;
			var result = teste.TryToParse("johan sebastian", out p);
			Assert.AreEqual(true, result);
			Assert.IsNotNull(p);
			Assert.AreEqual("johan", p.FirstName);
			Assert.AreEqual("sebastian", p.LastName);
			Assert.AreEqual(string.Empty,p.MiddleName);
		}

		[TestMethod]
		public void String_contain_3_name__expect__true_p_firstname_middlename_and_lastname_contain_value()
		{
			var teste = new PersonParser();
			Person p;
			var result = teste.TryToParse("johan sebastian max", out p);
			Assert.AreEqual(true, result);
			Assert.IsNotNull(p);
			Assert.AreEqual("johan", p.FirstName);
			Assert.AreEqual("sebastian", p.MiddleName);
			Assert.AreEqual("max", p.LastName);
		}

		[TestMethod]
		public void String_contain_4_name__expect__true_p_firstname_middlename_and_lastname_contain_value_the_last_token_disgarded()
		{
			var teste = new PersonParser();
			Person p;
			var result = teste.TryToParse("johan sebastian max goris", out p);
			Assert.AreEqual(true, result);
			Assert.IsNotNull(p);
			Assert.AreEqual("johan", p.FirstName);
			Assert.AreEqual("sebastian", p.MiddleName);
			Assert.AreEqual("max", p.LastName);
		}

	}
}
