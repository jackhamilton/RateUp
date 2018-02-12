using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_RateUp
{
    class CraftEssence
    {
        private Random rnd = Roller.rnd;
        public List<CraftEssences> FiveStars = new List<CraftEssences>{
            CraftEssences.FormalCraft,
            CraftEssences.ImaginaryAround,
            CraftEssences.LimitedZeroOver,
            CraftEssences.Kaleidoscope,
            CraftEssences.HeavensFeel,
            CraftEssences.PrismaCosmos,
            CraftEssences.TheBlackGrail,
            CraftEssences.VictorOfTheMoon,
            CraftEssences.AnotherEnding
        };
        public List<CraftEssences> FourStars = new List<CraftEssences>{
            CraftEssences.IronWilledTraining,
            CraftEssences.PrimevalCurse,
            CraftEssences.Projection,
            CraftEssences.Gandr,
            CraftEssences.VerdantSoundOfDestruction,
            CraftEssences.GemMagecraftAntumbra,
            CraftEssences.BeElegant,
            CraftEssences.ImaginaryElement,
            CraftEssences.DivineBanquet,
            CraftEssences.AngelsSong,
            CraftEssences.SealDesignationEnforcer,
            CraftEssences.HolyShroudOfMagdalene,
            CraftEssences.MoonyJewel,
            CraftEssences.WithOneStrike,
            CraftEssences.CodeCast
        };
        public List<CraftEssences> ThreeStars = new List<CraftEssences> {
            CraftEssences.AzothBlade,
            CraftEssences.FalseAttendantsWritings,
            CraftEssences.AzureBlackKeys,
            CraftEssences.VerdantBlackKeys,
            CraftEssences.CrimsonBlackKeys,
            CraftEssences.RinsPendant,
            CraftEssences.SpellTome,
            CraftEssences.DragonsMeridian,
            CraftEssences.SorceryOre,
            CraftEssences.PartedSea,
            CraftEssences.MooncellAutomaton,
            CraftEssences.Runestone,
            CraftEssences.JackOLantern,
            CraftEssences.AnchorsAweigh,
            CraftEssences.Dragonkin
        };
        public int rarity;
        public String name;
        public CraftEssence(List<CraftEssences> rateUpThreeStars, List<CraftEssences> rateUpFourStars, List<CraftEssences> rateUpFiveStars)
            : this(rateUpThreeStars, rateUpFourStars, rateUpFiveStars, false)
        { }
        public CraftEssence(List<List<CraftEssences>> rateUp)
            : this(rateUp.ElementAt(0), rateUp.ElementAt(1), rateUp.ElementAt(2), false)
        { }
        public CraftEssence(List<List<CraftEssences>> rateUp, bool guaranteeFourStar)
            : this(rateUp.ElementAt(0), rateUp.ElementAt(1), rateUp.ElementAt(2), true)
        { }
        public CraftEssence(List<CraftEssences> rateUpThreeStars, List<CraftEssences> rateUpFourStars, List<CraftEssences> rateUpFiveStars,
            bool guaranteeFourStar)
        {
            int rateUpCheck = rnd.Next(0, 10);
            if (guaranteeFourStar)
            {
                int roll = rnd.Next(0, 16);
                if (roll < 4)
                {
                    if (rateUpCheck < 5 && rateUpFiveStars.Count != 0)
                    {
                        selectCraftEssence(rateUpFiveStars.ElementAt(rnd.Next(0, rateUpFiveStars.Count)));
                    }
                    else
                    {
                        selectCraftEssence(FiveStars.ElementAt(rnd.Next(0, FiveStars.Count)));
                    }
                    rarity = 5;
                }
                else
                {
                    if (rateUpCheck < 5 && rateUpFourStars.Count != 0)
                    {
                        selectCraftEssence(rateUpFourStars.ElementAt(rnd.Next(0, rateUpFourStars.Count)));
                    }
                    else
                    {
                        selectCraftEssence(FourStars.ElementAt(rnd.Next(0, FourStars.Count)));
                    }
                    rarity = 4;
                }
            }
            else
            {
                int roll = rnd.Next(0, 56);
                if (roll < 4)
                {
                    if (rateUpCheck < 5 && rateUpFiveStars.Count != 0)
                    {
                        selectCraftEssence(rateUpFiveStars.ElementAt(rnd.Next(0, rateUpFiveStars.Count)));
                    }
                    else
                    {
                        selectCraftEssence(FiveStars.ElementAt(rnd.Next(0, FiveStars.Count)));
                    }
                    rarity = 5;
                }
                else if (roll >= 4 && roll <= 15)
                {
                    if (rateUpCheck < 5 && rateUpFourStars.Count != 0)
                    {
                        selectCraftEssence(rateUpFourStars.ElementAt(rnd.Next(0, rateUpFourStars.Count)));
                    }
                    else
                    {
                        selectCraftEssence(FourStars.ElementAt(rnd.Next(0, FourStars.Count)));
                    }
                    rarity = 4;
                }
                else
                {
                    if (rateUpCheck < 5 && rateUpThreeStars.Count != 0)
                    {
                        selectCraftEssence(rateUpThreeStars.ElementAt(rnd.Next(0, rateUpThreeStars.Count)));
                    }
                    else
                    {
                        selectCraftEssence(ThreeStars.ElementAt(rnd.Next(0, ThreeStars.Count)));
                    }
                    rarity = 3;
                }
            }
        }
        private void selectCraftEssence(CraftEssences CraftEssence)
        {
            switch (CraftEssence)
            {
                case CraftEssences.AzothBlade:
                    name = "Azoth Blade";
                    break;
                case CraftEssences.FalseAttendantsWritings:
                    name = "False Attendant's Writings";
                    break;
                case CraftEssences.AzureBlackKeys:
                    name = "The Azure Black Keys";
                    break;
                case CraftEssences.VerdantBlackKeys:
                    name = "The Verdant Black Keys";
                    break;
                case CraftEssences.CrimsonBlackKeys:
                    name = "The Crimson Black Keys";
                    break;
                case CraftEssences.RinsPendant:
                    name = "Rin's Pendant";
                    break;
                case CraftEssences.SpellTome:
                    name = "Spell Tome";
                    break;
                case CraftEssences.DragonsMeridian:
                    name = "Dragon's Meridian";
                    break;
                case CraftEssences.SorceryOre:
                    name = "Sorcery Ore";
                    break;
                case CraftEssences.Dragonkin:
                    name = "Dragonkin";
                    break;
                case CraftEssences.PartedSea:
                    name = "Parted Sea";
                    break;
                case CraftEssences.MooncellAutomaton:
                    name = "Mooncell Automaton";
                    break;
                case CraftEssences.Runestone:
                    name = "Runestone";
                    break;
                case CraftEssences.JackOLantern:
                    name = "Jack-O'-Lantern";
                    break;
                case CraftEssences.TrickOrTreat:
                    name = "Trick or Treat";
                    break;
                case CraftEssences.AnchorsAweigh:
                    name = "Anchors Aweigh";
                    break;
                case CraftEssences.IronWilledTraining:
                    name = "Iron-Willed Training";
                    break;
                case CraftEssences.PrimevalCurse:
                    name = "Primeval Curse";
                    break;
                case CraftEssences.Projection:
                    name = "Projection";
                    break;
                case CraftEssences.Gandr:
                    name = "Gandr";
                    break;
                case CraftEssences.VerdantSoundOfDestruction:
                    name = "Verdant Sound of Destruction";
                    break;
                case CraftEssences.GemMagecraftAntumbra:
                    name = "Gem Magecraft: Antumbra";
                    break;
                case CraftEssences.BeElegant:
                    name = "Be Elegant";
                    break;
                case CraftEssences.ImaginaryElement:
                    name = "The Imaginary Element";
                    break;
                case CraftEssences.DivineBanquet:
                    name = "Divine Banquet";
                    break;
                case CraftEssences.AngelsSong:
                    name = "Angel's Song";
                    break;
                case CraftEssences.SealDesignationEnforcer:
                    name = "Seal Designation Enforcer";
                    break;
                case CraftEssences.HolyShroudOfMagdalene:
                    name = "Holy Shroud of Magdalene";
                    break;
                case CraftEssences.MoonyJewel:
                    name = "Moony Jewel";
                    break;
                case CraftEssences.WithOneStrike:
                    name = "With One Strike";
                    break;
                case CraftEssences.HalloweenArrangement:
                    name = "Halloween Arangement";
                    break;
                case CraftEssences.CodeCast:
                    name = "Code Cast";
                    break;
                case CraftEssences.FormalCraft:
                    name = "Formal Craft";
                    break;
                case CraftEssences.ImaginaryAround:
                    name = "Imaginary Around";
                    break;
                case CraftEssences.LimitedZeroOver:
                    name = "Limited/Zero Over";
                    break;
                case CraftEssences.Kaleidoscope:
                    name = "Kaleidoscope";
                    break;
                case CraftEssences.HeavensFeel:
                    name = "Heaven's Feel";
                    break;
                case CraftEssences.PrismaCosmos:
                    name = "Prisma Cosmos";
                    break;
                case CraftEssences.TheBlackGrail:
                    name = "The Black Grail";
                    break;
                case CraftEssences.LittleHalloweenDevil:
                    name = "Little Halloween Devil";
                    break;
                case CraftEssences.VictorOfTheMoon:
                    name = "Victor of the Moon";
                    break;
                case CraftEssences.AnotherEnding:
                    name = "Another Ending";
                    break;
                default:
                    name = "Craft Essence not found!";
                    break;
            }
        }
    }

    public enum CraftEssences
    {
        AzothBlade,
        FalseAttendantsWritings,
        AzureBlackKeys,
        VerdantBlackKeys,
        CrimsonBlackKeys,
        RinsPendant,
        SpellTome,
        DragonsMeridian,
        SorceryOre,
        Dragonkin,
        PartedSea,
        MooncellAutomaton,
        Runestone,
        JackOLantern,
        TrickOrTreat,
        AnchorsAweigh,
        IronWilledTraining,
        PrimevalCurse,
        Projection,
        Gandr,
        VerdantSoundOfDestruction,
        GemMagecraftAntumbra,
        BeElegant,
        ImaginaryElement,
        DivineBanquet,
        AngelsSong,
        SealDesignationEnforcer,
        HolyShroudOfMagdalene,
        MoonyJewel,
        WithOneStrike,
        HalloweenArrangement,
        CodeCast,
        FormalCraft,
        ImaginaryAround,
        LimitedZeroOver,
        Kaleidoscope,
        HeavensFeel,
        PrismaCosmos,
        TheBlackGrail,
        LittleHalloweenDevil,
        VictorOfTheMoon,
        AnotherEnding
    }
}
