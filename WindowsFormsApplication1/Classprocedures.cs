using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Classprocedures
    {
        public void SkillsButtons(ref List<int> skillsd, List<long> lvls, ref List<Button> skills)
        {
        if (lvls[0] >= 9)
        {
            if (skillsd[0] == -1)
                skillsd[0] = 0;
            if (lvls[0] >= 24)
            {
                if (skillsd[1] == -1)
                    skillsd[1] = 0;
                if (lvls[0] >= 49)
                {
                    if (skillsd[2] == -1)
                        skillsd[2] = 0;
                    if (lvls[0] >= 74)
                    {
                        if (skillsd[3] == -1)
                            skillsd[3] = 0;
                        if (lvls[0] >= 99)
                        {
                            if (skillsd[4] == -1)
                                skillsd[4] = 0;
                            if (lvls[0] >= 124)
                            {
                                if (skillsd[5] == -1)
                                    skillsd[5] = 0;
                                if (lvls[0] >= 149)
                                {
                                    if (skillsd[6] == -1)
                                        skillsd[6] = 0;
                                    if (lvls[0] >= 174)
                                    {
                                        if (skillsd[7] == -1)
                                            skillsd[7] = 0;
                                        if (lvls[0] >= 199)
                                        {
                                            if (skillsd[8] == -1)
                                                skillsd[8] = 0;
                                            if (lvls[0] >= 249)
                                            {
                                                if (skillsd[9] == -1)
                                                    skillsd[9] = 0;

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (lvls[1] >= 9)
        {
            if (skillsd[10] == -1)
                skillsd[10] = 0;
            if (lvls[1] >= 24)
            {
                if (skillsd[11] == -1)
                    skillsd[11] = 0;
                if (lvls[1] >= 49)
                {
                    if (skillsd[12] == -1)
                        skillsd[12] = 0;
                    if (lvls[1] >= 74)
                    {
                        if (skillsd[13] == -1)
                            skillsd[13] = 0;
                        if (lvls[1] >= 99)
                        {
                            if (skillsd[14] == -1)
                                skillsd[14] = 0;
                            if (lvls[1] >= 124)
                            {
                                if (skillsd[15] == -1)
                                    skillsd[15] = 0;

                            }
                        }
                    }
                }
            }
        }
        if (lvls[2] >= 9)
        {
            if (skillsd[16] == -1)
                skillsd[16] = 0;
            if (lvls[2] >= 24)
            {
                if (skillsd[17] == -1)
                    skillsd[17] = 0;
                if (lvls[2] >= 49)
                {
                    if (skillsd[18] == -1)
                        skillsd[18] = 0;
                    if (lvls[2] >= 74)
                    {
                        if (skillsd[19] == -1)
                            skillsd[19] = 0;
                        if (lvls[2] >= 99)
                        {
                            if (skillsd[20] == -1)
                                skillsd[20] = 0;
                            if (lvls[2] >= 124)
                            {
                                if (skillsd[21] == -1)
                                    skillsd[21] = 0;

                            }
                        }
                    }
                }
            }
        }
        if (lvls[3] >= 9)
        {
            if (skillsd[22] == -1)
                skillsd[22] = 0;
            if (lvls[3] >= 24)
            {
                if (skillsd[23] == -1)
                    skillsd[23] = 0;
                if (lvls[3] >= 49)
                {
                    if (skillsd[24] == -1)
                        skillsd[24] = 0;
                    if (lvls[3] >= 74)
                    {
                        if (skillsd[25] == -1)
                            skillsd[25] = 0;
                        if (lvls[3] >= 99)
                        {
                            if (skillsd[26] == -1)
                                skillsd[26] = 0;
                        }
                    }
                }
            }
        }
        if (lvls[4] >= 9)
        {
            if (skillsd[27] == -1)
                skillsd[27] = 0;
            if (lvls[4] >= 24)
            {
                if (skillsd[28] == -1)
                    skillsd[28] = 0;
                if (lvls[4] >= 49)
                {
                    if (skillsd[29] == -1)
                        skillsd[29] = 0;
                    if (lvls[4] >= 74)
                    {
                        if (skillsd[30] == -1)
                            skillsd[30] = 0;
                        if (lvls[4] >= 99)
                        {
                            if (skillsd[31] == -1)
                                skillsd[31] = 0;
                            if (lvls[4] >= 124)
                            {
                                if (skillsd[32] == -1)
                                    skillsd[32] = 0;

                            }
                        }
                    }
                }
            }
        }
        if (lvls[5] >= 9)
        {
            if (skillsd[33] == -1)
                skillsd[33] = 0;
            if (lvls[5] >= 24)
            {
                if (skillsd[34] == -1)
                    skillsd[34] = 0;
                if (lvls[5] >= 49)
                {
                    if (skillsd[35] == -1)
                        skillsd[35] = 0;
                    if (lvls[5] >= 74)
                    {
                        if (skillsd[36] == -1)
                            skillsd[36] = 0;
                        if (lvls[5] >= 99)
                        {
                            if (skillsd[37] == -1)
                                skillsd[37] = 0;
                            if (lvls[5] >= 124)
                            {
                                if (skillsd[38] == -1)
                                    skillsd[38] = 0;

                            }
                        }
                    }
                }
            }
        }



        for (int i = 0; i < skills.Count; i++)
        {
            if (skillsd[i] == 0)
                skills[i].Enabled = true;
        }


        }
    }
}
