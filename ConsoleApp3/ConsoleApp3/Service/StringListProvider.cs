using System;
using System.Collections.Generic;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// Class yang berfungsi untuk membaca dan menulis ke file string
	/// </summary>
	public class StringListProvider : IStringListProvider
	{
		private readonly string _fileName;
		public StringListProvider(string fileName)
		{
			_fileName = fileName;
		}
		public IEnumerable<String> GetStrings()
		{
			return System.IO.File.ReadAllLines(_fileName);
		}

		public  void SaveString(IEnumerable<string> vs)
		{
			System.IO.File.WriteAllLines(_fileName,vs);
		}

	}
}
