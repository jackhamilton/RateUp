using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RateUp
{
    class Roller
    {
        public int fiveStarServants = 0;
        public int fourStarServants = 0;
        public int fiveStarCEs = 0;
        public int fourStarCEs = 0;
        public static Random rnd = MainWindow.randomGenerator;
        List<List<Servants>> currentRateUpServants = new List<List<Servants>>
        {
            new List<Servants>{Servants.Mephistopheles, Servants.Darius},
            new List<Servants>{Servants.Carmilla, Servants.TamamoCat},
            new List<Servants>{Servants.TamamoNoMae}
        };
        List<List<CraftEssences>> currentRateUpCraftEssences = new List<List<CraftEssences>>
        {
            new List<CraftEssences>{CraftEssences.JackOLantern},
            new List<CraftEssences>{CraftEssences.HalloweenArrangement},
            new List<CraftEssences>{CraftEssences.LittleHalloweenDevil}
        };
        public String roll()
        {
            if (rnd.Next(0, 100) < 44)
            {
                Servant s = new Servant(currentRateUpServants);
                if (s.rarity == 4)
                    fourStarServants++;
                if (s.rarity == 5)
                    fiveStarServants++;
                return s.name;
            } else
            {
                CraftEssence c = new CraftEssence(currentRateUpCraftEssences);
                if (c.rarity == 4)
                    fourStarCEs++;
                if (c.rarity == 5)
                    fiveStarCEs++;
                return c.name;
            }
        }

        public List<String> tenRoll()
        {
            List<String> rolled = new List<String>();
            int servants = 0;
            int golds = 0;
            while(rolled.Count < 9)
            {
                if (rnd.Next(0, 100) < 44)
                {
                    Servant s = new Servant(currentRateUpServants);
                    rolled.Add(s.name);
                    servants++;
                    if (s.rarity >= 4)
                    {
                        golds++;
                    }
                    if (s.rarity == 4)
                        fourStarServants++;
                    if (s.rarity == 5)
                        fiveStarServants++;
                }
                else
                {
                    CraftEssence c = new CraftEssence(currentRateUpCraftEssences);
                    rolled.Add(c.name);
                    if (c.rarity >= 4)
                    {
                        golds++;
                    }
                    if (c.rarity == 4)
                        fourStarCEs++;
                    if (c.rarity == 5)
                        fiveStarCEs++;
                }
            }
            //before the last roll, check if any servants have been rolled
            if (servants == 0)
            {
                Servant s = new Servant(currentRateUpServants);
                rolled.Add(s.name);
                servants++;
                if (s.rarity >= 4)
                {
                    golds++;
                }
                if (s.rarity == 4)
                    fourStarServants++;
                if (s.rarity == 5)
                    fiveStarServants++;
            } else
            {
                if (rnd.Next(0, 100) < 44)
                {
                    Servant s = new Servant(currentRateUpServants);
                    rolled.Add(s.name);
                    servants++;
                    if (s.rarity >= 4)
                    {
                        golds++;
                    }
                    if (s.rarity == 4)
                        fourStarServants++;
                    if (s.rarity == 5)
                        fiveStarServants++;
                }
                else
                {
                    CraftEssence c = new CraftEssence(currentRateUpCraftEssences);
                    rolled.Add(c.name);
                    if (c.rarity >= 4)
                    {
                        golds++;
                    }
                    if (c.rarity == 4)
                        fourStarCEs++;
                    if (c.rarity == 5)
                        fiveStarCEs++;
                }
            }
            //Now, check if there are any gold cards. If not, roll one.
            if (golds == 0)
            {
                rolled.RemoveAt(0);
                if (rnd.Next(0, 20) < 4)
                {
                    Servant s = new Servant(currentRateUpServants, true);
                    rolled.Add(s.name);
                    servants++;
                    golds++;
                    if (s.rarity == 4)
                        fourStarServants++;
                    if (s.rarity == 5)
                        fiveStarServants++;
                }
                else
                {
                    CraftEssence c = new CraftEssence(currentRateUpCraftEssences, true);
                    rolled.Add(c.name);
                    golds++;
                    if (c.rarity == 4)
                        fourStarCEs++;
                    if (c.rarity == 5)
                        fiveStarCEs++;
                }
            }
            return rolled;
        }

    }
}
