using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class file
    {
        
        public void save(int krit,bool sk1,bool sk2, bool sk3, double xh1, double xh2, double xgold, double xh4, double xh5, double xdps, double xclickdamage, List<int> skillsd, long clicks, List<long> lvls, long gold, long lvl, long avaliablelvl, long killed)
        {
            StreamWriter writer = new StreamWriter("save.pl,");
            writer.WriteLine(krit);
            writer.WriteLine(sk1);
            writer.WriteLine(sk2);
            writer.WriteLine(sk3);
            writer.WriteLine(xh1);
            writer.WriteLine(xh2);
            writer.WriteLine(xgold);
            writer.WriteLine(xh4);
            writer.WriteLine(xh5);
            writer.WriteLine(xdps);
            writer.WriteLine(xclickdamage);
            for (int i = 0; i < skillsd.Count; i++)
            writer.WriteLine(skillsd[i]);
            writer.WriteLine(clicks);
            for (int i = 0; i < lvls.Count; i++)
                writer.WriteLine(lvls[i]);
            writer.WriteLine(gold);
            writer.WriteLine(lvl);
            writer.WriteLine(avaliablelvl);
            writer.WriteLine(killed);
            DateTime d = DateTime.Now;
            writer.WriteLine(d);
            writer.Close();
        }
        public void loadtext(ref List<string> skillsdes, int j)
        {
            StreamReader reader = new StreamReader("text.W#B");
            for (int i = 0; i < j; i++)
            skillsdes.Add(reader.ReadLine());
        }
        public void open(ref int krit, ref bool sk1, ref bool sk2, ref bool sk3, ref double xh1, ref double xh2, ref double xgold, ref double xh4, ref double xh5, ref double xdps, ref double xclickdamage, ref List<int> skillsd, ref long clicks, ref List<long> lvls, ref long gold, ref long lvl, ref long avaliablelvl, ref long killed, ref DateTime d)
        {
            StreamReader reader = new StreamReader("save.pl,");
            krit = Convert.ToInt32(reader.ReadLine());
            sk1 = Convert.ToBoolean(reader.ReadLine());
            sk2 = Convert.ToBoolean(reader.ReadLine());
            sk3 = Convert.ToBoolean(reader.ReadLine());
            xh1 = Convert.ToInt32(reader.ReadLine());
            xh2 = Convert.ToInt32(reader.ReadLine());
            xgold = Convert.ToInt32(reader.ReadLine());
            xh4 = Convert.ToInt32(reader.ReadLine());
            xh5 = Convert.ToInt32(reader.ReadLine());
            xdps = Convert.ToInt32(reader.ReadLine());
            xclickdamage = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < skillsd.Count; i++)
            skillsd[i] = Convert.ToInt32(reader.ReadLine());
            clicks = Convert.ToInt64(reader.ReadLine());
            for (int i = 0; i < lvls.Count; i++)
            lvls[i] = Convert.ToInt64(reader.ReadLine());
            gold = Convert.ToInt64(reader.ReadLine());
            lvl = Convert.ToInt64(reader.ReadLine());
            avaliablelvl = Convert.ToInt64(reader.ReadLine());
            killed = Convert.ToInt64(reader.ReadLine());
            d = Convert.ToDateTime(reader.ReadLine());
            reader.Close();
        }
    }
}
