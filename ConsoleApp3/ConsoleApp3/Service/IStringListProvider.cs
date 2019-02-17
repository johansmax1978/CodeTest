using System;
using System.Collections.Generic;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// Ini yang bertugas untuk membaca data dan menulis data dari string. Dibuat seperti ini agar data bisa berasal dari file atau dari string bebas
	/// 
	/// </summary>
	public interface IStringListProvider
	{
		IEnumerable<String> GetStrings();
		void SaveString(IEnumerable<string> vs);
	}
}