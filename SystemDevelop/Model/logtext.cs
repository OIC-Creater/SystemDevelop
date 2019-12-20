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
        public void OutPut(string log)
        {
            string appendText = DateTime.Now.ToString("yyyy/MM/dd HH:mm") + " INFO: "  + log + Environment.NewLine;
            File.AppendAllText("test.txt", appendText);

          

        }
    }
}

