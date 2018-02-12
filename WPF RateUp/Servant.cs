using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RateUp
{
    class Servant
    {
        private Random rnd = Roller.rnd;
        public List<Servants> FiveStars = new List<Servants>{
            Servants.Altria, Servants.Altera, Servants.Waver,
            Servants.Vlad, Servants.Jeanne, Servants.Orion,
            Servants.Drake
        };
        public List<Servants> FourStars = new List<Servants>{
            Servants.Siegfried, Servants.Lancelot, Servants.TamamoCat,
            Servants.Chevalier, Servants.Emiya, Servants.Atalante,
            Servants.Elizabeth, Servants.Marie, Servants.Martha,
            Servants.Stheno, Servants.Carmilla, Servants.Heracles,
            Servants.AnneMary
        };
        public List<Servants> ThreeStars = new List<Servants> {
            Servants.Caesar, Servants.Gilles, Servants.RobinHood,
            Servants.Euryale, Servants.CuChulainn, Servants.CuPrototype,
            Servants.Romulus, Servants.Medusa, Servants.Boudica,
            Servants.Ushiwakamaru, Servants.Alexander, Servants.Medea,
            Servants.Mephistopheles, Servants.JingKe, Servants.LuBu,
            Servants.Darius, Servants.Kiyohime, Servants.David, Servants.Hektor
        }; /*
        public List<Servants> CopperRarity = new List<Servants>{
            Servants.Arash, Servants.Mozart, Servants.Kojirou,
            Servants.MataHari, Servants.Spartacus, Servants.Asterios,
            Servants.Benkei, Servants.Leonidas, Servants.Georgios,
            Servants.EdwardTeach, Servants.Hans, Servants.Shakespeare,
            Servants.Hassan, Servants.CharlesHenriSanson, Servants.PhantomOfTheOpera,
            Servants.Caligula, Servants.EricBloodaxe
        };*/
        public int rarity;
        public String name;
        public Servant(List<Servants> rateUpThreeStars, List<Servants> rateUpFourStars, List<Servants> rateUpFiveStars) 
            : this(rateUpThreeStars, rateUpFourStars, rateUpFiveStars, false)
        {}
        public Servant(List<List<Servants>> rateUp)
            : this(rateUp.ElementAt(0), rateUp.ElementAt(1), rateUp.ElementAt(2), false)
        { }
        public Servant(List<List<Servants>> rateUp, bool guaranteeFourStar)
            : this(rateUp.ElementAt(0), rateUp.ElementAt(1), rateUp.ElementAt(2), guaranteeFourStar)
        { }
        public Servant(List<Servants> rateUpThreeStars, List<Servants> rateUpFourStars, List<Servants> rateUpFiveStars, 
            bool guaranteeFourStar)
        {
            int rateUpCheck = rnd.Next(0, 10);
            if (guaranteeFourStar)
            {
                int roll = rnd.Next(0, 4);
                if (roll == 0) {
                    if (rateUpCheck < 7)
                    {
                        selectServant(rateUpFiveStars.ElementAt(rnd.Next(0, rateUpFiveStars.Count)));
                    } else
                    {
                        selectServant(FiveStars.ElementAt(rnd.Next(0, FiveStars.Count)));
                    }
                    rarity = 5;
                } else
                {
                    if (rateUpCheck < 7)
                    {
                        selectServant(rateUpFourStars.ElementAt(rnd.Next(0, rateUpFourStars.Count)));
                    } else
                    {
                        selectServant(FourStars.ElementAt(rnd.Next(0, FourStars.Count)));
                    }
                    rarity = 4;
                }
            } else
            {
                int roll = rnd.Next(0, 44);
                if (roll == 0)
                {
                    if (rateUpCheck < 7)
                    {
                        selectServant(rateUpFiveStars.ElementAt(rnd.Next(0, rateUpFiveStars.Count)));
                    }
                    else
                    {
                        selectServant(FiveStars.ElementAt(rnd.Next(0, FiveStars.Count)));
                    }
                    rarity = 5;
                }
                else if (roll >= 1 && roll <= 3)
                {
                    if (rateUpCheck < 7)
                    {
                        selectServant(rateUpFourStars.ElementAt(rnd.Next(0, rateUpFourStars.Count)));
                    }
                    else
                    {
                        selectServant(FourStars.ElementAt(rnd.Next(0, FourStars.Count)));
                    }
                    rarity = 4;
                } else
                {
                    if (rateUpCheck < 7)
                    {
                        selectServant(rateUpThreeStars.ElementAt(rnd.Next(0, rateUpThreeStars.Count)));
                    }
                    else
                    {
                        selectServant(ThreeStars.ElementAt(rnd.Next(0, ThreeStars.Count)));
                    }
                    rarity = 3;
                }
            }
        }
        private void selectServant(Servants servant)
        {
            switch (servant) {
                case Servants.Caesar:
                    name = "Gaius Julius Caesar";
                    break;
                case Servants.Gilles:
                    name = "Gilles de Rais";
                    break;
                case Servants.RobinHood:
                    name = "Robin Hood";
                    break;
                case Servants.Euryale:
                    name = "Euryale";
                    break;
                case Servants.CuChulainn:
                    name = "Cu Chulainn";
                    break;
                case Servants.CuPrototype:
                    name = "Cu Chulainn [Prototype]";
                    break;
                case Servants.Romulus:
                    name = "Romulus";
                    break;
                case Servants.Medusa:
                    name = "Medusa";
                    break;
                case Servants.Boudica:
                    name = "Boudica";
                    break;
                case Servants.Ushiwakamaru:
                    name = "Ushiwakamaru";
                    break;
                case Servants.Alexander:
                    name = "Alexander";
                    break;
                case Servants.Medea:
                    name = "Medea";
                    break;
                case Servants.Mephistopheles:
                    name = "Mephistopheles";
                    break;
                case Servants.JingKe:
                    name = "Jing Ke";
                    break;
                case Servants.LuBu:
                    name = "Lu Bu Fengxian";
                    break;
                case Servants.Darius:
                    name = "Darius III";
                    break;
                case Servants.Kiyohime:
                    name = "Kiyohime";
                    break;
                case Servants.David:
                    name = "David";
                    break;
                case Servants.Hektor:
                    name = "Hektor";
                    break;
                case Servants.Siegfried:
                    name = "Siegfried";
                    break;
                case Servants.Chevalier:
                    name = "Chevalier d'Eon";
                    break;
                case Servants.Emiya:
                    name = "Emiya";
                    break;
                case Servants.Atalante:
                    name = "Atalante";
                    break;
                case Servants.Elizabeth:
                    name = "Elizabeth Bathory";
                    break;
                case Servants.Marie:
                    name = "Marie Antoinette";
                    break;
                case Servants.Martha:
                    name = "Martha";
                    break;
                case Servants.Stheno:
                    name = "Stheno";
                    break;
                case Servants.Carmilla:
                    name = "Carmilla";
                    break;
                case Servants.Heracles:
                    name = "Heracles";
                    break;
                case Servants.Lancelot:
                    name = "Lancelot";
                    break;
                case Servants.TamamoCat:
                    name = "Tamamo Cat";
                    break;
                case Servants.AnneMary:
                    name = "Anne Bonny & Mary Read";
                    break;
                case Servants.Altria:
                    name = "Altria Pendragon";
                    break;
                case Servants.Altera:
                    name = "Altera";
                    break;
                case Servants.Waver:
                    name = "Zhuge Liang [El-Melloi II]";
                    break;
                case Servants.Vlad:
                    name = "Vlad III";
                    break;
                case Servants.Jeanne:
                    name = "Jeanne d'Arc";
                    break;
                case Servants.Orion:
                    name = "Orion";
                    break;
                case Servants.TamamoNoMae:
                    name = "Tamamo no Mae";
                    break;
                case Servants.Drake:
                    name = "Francis Drake";
                    break;
                default:
                    name = "Servant not found!";
                    break;
            }
        }
    }

    public enum Servants
    {/*
        Arash, 
        Mozart, 
        Kojirou,
        MataHari,
        Spartacus,
        Asterios,
        Benkei,
        Leonidas,
        Georgios,
        EdwardTeach,
        Hans,
        Shakespeare,
        Hassan,
        CharlesHenriSanson,
        PhantomOfTheOpera,
        Caligula,
        EricBloodaxe,*/
        Caesar,
        Gilles,
        RobinHood,
        Euryale,
        CuChulainn,
        CuPrototype,
        Romulus,
        Medusa,
        Boudica,
        Ushiwakamaru,
        Alexander,
        Medea,
        Mephistopheles,
        JingKe,
        LuBu,
        Darius,
        Kiyohime,
        David,
        Hektor,
        Siegfried,
        Chevalier,
        Emiya,
        Atalante,
        Elizabeth,
        Marie,
        Martha,
        Stheno,
        Carmilla,
        Heracles,
        Lancelot,
        TamamoCat,
        AnneMary,
        Altria,
        Altera,
        Waver,
        Vlad,
        Jeanne,
        Orion,
        TamamoNoMae,
        Drake
    }
}
