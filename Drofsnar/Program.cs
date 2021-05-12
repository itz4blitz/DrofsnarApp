using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramUI drofsnarGame = new ProgramUI();
            drofsnarGame.Run();
            Console.ReadLine();
        }
    }
}
