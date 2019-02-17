using System.Collections.Generic;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// Ini untuk membaca data person dari database
	/// </summary>
	public class DBPersonProvider : IPersonProvider
	{
		public IEnumerable<Person> GetPeople()
		{
			throw new System.NotImplementedException();
		}

		public void SavePeople(IEnumerable<Person> persons)
		{
			throw new System.NotImplementedException();
		}
	}
}