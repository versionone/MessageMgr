using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
//Usage: msgdel -[l
// Switches:    -l - List contents
//              -d - delete single message
//              -r - delete range   
namespace CmdlineTools
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Number of command line parameters = {0}", args.Length);

            foreach (string s in args)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
