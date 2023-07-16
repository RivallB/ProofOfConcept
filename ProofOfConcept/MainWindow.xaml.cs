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

namespace ProofOfConcept
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            statusReport.Text = controller.StatusReport;
        }
        Controller controller = new Controller();

        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            statusReport.Text = controller.StatusReport;
            if (!int.TryParse(besmetting.Text, out int rNum) || (rNum < 0) || (rNum > 100))
            {
                return;
            }
            if (!int.TryParse(doding.Text, out int dPercent) || (dPercent < 0) || (dPercent > 100))
            {
                return;
            }
            if (!int.TryParse(incubatie.Text, out int iDag) || (iDag < 0) || (iDag > 20))
            {
                return;
            }
            controller.R_Waarde = rNum;
            controller.IncubatieTijd = iDag;
            controller.DodelijkKans = dPercent;
        }
        class Controller
        {
            Random random = new Random();
            public int IncubatieTijd;
            public int DodelijkKans;
            public int R_Waarde;
            private int AllHealthy = 10000;
            private int AllSick = 0;
            private int AllImmune = 0;
            private int AllDead = 0;
            public string StatusReport { get { return $"Aantal gezonde mensen: {AllHealthy}\nAantal zieke mensen: {AllSick}\nAantal immune mensen: {AllImmune}\nAantal dode mensen: {AllDead}"; } }
            Human[] population = new Human[10];
            public void FirstSick()
            {
                int whichGroup = random.Next(10);
                population[whichGroup].sick = 1;
            }
            
        }
        abstract class Human
        {
            public abstract float healthy { get; set; }
            public abstract float sick { get; set; }
            public abstract float immune { get; set; }
            public abstract float dead { get; set; }
            public abstract void NewDay();
        }
        class Children : Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }

        }
        class Teens : Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class Students : Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class YoungAdults : Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class Adults : Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class OldAdults: Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class YoungElders: Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class Elders: Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class OldElders: Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
        class Ancients: Human
        {
            public override float healthy { get; set; } = 1000;
            public override float sick { get; set; } = 0;
            public override float immune { get; set; } = 0;
            public override float dead { get; set; } = 0;
            public override void NewDay()
            {

            }
        }
    }
    
}
    