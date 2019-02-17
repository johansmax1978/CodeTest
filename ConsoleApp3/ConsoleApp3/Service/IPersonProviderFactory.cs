namespace ConsoleApp3.Service
{
	/// <summary>
	/// ini yang bertugas membuat class ipersonprovider.
	/// Jika menggunakan IOC framework maka class ini tidak ada
	/// </summary>
	public interface IPersonProviderFactory
	{
		IPersonProvider Create();
	}
}