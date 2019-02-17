using System.Collections.Generic;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// class yang berfungsi untuk menyimpan data person ke file
	/// </summary>
	public class Saver : IOutputPort
	{
		private readonly IPersonProvider _provider;
		public Saver(IPersonProvider provider)
		{
			_provider = provider;
		}

		public void Send(IEnumerable<Person> persons)
		{
			_provider.SavePeople(persons);
		}
	}
}