//Dictionary é uma coleção de pares chave/valor que:
//possui armazenamento em tabela hash, sendo extremamente rápido: inserção, remoção e busca O(1)
//A ordem dos elementos não é garantida
//dictionary[key] - acessa o elemento pela chave informada

//************************************************************************************************************

//SOrtedDictionary possui o armazenamento em árvore sendo rápido: inserção, remoção e busca O(log(n)).
//Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //criando um dictionary<tipo chave, tipo valor> nomeDictionary = Instanciação
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phones"] = "99712234";
            cookies["phones"] = "83737388";
            //vai sobreescrever o phone

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phones"]);

            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]);
            //vai dar erro de KeyNotFoundException


            //verificando a existencia das chaves:
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


            //imprimindo tamanho do dicionário
            Console.WriteLine("Size: " + cookies.Count);


            // podemos trocar o KeyValuePair<string, string> por var tbm
            //imprimindo todo o conteudo
            Console.WriteLine("ALL COOKIES: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

        }
    }
}
