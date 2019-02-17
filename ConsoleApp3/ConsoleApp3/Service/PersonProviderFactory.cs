using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Service
{
	/// <summary>
	/// class yang berfungsi untuk menghasilkan class personprovider.
	/// Dibutuhkan karena tidak menggunakan IOC framework
	/// </summary>
	public class PersonProviderFactory : IPersonProviderFactory
	{
		private readonly IStringListProvider _provider;
		private readonly IPersonParser _parser;
		public PersonProviderFactory(IStringListProvider provider, IPersonParser parser)
		{
			_provider = provider;
			_parser = parser;
		}
		public IPersonProvider Create()
		{
			return new PersonProvider(_provider, _parser);
		}
	}
}
