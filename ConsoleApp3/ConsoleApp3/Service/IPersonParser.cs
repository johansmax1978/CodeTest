using ConsoleApp3.Entity;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// ini yang bertugas untuk memparsing data string apakah sesuai format person atau tidak
	/// </summary>
	public interface IPersonParser
	{
		bool TryToParse(string s, out Person p);
		
	}
}