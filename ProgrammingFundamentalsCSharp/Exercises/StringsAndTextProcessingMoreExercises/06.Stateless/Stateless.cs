using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int cnt = 0;
            string state = string.Empty;
            string fiction = string.Empty;
            while ((input = Console.ReadLine()) != "collapse")
            {
                if (cnt % 2 == 0)
                {
                    state = input;
                }
                else
                {
                    fiction = input;
                    Collapsing(state, fiction);
                }
                cnt++;
            }
        }
        static void Collapsing(string state, string fiction)
        {
            while (fiction.Length > 0)
            {
                state = state.Replace(fiction, "");
                fiction = fiction.Remove(0, 1);
                if (fiction.Length > 0)
                {
                    fiction = fiction.Remove(fiction.Length - 1);
                }
            }
            Console.WriteLine(state.Length > 0 ? state.Trim(' ') : "(void)");
        }
    }
}
