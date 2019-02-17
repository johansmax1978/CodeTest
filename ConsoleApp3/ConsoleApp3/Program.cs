using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Service;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileName = args[0];
			IStringListProvider stringListProvider = new StringListProvider(fileName);
			IPersonParser parser = new PersonParser();
			IPersonProviderFactory factory = new PersonProviderFactory(stringListProvider,parser);


			IPersonProvider personProvider = factory.Create();
			
			  var list = personProvider.GetPeople().ToList();
			list.Sort();
			IOutputPort output = new Displayer();
			output.Send(list);

			stringListProvider = new StringListProvider("sorted-names - list.txt");
			factory = new PersonProviderFactory(stringListProvider, parser);
			personProvider = factory.Create();
			output = new Saver(personProvider);
			output.Send(list);
			Console.WriteLine("End");
			Console.ReadLine();

		}
	}
}
