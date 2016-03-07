using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        //public struct toolong
        //{
        //    public int num;
        //    public int dec;
        //}
        Classprocedures procedures = new Classprocedures();
        bool showtip = true;
        DateTime d1, d2;
        file fi = new file();
        int krit;
        Boolean sk1, sk2, sk3;
        int xxdps, xxgold, xxclickdamage;
        long skillkd1, skillkd2, skillkd3;
        double xh1, xh2, xgold, xh4, xh5, xdps;
        double xclickdamage;
        List<Button> skills = new List<Button>();
        List<int> skillsd = new List<int>();
        List<long> skillsc = new List<long>();
        List<string> skillsdes = new List<string>();
        bool a = true;
        DateTime time1 = DateTime.Now;
        DateTime time2;
        DateTime time3;
        DateTime time4;
        DateTime skil1, skil2, skil3, skill1, skill2, skill3;
        bool progressmode;
        long clicks;
        long hp, maxhp;
        long clickdamage;
        long dps;
        List<long> h = new List<long>();
        List<long> lvlcost = new List<long>();
        List<long> lvls = new List<long>();
        //toolong tgold;
        long gold;
        long lvl;
        long avaliablelvl;
        long killed;
        double goldpersent;
        Random random = new Random();
        public Form1()
        {            
            progressmode = false;
            InitializeComponent();
            timer1.Enabled = false;
            label6.Text = "Уровень " + lvl.ToString();
            h.Add(new long()); h[0]  = 0; h.Add(new long()); h[1]  = 0; h.Add(new long()); h[2]  = 0; h.Add(new long()); h[3]  = 0; h.Add(new long()); h[4]  = 0; h.Add(new long()); h[5]  = 0;
            lvlcost.Add(0); lvlcost.Add(0); lvlcost.Add(0); lvlcost.Add(0); lvlcost.Add(0); lvlcost.Add(0);
            lvls.Add(0); lvls.Add(0); lvls.Add(0); lvls.Add(0); lvls.Add(0); lvls.Add(0);
            progressBar1.Minimum = 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks ++;
            if (clicks  / 100000000 >= 1)
            {
                clicks  = clicks  / 100000000;
                clicks ++;
            }
            if (random.Next(krit) > 9)
                hp  -= clickdamage  * 15;
            else
                hp  -= clickdamage;
            //if (clicks >= 1000)
            //    MessageBox.Show(clicks.ToString());
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                lvls[0]++;
                //tgold.num -= tlvlcost[0]; 
                //if (tgold.dec = tlvlcost[0].dec)
                //{
                //    tgold.num -= tlvlcost[0].num;
                //    lvls[0]++;
                //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //}
                //if (tgold.dec > tlvlcost[0].dec)
                //{
                //    if (tgold.dec - tlvlcost[0].dec <= 3)
                //    {
                //        if (tlvlcost[0].num >= Math.Pow(10,tgold.dec - tlvlcost[0].dec))
                //        {
                //            tlvlcost[0].num = tlvlcost[0].num / (tgold.dec - tlvlcost[0].dec);
                //            tlvlcost[0].dec += tgold.dec - tlvlcost[0].dec;
                //        }
                //        tgold.num = tlvlcost[0].num;
                //        lvls[0]++;
                //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
                //        { tgold.num = tgold.num * 10; tgold.dec--; }
                //    }
                //    else
                //    {
                //        lvls[0]++;
                //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //    }
                //}
                gold  -= lvlcost[0];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void button4_Click(object sender, EventArgs e)
        {
                lvls[1]++;
                //if (tgold.dec = tlvlcost[1].dec)
                //{
                //    tgold.num -= tlvlcost[1].num;
                //    lvls[1]++;
                //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //}
                //if (tgold.dec > tlvlcost[1].dec)
                //{
                //    if (tgold.dec - tlvlcost[1].dec <= 3)
                //    {
                //        if (tlvlcost[1].num >= Math.Pow(10, tgold.dec - tlvlcost[1].dec))
                //        {
                //            tlvlcost[1].num = tlvlcost[1].num / (tgold.dec - tlvlcost[1].dec);
                //            tlvlcost[1].dec += tgold.dec - tlvlcost[1].dec;
                //        }
                //        tgold.num = tlvlcost[1].num;
                //        lvls[1]++;
                //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
                //        { tgold.num = tgold.num * 10; tgold.dec--; }
                //    }
                //    else
                //    {
                //        lvls[1]++;
                //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
                //    }
                //}
                gold -= lvlcost[1];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lvls[2]++;
            //if (tgold.dec = tlvlcost[2].dec)
            //{
            //    tgold.num -= tlvlcost[2].num;
            //    lvls[2]++;
            //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //}
            //if (tgold.dec > tlvlcost[2].dec)
            //{
            //    if (tgold.dec - tlvlcost[2].dec <= 3)
            //    {
            //        if (tlvlcost[2].num >= Math.Pow(10, tgold.dec - tlvlcost[2].dec))
            //        {
            //            tlvlcost[2].num = tlvlcost[2].num / (tgold.dec - tlvlcost[2].dec);
            //            tlvlcost[2].dec += tgold.dec - tlvlcost[2].dec;
            //        }
            //        tgold.num = tlvlcost[2].num;
            //        lvls[2]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
            //        { tgold.num = tgold.num * 10; tgold.dec--; }
            //    }
            //    else
            //    {
            //        lvls[2]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //    }
            //}
                gold -= lvlcost[2];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lvls[3]++;
            //if (tgold.dec = tlvlcost[3].dec)
            //{
            //    tgold.num -= tlvlcost[3].num;
            //    lvls[3]++;
            //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //}
            //if (tgold.dec > tlvlcost[3].dec)
            //{
            //    if (tgold.dec - tlvlcost[3].dec <= 3)
            //    {
            //        if (tlvlcost[3].num >= Math.Pow(10, tgold.dec - tlvlcost[3].dec))
            //        {
            //            tlvlcost[3].num = tlvlcost[3].num / (tgold.dec - tlvlcost[3].dec);
            //            tlvlcost[3].dec += tgold.dec - tlvlcost[3].dec;
            //        }
            //        tgold.num = tlvlcost[3].num;
            //        lvls[3]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
            //        { tgold.num = tgold.num * 10; tgold.dec--; }
            //    }
            //    else
            //    {
            //        lvls[3]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //    }
            //}
                gold -= lvlcost[3];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lvls[4]++;
            //if (tgold.dec = tlvlcost[4].dec)
            //{
            //    tgold.num -= tlvlcost[4].num;
            //    lvls[4]++;
            //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //}
            //if (tgold.dec > tlvlcost[4].dec)
            //{
            //    if (tgold.dec - tlvlcost[4].dec <= 3)
            //    {
            //        if (tlvlcost[4].num >= Math.Pow(10, tgold.dec - tlvlcost[4].dec))
            //        {
            //            tlvlcost[4].num = tlvlcost[4].num / (tgold.dec - tlvlcost[4].dec);
            //            tlvlcost[4].dec += tgold.dec - tlvlcost[4].dec;
            //        }
            //        tgold.num = tlvlcost[4].num;
            //        lvls[4]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
            //        { tgold.num = tgold.num * 10; tgold.dec--; }
            //    }
            //    else
            //    {
            //        lvls[4]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //    }
            //}
                gold -= lvlcost[4];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lvls[5]++;
            //if (tgold.dec = tlvlcost[5].dec)
            //{
            //    tgold.num -= tlvlcost[5].num;
            //    lvls[5]++;
            //    procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //}
            //if (tgold.dec > tlvlcost[5].dec)
            //{
            //    if (tgold.dec - tlvlcost[5].dec <= 3)
            //    {
            //        if (tlvlcost[5].num >= Math.Pow(10, tgold.dec - tlvlcost[5].dec))
            //        {
            //            tlvlcost[5].num = tlvlcost[5].num / (tgold.dec - tlvlcost[5].dec);
            //            tlvlcost[5].dec += tgold.dec - tlvlcost[5].dec;
            //        }
            //        tgold.num = tlvlcost[5].num;
            //        lvls[5]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //        while ((((double)tgold.num - ((double)tgold.num % 100000)) < 1) && tgold.dec > 0)
            //        { tgold.num = tgold.num * 10; tgold.dec--; }
            //    }
            //    else
            //    {
            //        lvls[5]++;
            //        procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            //    }
            //}
                gold -= lvlcost[5];
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fi.save(krit, sk1, sk2, sk3, xh1, xh2, xgold, xh4, xh5, xdps, xclickdamage, skillsd, clicks, lvls, gold, lvl, avaliablelvl, killed);
            



                skill1 = DateTime.Now;
            skill2 = DateTime.Now;
            skill3 = DateTime.Now;
            skillkd1 = 10 * 60 - (skill1.Ticks - skil1.Ticks) / 10000000;
            skillkd2 = 10 * 60 - (skill2.Ticks - skil2.Ticks) / 10000000;
            skillkd3 = 10 * 60 - (skill3.Ticks - skil3.Ticks) / 10000000;
            if (sk1)
            {
                if (skillkd1 <= 0) button50.Enabled = true; else { button50.Enabled = false; button50.Text = skillkd1.ToString(); }
            }
            else
                button50.Enabled = false;
            if (skillkd1 >= 570) xxclickdamage = 2; else xxclickdamage = 1;
            if (sk2)
            {
            if (skillkd2 <= 0) button51.Enabled = true; else { button51.Enabled = false; button51.Text = skillkd2.ToString(); }
            }
            else
                button51.Enabled = false;
            if (skillkd2 >= 570) xxdps = 4; else xxdps = 1;
            if (sk3)
            {
            if (skillkd3 <= 0) button52.Enabled = true; else { button52.Enabled = false; button52.Text = skillkd3.ToString(); }
            }
            else
                button52.Enabled = false;
            if (skillkd3 >= 570) xxgold = 4; else xxgold = 1;

            //if ((tgold.dec > tlvlcost[0].dec) || (tgold.dec = tlvlcost[0].dec) && (tgold.num > tlvlcost[0].dec))
            if (gold  >= lvlcost[0])
            { button3.Enabled = true; }
            else { button3.Enabled = false; }
            //if ((tgold.dec > tlvlcost[1].dec) || (tgold.dec = tlvlcost[1].dec) && (tgold.num > tlvlcost[1].dec))
            if (gold  >= lvlcost[1])
            { button4.Enabled = true; }
            else { button4.Enabled = false; }
            //if ((tgold.dec > tlvlcost[2].dec) || (tgold.dec = tlvlcost[2].dec) && (tgold.num > tlvlcost[2].dec))
            if (gold  >= lvlcost[2])
            { button5.Enabled = true; }
            else { button5.Enabled = false; }
            //if ((tgold.dec > tlvlcost[3].dec) || (tgold.dec = tlvlcost[3].dec) && (tgold.num > tlvlcost[3].dec))
            if (gold  >= lvlcost[3])
            { button6.Enabled = true; }
            else { button6.Enabled = false; }
            //if ((tgold.dec > tlvlcost[4].dec) || (tgold.dec = tlvlcost[4].dec) && (tgold.num > tlvlcost[4].dec))
            if (gold  >= lvlcost[4])
            { button7.Enabled = true; }
            else { button7.Enabled = false; }
            //if ((tgold.dec > tlvlcost[5].dec) || (tgold.dec = tlvlcost[5].dec) && (tgold.num > tlvlcost[5].dec))
            if (gold  >= lvlcost[5])
            { button8.Enabled = true; }
            else { button8.Enabled = false; }

            for (int i = 0; i < lvlcost.Count; i++)
            {
                lvlcost[i] = Convert.ToInt64(2 * Math.Pow(100, i) * Math.Pow(1.1, lvls[i]));
            }
            label7.Text = "Стоимость " + lvlcost[0] +" Уровень " + lvls[0] + " Урон " + ((double)h[0] *xclickdamage).ToString();
            label8.Text = "Стоимость " + lvlcost[1] + " Уровень " + lvls[1] + " Урон " + h[1].ToString();
            label9.Text = "Стоимость " + lvlcost[2] + " Уровень " + lvls[2] + " Урон " + h[2].ToString();
            label10.Text = "Стоимость " + lvlcost[3] + " Уровень " + lvls[3] + " Урон " + h[3].ToString();
            label11.Text = "Стоимость " + lvlcost[4] + " Уровень " + lvls[4] + " Урон " + h[4].ToString();
            label12.Text = "Стоимость " + lvlcost[5] + " Уровень " + lvls[5] + " Урон " + h[5].ToString();
                time2 = DateTime.Now;
                if (time2.Ticks - time1.Ticks > 2500000)
                {
                    hp  -= Convert.ToInt64((double)dps  / 4);
                    if (hp > 0)
                    {
                        label1.Text = hp.ToString();
                        label1.Left = progressBar1.Left + (progressBar1.Width - label1.Width) / 2;
                    }
                    time1 = DateTime.Now;
                    time2 = DateTime.Now;
                }


            
            if (a)
            if (hp  <= 0)
            {
                time3 = DateTime.Now;
                //////////////if (tgold.dec = tmaxhp.dec)
                //////////////    tgold.num += xxgold * xgold * Math.Round(goldpersent * (double)tmaxhp.num);
                //////////////else
                //////////////    if (tgold.dec < tmaxhp.dec)
                //////////////    {
                //////////////        if (tgold.num > Math.Pow(10, tmaxhp.dec - tgold.dec))
                //////////////        {
                //////////////            tgold.num = tgold.num / Math.Pow(10, tmaxhp.dec - tgold.dec);
                //////////////            tgold.dec += tmaxhp.dec - tgold.dec;
                //////////////            tgold.num += xxgold * xgold * Math.Round(goldpersent * (double)tmaxhp.num);
                //////////////        }
                //////////////        else
                //////////////        {
                //////////////            tgold.num = xxgold * xgold * Math.Round(goldpersent * (double)tmaxhp.num);
                //////////////            tgold.dec = tmaxhp.dec;
                //////////////        }
                //////////////    }
                //////////////    else
                //////////////        if (tgold.dec > tmaxhp.dec)
                //////////////        {
                //////////////            if (tmaxhp.num > Math.Pow(10, tgold.dec - tmaxhp.dec))
                //////////////            {
                //////////////                tmaxhp.num = tgold.num / Math.Pow(10, tgold.dec - tmaxhp.dec);
                //////////////                tmaxhp.dec += tgold.dec - tmaxhp.dec;
                //////////////                tmaxhp.num += xxgold * xgold * Math.Round(goldpersent * (double)tmaxhp.num);
                //////////////            }
                //////////////            else
                //////////////            {
                //////////////                tgold.num = xxgold * xgold * Math.Round(goldpersent * (double)tmaxhp.num);
                //////////////                tgold.dec = tmaxhp.dec;
                //////////////            }
                //////////////        }

                gold  += Convert.ToInt64(xxgold * xgold * Math.Round(goldpersent * (double)maxhp ));
                killed++;
                if (lvl == avaliablelvl)
                    if (killed < 10)
                        label5.Text = killed + ":10";
                    else
                    {
                        avaliablelvl++;
                        label5.Text = "";
                        killed = 0;
                    }

                label1.Text = "Мертв";
                label1.Left = progressBar1.Left + (progressBar1.Width - label1.Width) / 2;
                a = false;
            }
            if (!a)
            {
                time4 = DateTime.Now;
                if (time4.Ticks - time3.Ticks > 5000000)
                {

                    hp = Convert.ToInt32(100 * (Math.Pow(1.2, lvl))) + random.Next(Convert.ToInt32(100 * (Math.Pow(1.2, lvl - 1) - 0.9)));

                    label1.Text = hp.ToString();
                    label1.Left = progressBar1.Left + (progressBar1.Width - label1.Width) / 2;
                    maxhp = hp;
                    progressBar1.Maximum = Convert.ToInt32(maxhp);
                    a = true;
                }
            }
            if (hp > 1)
            {
                progressBar1.Value = Convert.ToInt32(hp);
            }
            else
                progressBar1.Value = 1;

            label2.Text = "Золото " + gold.ToString();
            if (lvls[0] != 0)
            {
                h[0]  = 0;
                for (int i = 1; i < lvls[0] + 1; i++)
                    h[0]  += Convert.ToInt64(Math.Pow(1.01, i));
            }
            if (lvls[1] != 0)
            {
                h[1]  = 0;
                for (int i = 1; i < lvls[1] + 1; i++)
                    h[1]  += 16 * Convert.ToInt64(Math.Pow(1.03, i) * xh1);
            }
            if (lvls[2] != 0)
            {
                h[2]  = 0;
                for (int i = 1; i < lvls[2] + 1; i++)
                    h[2]  += 4096 * Convert.ToInt64(Math.Pow(1.03, i) * xh2);
            }
            if (lvls[3] != 0)
            {
                h[3]  = 0;
                for (int i = 1; i < lvls[3] + 1; i++)
                    h[3]  += 16777216 * Convert.ToInt64(Math.Pow(1.03, i));
            }
            if (lvls[4] != 0)
            {
                h[4]  = 0;
                for (int i = 1; i < lvls[4] + 1; i++)
                    h[4]  += 68719476736 * Convert.ToInt64(Math.Pow(1.03, i) * xh4);
            }
            if (lvls[5] != 0)
            {
                h[5]  = 0;
                for (int i = 1; i < lvls[5] + 1; i++)
                    h[5]  += 281474976710656 * Convert.ToInt64(Math.Pow(1.03, i) * xh5);
            }
            goldpersent = 0.3;
            dps  = Convert.ToInt64((h[1]  + h[2]  + h[3]  + h[4]  + h[5] ) * xdps * xxdps);
            clickdamage  = Convert.ToInt64((h[0]  + Convert.ToInt64(Math.Round(0.1 * (double)dps ))) * xclickdamage * xxclickdamage);
            label3.Text = "Периодический урон " + dps.ToString();
            label4.Text = "Урон с клика " + clickdamage.ToString();
            if (progressmode)
            {
                if (lvl < avaliablelvl)
                {
                    lvl++;
                    label6.Text = "Уровень " + lvl.ToString();
                    if (lvl == avaliablelvl)
                    {
                        killed = 0;
                        label5.Text = killed + ":10";
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lvl > 1)
            {
                lvl--;
                label6.Text = "Уровень " + lvl.ToString();
                killed = 0;
                label5.Text = "";
                a = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lvl < avaliablelvl)
            {
                lvl++;
                label6.Text = "Уровень " + lvl.ToString();
                if (lvl == avaliablelvl)
                {
                    killed = 0;
                    label5.Text = killed + ":10";
                }
                a = false;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            progressmode = !progressmode;
            if (progressmode)
            { button11.Text = "Режим прохождения"; }//картинка кнопки
            else
            { button11.Text = "Режим фарма"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            skills.Add(button2);
            skills.Add(button12);skills.Add(button13);skills.Add(button16);
            skills.Add(button15);skills.Add(button14);skills.Add(button19);
            skills.Add(button18);skills.Add(button17);skills.Add(button22);
            skills.Add(button26);skills.Add(button25);skills.Add(button24);
            skills.Add(button23);skills.Add(button21);skills.Add(button20);
            skills.Add(button32);skills.Add(button31);skills.Add(button30);
            skills.Add(button29);skills.Add(button28);skills.Add(button27);
            skills.Add(button38);skills.Add(button37);skills.Add(button36);
            skills.Add(button35);skills.Add(button34);skills.Add(button43);
            skills.Add(button42);skills.Add(button41);skills.Add(button40);
            skills.Add(button39);skills.Add(button33);skills.Add(button49);
            skills.Add(button48);skills.Add(button47);skills.Add(button46);
            skills.Add(button45);skills.Add(button44);
            fi.loadtext(ref skillsdes, skills.Count);
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 100)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 125));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 150)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 175));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 200)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 0) * Math.Pow(1.1, 250));
            
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 100)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 1) * Math.Pow(1.1, 125));

            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 100)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 2) * Math.Pow(1.1, 125));

            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 3) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 3) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 3) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 3) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 3) * Math.Pow(1.1, 100));
            
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 100)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 4) * Math.Pow(1.1, 125));

            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 10)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 25));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 50)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 75));
            skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 100)); skillsc.Add(new long()); skillsc[skillsc.Count-1]  = 5*Convert.ToInt64(2 * Math.Pow(100, 5) * Math.Pow(1.1, 125));
            for (int i = 0; i < skills.Count; i++)
            { skillsd.Add(-1); skills[i].Enabled = false; }
            for (int i = 1; i < skillsc.Count; i++)
                if (skillsc[i]  / 100000000 >= 1)
                {
                    skillsc[i]  = skillsc[i]  / 100000000;
                    skillsc[i] ++;
                }
            fi.open(ref krit, ref sk1, ref sk2, ref sk3, ref xh1, ref xh2, ref xgold, ref xh4, ref xh5, ref xdps, ref xclickdamage, ref skillsd, ref clicks, ref lvls, ref gold, ref lvl, ref avaliablelvl, ref killed, ref d1);
            d2 = DateTime.Now;
                if (lvls[1] != 0)
                {
                    h[1] = 0;
                    for (int i = 1; i < lvls[1] + 1; i++)
                        h[1] += 16 * Convert.ToInt64(Math.Pow(1.03, i) * xh1);
                }
                if (lvls[2] != 0)
                {
                    h[2] = 0;
                    for (int i = 1; i < lvls[2] + 1; i++)
                        h[2] += 4096 * Convert.ToInt64(Math.Pow(1.03, i) * xh2);
                }
                if (lvls[3] != 0)
                {
                    h[3] = 0;
                    for (int i = 1; i < lvls[3] + 1; i++)
                        h[3] += 16777216 * Convert.ToInt64(Math.Pow(1.03, i));
                }
                if (lvls[4] != 0)
                {
                    h[4] = 0;
                    for (int i = 1; i < lvls[4] + 1; i++)
                        h[4] += 68719476736 * Convert.ToInt64(Math.Pow(1.03, i) * xh4);
                }
                if (lvls[5] != 0)
                {
                    h[5] = 0;
                    for (int i = 1; i < lvls[5] + 1; i++)
                        h[5] += 281474976710656 * Convert.ToInt64(Math.Pow(1.03, i) * xh5);
                }
                dps = Convert.ToInt64((h[1] + h[2] + h[3] + h[4] + h[5]) * xdps);
                hp = Convert.ToInt32(100 * (Math.Pow(1.2, lvl))) + random.Next(Convert.ToInt32(100 * (Math.Pow(1.2, lvl - 1) - 0.9)));

                if ((lvls[1] + lvls[2] + lvls[3] + lvls[4] + lvls[5]) > 0)
                {
                    long apo = 1;
                    long hhp = hp;
                    while (dps < hhp)
                    {
                        apo++;
                        hhp -= dps;
                    }

                    gold += (((d2.Ticks - d1.Ticks) / 10000000) * Convert.ToInt64(xgold * Math.Round(0.3 * (double)hp))) / apo;
                }

                progressBar1.Maximum = Convert.ToInt32(hp);
                label6.Text = "Уровень " + lvl.ToString();
                killed = 0;
                if (lvl == avaliablelvl)
                    label5.Text = "0:10";
                maxhp = hp;
                procedures.SkillsButtons(ref skillsd, lvls, ref skills);
            timer1.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[1] )
            {
            gold  -= skillsc[1] ;
            skillsd[1] = 1;
            button12.Enabled = false;
            xclickdamage = xclickdamage * 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[0] )
            {
                gold  -= skillsc[0] ;
                skillsd[0] = 1;
                button2.Enabled = false;
                xclickdamage = xclickdamage * 2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[2] )
            {
                gold  -= skillsc[2] ;
            skillsd[2] = 1;
            button13.Enabled = false;
            xclickdamage = xclickdamage * 2;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[3] )
            {
            gold  -= skillsc[3] ;
            skillsd[3] = 1;
            button16.Enabled = false;
            xclickdamage = xclickdamage * 2.5;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[4] )
            {
            gold  -= skillsc[4] ;
            skillsd[4] = 1;
            button15.Enabled = false;
            xclickdamage = xclickdamage * 2.5;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[5] )
            {
            gold  -= skillsc[5] ;
            skillsd[5] = 1;
            button14.Enabled = false;
            xclickdamage = xclickdamage * 2.5;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[6] )
            {
            gold  -= skillsc[6] ;
            skillsd[6] = 1;
            button19.Enabled = false;
            xclickdamage = xclickdamage * 2.5;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[7] )
            {
            gold  -= skillsc[7] ;
            skillsd[7] = 1;
            button18.Enabled = false;
            xclickdamage = xclickdamage * 3;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[8] )
            {
            gold  -= skillsc[8] ;
            skillsd[8] = 1;
            button17.Enabled = false;
            xclickdamage = xclickdamage * 3;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[9] )
            {
            gold  -= skillsc[9] ;
            skillsd[9] = 1;
            button22.Enabled = false;
            xclickdamage = xclickdamage * 3.5;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[10] )
            {
            gold  -= skillsc[10] ;
            skillsd[10] = 1;
            button26.Enabled = false;
            xh1 = xh1 * 1.5;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[11] )
            {
            gold  -= skillsc[11] ;
            skillsd[11] = 1;
            button25.Enabled = false;
            xh1 = xh1 * 2;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[12] )
            {
            gold  -= skillsc[12] ;
            skillsd[12] = 1;
            button24.Enabled = false;
            xh1 = xh1 * 2;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[13] )
            {
            gold  -= skillsc[13] ;
            skillsd[13] = 1;
            button23.Enabled = false;
            xh1 = xh1 * 2.5;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[14] )
            {
                gold  -= skillsc[14] ;
            skillsd[14] = 1;
            button21.Enabled = false;
            xclickdamage += 1.2 * xclickdamage;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[15] )
            {
                gold  -= skillsc[15] ;
            skillsd[15] = 1;
            button20.Enabled = false;
            sk1 = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[16] )
            {
                gold  -= skillsc[16] ;
            skillsd[16] = 1;
            button32.Enabled = false;
            xh2 = xh2 * 1.5;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[17] )
            {
                gold  -= skillsc[17] ;
            skillsd[17] = 1;
            button31.Enabled = false;
            xh2 = xh2 * 2;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[18] )
            {
                gold  -= skillsc[18] ;
            skillsd[18] = 1;
            button30.Enabled = false;
            xh2 = xh2 * 2.5;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[19] )
            {
                gold  -= skillsc[19] ;
            skillsd[19] = 1;
            button29.Enabled = false;
            xh2 = xh2 * 2.5;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[20] )
            {
                gold  -= skillsc[20] ;
            skillsd[20] = 1;
            button28.Enabled = false;
            xdps = xdps * 1.3;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[21] )
            {
                gold  -= skillsc[21] ;
            skillsd[21] = 1;
            button27.Enabled = false;
            sk2 = true;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[22] )
            {
                gold  -= skillsc[22] ;
            skillsd[22] = 1;
            button38.Enabled = false;
            xgold = xgold * 1.5;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[23] )
            {
                gold  -= skillsc[23] ;
            skillsd[23] = 1;
            button37.Enabled = false;
            xgold = xgold * 1.5;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[24] )
            {
                gold  -= skillsc[24] ;
            skillsd[24] = 1;
            button36.Enabled = false;
            xgold = xgold * 2;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[25] )
            {
                gold  -= skillsc[25] ;
            skillsd[25] = 1;
            button35.Enabled = false;
            xgold = xgold * 2.5;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[26] )
            {
            gold  -= skillsc[26] ;
            skillsd[26] = 1;
            button34.Enabled = false;
            sk3 = true;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[27] )
            {
            gold  -= skillsc[27] ;
            skillsd[27] = 1;
            button43.Enabled = false;
            xh4 = xh4 * 1.5;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[28] )
            {
            gold  -= skillsc[28] ;
            skillsd[28] = 1;
            button42.Enabled = false;
            xh4 = xh4 * 1.5;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[29] )
            {
            gold  -= skillsc[29] ;
            skillsd[29] = 1;
            button41.Enabled = false;
            xh4 = xh4 * 2;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[30] )
            {
            gold  -= skillsc[30] ;
            skillsd[30] = 1;
            button40.Enabled = false;
            xh4 = xh4 * 2.5;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[31] )
            {
            gold  -= skillsc[31] ;
            skillsd[31] = 1;
            button39.Enabled = false;
            xh4 = xh4 * 3;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[32] )
            {
            gold  -= skillsc[32] ;
            skillsd[32] = 1;
            button33.Enabled = false;
            xh4 = xh4 * 3.5;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[33] )
            {
            gold  -= skillsc[33] ;
            skillsd[33] = 1;
            button49.Enabled = false;
            xh5 = xh5 * 2;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[34] )
            {
            gold  -= skillsc[34] ;
            skillsd[34] = 1;
            button48.Enabled = false;
            xh5 = xh5 * 2;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[35] )
            {
            gold  -= skillsc[35] ;
            skillsd[35] = 1;
            button47.Enabled = false;
            xh5 = xh5 * 3;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[36] )
            {
            gold  -= skillsc[36] ;
            skillsd[36] = 1;
            button46.Enabled = false;
            xh5 = xh5 * 4;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[37] )
            {
                gold  -= skillsc[37] ;
            skillsd[37] = 1;
            button45.Enabled = false;
            xh5 = xh5 * 5;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (gold  >= skillsc[38] )
            {
                gold  -= skillsc[38] ;
            skillsd[38] = 1;
            button44.Enabled = false;
            krit = 10;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            skil3 = DateTime.Now;
            skill3 = DateTime.Now;

        }

        private void button51_Click(object sender, EventArgs e)
        {
            skil2 = DateTime.Now;
            skill2 = DateTime.Now;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            skil1 = DateTime.Now;
            skill1 = DateTime.Now;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Classnewgame newgame = new Classnewgame();
            timer1.Enabled = false;
            newgame.NewGame(skillsd.Count, lvls.Count);
            MessageBox.Show("Для сброса необходимо перезапустить игру.");
            Close();
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!toolTip1.)
            if (showtip)
            {
                toolTip1.Show("   Режим прохождения - автоматическое" + Environment.NewLine + "перехождение на максимально доступный уровень." + Environment.NewLine + "   Режим фарма - получение золота с текущего" + Environment.NewLine + "уровня, не переходя на большие.", button11, 45, -65);
                showtip = false;
            }
        }

        private void button53_MouseMove(object sender, MouseEventArgs e)
        {
            if (showtip)
            {
                toolTip1.Show("Начать игру заново. Сброс уровня, золота(до 100)" + Environment.NewLine + "и прокачанных способностей.", button53, 70, -25);
                showtip = false;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!showtip)
            {
                toolTip1.RemoveAll();
                showtip = true;
            }
        }

        private void Skills_MouseMove(object sender, MouseEventArgs e)
        {
            if (showtip)
            {
                for (int i = 0; i < skills.Count; i++)
                {
                    if (skills[i] == sender)
                        toolTip1.Show(skillsdes[i] + Environment.NewLine + "Стоимость:" + skillsc[i] + Environment.NewLine, (IWin32Window)sender, 15, -35);
                }
                showtip = false;
            }
        }
    }
}
