using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_RateUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random randomGenerator = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* Print a ten roll
             
            List<String> output = roller.tenRoll();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(output.ElementAt(i) + ", ");
            }
            Console.WriteLine();*/

            int startingQuartz = 30;
            int startingTickets = 0;
            double numberOfTrials = 50000;

            int rollsWithTamamo = 0;
            List<int> fiveStarIncidences = new List<int>();
            List<int> fourStarIncidences = new List<int>();
            List<int> fiveStarCEIncidences = new List<int>();
            List<int> fourStarCEIncidences = new List<int>();
            List<int> remainingQuartzOnGet = new List<int>();
            for (int i = 0; i < numberOfTrials; i++)
            {
                Roller roller = new Roller();
                int quartz = startingQuartz;
                int tickets = startingTickets;
                bool gotTamamo = false;
                while (tickets > 0 && !gotTamamo)
                {
                    String output = roller.roll();
                    if (output.Equals("Tamamo no Mae") && !gotTamamo)
                    {
                        gotTamamo = true;
                        remainingQuartzOnGet.Add(quartz);
                    }
                    tickets -= 1;
                }
                while (quartz >= 30 && !gotTamamo)
                {
                    List<String> output = roller.tenRoll();
                    if (output.Contains("Tamamo no Mae") && !gotTamamo)
                    {
                        gotTamamo = true;
                        remainingQuartzOnGet.Add(quartz);
                    }
                    quartz -= 30;
                }
                if (gotTamamo)
                {
                    rollsWithTamamo++;
                }
                fiveStarIncidences.Add(roller.fiveStarServants);
                fiveStarCEIncidences.Add(roller.fiveStarCEs);
                fourStarIncidences.Add(roller.fourStarServants);
                fourStarCEIncidences.Add(roller.fourStarCEs);
            }
            Console.WriteLine("Rolls with a Jack: " + rollsWithTamamo + "/" + numberOfTrials);
            Console.WriteLine("Odds of getting Jack on a single expidenture: " + (double)rollsWithTamamo*100 / numberOfTrials);
            int fiveStarTimes = 0;
            int fiveStarCount = 0;
            foreach (int i in fiveStarIncidences)
            {
                if (i > 0)
                {
                    fiveStarTimes++;
                    fiveStarCount += i;
                }
            }
            Console.WriteLine("Odds of getting a 5* Servant: " + (double)fiveStarTimes*100 / numberOfTrials);
            Console.WriteLine("Average 5* Servant count: " + (double)fiveStarCount / numberOfTrials);
            int fiveStarCETimes = 0;
            int fiveStarCECount = 0;
            foreach (int i in fiveStarCEIncidences)
            {
                if (i > 0)
                {
                    fiveStarCETimes++;
                    fiveStarCECount += i;
                }
            }
            Console.WriteLine("Odds of getting a 5* CE: " + (double)fiveStarCETimes*100 / numberOfTrials);
            Console.WriteLine("Average 5* CE count: " + (double)fiveStarCECount / numberOfTrials);
            int fourStarServantTimes = 0;
            int fourStarServantCount = 0;
            foreach (int i in fourStarIncidences)
            {
                if (i > 0)
                {
                    fourStarServantTimes++;
                    fourStarServantCount += i;
                }
            }
            Console.WriteLine("Odds of getting a 4* Servant: " + (double)fourStarServantTimes * 100 / numberOfTrials);
            Console.WriteLine("Average 4* Servant count: " + (double)fourStarServantCount / numberOfTrials);
            int fourStarCECount = 0;
            foreach (int i in fourStarCEIncidences)
            {
                if (i > 0)
                {
                    fourStarCECount += i;
                }
            }
            Console.WriteLine("Average 4* CE count: " + (double)fourStarCECount / numberOfTrials);
            int remQuartzOnGet = 0;
            int successes = 0;
            foreach (int i in remainingQuartzOnGet)
            {
                successes++;
                remQuartzOnGet += i;
            }
            Console.WriteLine("Average remaining quartz upon getting Jack: " + (double)remQuartzOnGet / (double)successes);
        }
    }
}
