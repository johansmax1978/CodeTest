using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// berfungsi untuk memvalidasi string apakah sesuai format atu tidak
	/// </summary>
	public class PersonParser : IPersonParser
	{
		public bool TryToParse(string s, out Person p)
		{
			p = null;
			if (string.IsNullOrEmpty(s)) return false;
			var arr = s.Split(' ');
			if (arr.Length < 2) return false;
			p = new Person()
			{
				FirstName = arr[0],
				MiddleName = arr.Length == 2 ? string.Empty : arr[1],
				LastName = arr.Length == 2 ? arr[1] : arr[2]

			};
			return true;
		}
	}
}
