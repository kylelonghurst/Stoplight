using System;
using System.Collections.Generic;
using System.Windows.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace StopLight
{
    class Stoplight
    {
        SolidColorBrush RED = new SolidColorBrush(Colors.Red);
        SolidColorBrush GREEN = new SolidColorBrush(Colors.Green);
        SolidColorBrush YELLOW = new SolidColorBrush(Colors.Yellow);
        SolidColorBrush BLACK = new SolidColorBrush(Colors.Black);

        public bool isActive { get; set; }
        public bool atStoplight { get; set; }

        public Stoplight(bool Active, bool at)
        {
            isActive = Active;
            atStoplight = at;
        }

        public void turnON(Ellipse Red, Ellipse Yellow, Ellipse Green)
        {
            isActive = true;
            Red.Fill = BLACK;
            Yellow.Fill = BLACK;
            Green.Fill = GREEN;
        }

        public void changing(Ellipse Red, Ellipse Yellow, Ellipse Green)
        {
            Red.Fill = BLACK;
            Yellow.Fill = YELLOW;
            Green.Fill = BLACK;
        }

        public void turnOff(Ellipse Red, Ellipse Yellow, Ellipse Green)
        {
            isActive = false;
            Red.Fill = RED;
            Yellow.Fill = BLACK;
            Green.Fill = BLACK;
        }
    }
}
