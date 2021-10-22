using System;
using EFCoreConsoleApp;
using System.Threading.Tasks;

namespace EFCoreConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IClientsRepository clientsRepository;
            clientsRepository = new ClientsReposetory();

            var update = await clientsRepository.Update("Halif", "Halid");

            var delete = await clientsRepository.Delete("Halid");

            var insert = await clientsRepository.Insert("Muhammad");

            var blabla = await clientsRepository.Select();
            foreach (var item in blabla)
            {
                Console.WriteLine("Id: " + item.Id + ",   Login: " + item.Login);
            }

            
        }
    }
}
