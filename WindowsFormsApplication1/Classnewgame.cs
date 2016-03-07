using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class Classnewgame
    {
        public void NewGame(int s, int l)
        {
            //FileInfo f = new FileInfo("save.pl,");
            StreamWriter writer = new StreamWriter("save.pl,");
            writer.WriteLine(1);
            writer.WriteLine("False");
            writer.WriteLine("False");
            writer.WriteLine("False");
            writer.WriteLine(1);
            writer.WriteLine(2);
            writer.WriteLine(1);
            writer.WriteLine(1);
            writer.WriteLine(1);
            writer.WriteLine(1);
            writer.WriteLine(1);
            for (int i = 0; i < s; i++)
                writer.WriteLine(-1);
            writer.WriteLine(0);
            for (int i = 0; i < l; i++)
                writer.WriteLine(0);
            writer.WriteLine(100);
            writer.WriteLine(1);
            writer.WriteLine(1);
            writer.WriteLine(0);
            DateTime d = DateTime.Now;
            writer.WriteLine(d);
            writer.Close();
        }
    }
}
