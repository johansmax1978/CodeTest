using System.Collections.Generic;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// ini yang bertugas untuk membaca dan menulis data person		
	/// </summary>
	public interface IPersonProvider
	{
		IEnumerable<Person> GetPeople();
		void SavePeople(IEnumerable<Person> persons);


	}
}