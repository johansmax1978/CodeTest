using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// class yang membaca data dari kumpulan string dan mengoutputkan ienumerable person serta untuk menyimpannya lagi file
	/// </summary>
	public class PersonProvider : IPersonProvider
	{
		private readonly IStringListProvider _provider;
		private readonly IPersonParser _parser;

		public PersonProvider(IStringListProvider provider, IPersonParser parser)
		{
			_provider = provider;
			_parser=parser;
		}

		public IEnumerable<Person> GetPeople()
		{
			var listSource = _provider.GetStrings();
			var listDestination = new List<Person>();
			Person p;

			foreach (var s in listSource)
			{
				if (_parser.TryToParse(s, out p))
				{
					listDestination.Add(p);
				}
			}

			return listDestination;
		}

		public void SavePeople(IEnumerable<Person> persons)
		{
			var temp = from p in persons select p.ToString();
			_provider.SaveString(temp);
		}
	}
}
;