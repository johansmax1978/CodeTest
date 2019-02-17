using System;
using System.Collections.Generic;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// Class yang berfungsi menampilkan data ke display
	/// </summary>
	public class Displayer : IOutputPort
	{
		public Displayer()
		{
		}

		public void Send(IEnumerable<Person> persons)
		{
			foreach (var person in persons)
			{
				Console.WriteLine(person);
			}
		}
	}
}