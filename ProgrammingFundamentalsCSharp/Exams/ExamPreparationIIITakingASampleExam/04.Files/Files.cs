using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, long> files =
                new Dictionary<string, long>();
            List<string> inputData = new List<string>();
            for (int i = 0; i < n; i++)
            {
                inputData.Add(Console.ReadLine());
            }
            string[] extensionAndRoot = Console.ReadLine()
                .Split(new string[] { " in " },
             StringSplitOptions.RemoveEmptyEntries);

            string extension = "." + extensionAndRoot[0];
            string root = extensionAndRoot[1];
            bool match = false;
            foreach (string data in inputData)
            {
                string[] dataTokens = data.Split(new[] { '\\', ';' },
                    StringSplitOptions.RemoveEmptyEntries);
                string rootName = dataTokens[0];
                string fileName = dataTokens[dataTokens.Length - 2];
                long fileSize = long.Parse(dataTokens[dataTokens.Length - 1]);
                if (dataTokens[0] == root &&
                    fileName.EndsWith(extension))
                {
                    files[fileName] = fileSize;
                    match = true;
                }
            }
            files = files
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, long> file in files)
            {
                string name = file.Key;
                long size = file.Value;
                Console.WriteLine($"{name} - {size} KB ");
            }
            if (!match)
            {
                Console.WriteLine("No");
            }
        }
    }
}
