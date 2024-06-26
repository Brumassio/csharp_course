using System.Globalization;
using System.IO;

namespace Sessao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de fixação de manipulação de arquivos");
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Digite o caminho de um arquivo .csv: ");
            string path = Console.ReadLine();
            path = @""+path;
            StreamReader sr = null;
            string[,] lines = new string[4, 3];
            int  auxiliar= 0;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] aux = sr.ReadLine().Split(",");
                    for(int i = 0; i < lines.GetLength(1); i++)
                    {
                        lines[auxiliar, i] = aux[i];
                    }
                    auxiliar++;
                }
                string newDirectory = @"C:\temp\out";
                Directory.CreateDirectory(newDirectory);
                string targetPath = newDirectory +@"\summary.csv";

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    for(int i=0; i< lines.GetLength(0); i++)
                    {
                        sw.WriteLine(lines[i,0]+", "+ (double.Parse(lines[i, 1],CultureInfo.InvariantCulture)* int.Parse(lines[i,2])).ToString("F2",CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
        }
    }
}
