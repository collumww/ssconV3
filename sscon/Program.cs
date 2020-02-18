using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss {
    class Program {
        static void Main(string[] args) {
            ssEd ed = new ssEd(args, 0);
            ed.ProcessArgs();

            for (;;) {
                string s = Console.ReadLine();
                if (s == null) s = "q";      // on eof (if redirected) need to go through standard exit to save files, etc.
                ed.Do(s);
                }
            }
        }
    }
