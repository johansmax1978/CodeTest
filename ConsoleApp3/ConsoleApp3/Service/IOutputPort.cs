using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// ini berfungsi untuk mengoutputkan data person. implementasinya bisa kemana saja
	/// </summary>
	public interface IOutputPort
	{
		void Send(IEnumerable<Person> persons);
	}
}
