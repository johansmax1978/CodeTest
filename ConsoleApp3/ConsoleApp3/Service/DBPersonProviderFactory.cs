namespace ConsoleApp3.Service
{
	/// <summary>
	/// Ini yang bertugas melakukan instansiasi class dbprovider. Dibutuhkan untuk demo solid.
	/// Harusnya menggunakan IOC framework seperti castle
	/// </summary>
	public class DBPersonProviderFactory:IPersonProviderFactory
	{
		public IPersonProvider Create()
		{
			return  new DBPersonProvider();
		}
	}
}