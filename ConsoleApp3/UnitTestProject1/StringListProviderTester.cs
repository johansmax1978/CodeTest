using System;
using System;
using System.Linq;
using ConsoleApp3.Entity;
using ConsoleApp3.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class StringListProviderTester
	{

		[TestMethod]
		public void TestRead_file_exists_contain_3_person__expect__3_lines()
		{
			var teste = new StringListProvider("unsorted-names-list.txt");
			var result = teste.GetStrings().ToList();
			Assert.AreEqual(3, result.Count);
			Assert.AreEqual("Orson Milka Iddins", result[0]);
			Assert.AreEqual("Erna Dorey Battelle", result[1]);
			Assert.AreEqual("Flori Chaunce Franzel", result[2]);

		}


		[TestMethod]
		public void Write_file_not_exists___expect__file_exists_size_greater_than_zero()
		{
			var fileName = "output.txt";
			var teste = new StringListProvider(fileName);
			if (System.IO.File.Exists(fileName))
				System.IO.File.Delete(fileName);
			string [] list = new string[]{"johan","sebastian","max"};
			teste.SaveString(list);
			if (!System.IO.File.Exists(fileName))
				Assert.Fail("file gagal dibuat");
			if(new System.IO.FileInfo(fileName).Length==0)
				Assert.Fail("file kosong");


		}
	}
}
