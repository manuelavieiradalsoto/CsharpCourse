using System;
using System.IO;
using System.Text;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\A_PROJETOS_CS\MANIPULACAO ARQUIVOS\EntendendoFileStream\TEXT.txt";

            if (File.Exists(caminho))
            {
                File.Delete(caminho);

            }


            using(FileStream fs = File.Create(caminho))
            {
                AddText(fs, "aaa");
            }


        }
        private static void AddText(FileStream fs, string value)
        {
            //nao entendi o que é isso aqui
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}