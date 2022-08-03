using Newtonsoft.Json;
using Refit;
using System;

namespace Exercicio8
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            string timestamp = "1659531409";
            string pubKey = "912cdd8fa1c519e2789932117177804a";
            string hash = "58f3ea612f4271e15ad84c6eae4aab25";

            try
            {
                var dataClient = RestService.For<IMarvelApiService>("https://gateway.marvel.com");
                Console.WriteLine("dataClient: " + dataClient);

                var address = await dataClient.GetAddressAsync(timestamp, pubKey, hash);

                for (int i = 0; i < address.data.results.Count; i++)
                {

                    for (int j = 0; j < address.data.results[i].characters.items.Count; j++)
                    {
                        if (address.data.results[i].characters.items[j].name == "Wolverine"){
                            if (address.data.results[i].format == "Comic")
                            {
                                Console.WriteLine(address.data.results[i].title + ",");
                            }
                            else
                            {
                                Console.WriteLine(address.data.results[i].title + ",");
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta dos dados gerais: " + e.Message);
            }
        }
    }
}


