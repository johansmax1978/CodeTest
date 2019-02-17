using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entity
{
	public class Person : IComparable
	{
		public  string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }

		public override string ToString()
		{
			return FirstName + " " + MiddleName + (string.IsNullOrEmpty(MiddleName) ? string.Empty : " ") + LastName;
		}

		public int CompareTo(object obj)
		{
			var temp = obj as Person;
			return string.Compare(this.LastName, temp.LastName);
		}
	}
}
