using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemDevelop.Model
{
    class Logtext
    {
        public void OutPut()
        {
            StreamWriter sw = File.CreateText("test.txt");
            sw.WriteLine("NEC");
            sw.WriteLine("SONY");
            sw.WriteLine("DELL");
            sw.Close();

            File.AppendAllText("test.txt", "a");

        }
    }
}

