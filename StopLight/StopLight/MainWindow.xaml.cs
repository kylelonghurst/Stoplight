﻿using System;
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
using System.Timers;
using System.Threading;

namespace StopLight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// AUSTIN IS AN INTRAMURAL CHAMP!!!
    /// </summary>
    /// 

    

    public partial class MainWindow : Window
    {
        //System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        //int iLeftRight;

        Stoplight Light1 = new Stoplight(false, false);
        Stoplight Light2 = new Stoplight(false, false);
        Stoplight Light3 = new Stoplight(false, false);
        Stoplight Light4 = new Stoplight(false, false);
        Stoplight Light4R = new Stoplight(false, false);

        public MainWindow()
        {
            InitializeComponent();

            //iLeftRight = 0;

            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            //dispatcherTimer.Start();
        }

        private void SleepFive()
        {
            Thread.Sleep(5000);
        }

        private void SleepTwentyFive()
        {
            Thread.Sleep(25000);
        }

        private void LightLogic1()
        {

        }

        private void LightLogic2and4()
        {

        }

        private void LightLogic3()
        {

        }
        /*
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            SolidColorBrush red = new SolidColorBrush(Colors.Red);
            SolidColorBrush green = new SolidColorBrush(Colors.Green);
            SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);
            SolidColorBrush gray = new SolidColorBrush(Colors.LightGray);

                if (iLeftRight == 0)
                {
                    LeftGreen.Fill = gray;
                    LeftYellow.Fill = gray;
                    LeftRed.Fill = red;

                    RightGreen.Fill = gray;
                    RightYellow.Fill = gray;
                    RightRed.Fill = red;

                    TopGreen.Fill = green;
                    TopYellow.Fill = gray;
                    TopRed.Fill = gray; 

                    BottomGreen.Fill = green;
                    BottomYellow.Fill = gray;
                    BottomRed.Fill = gray;

                    iLeftRight = 1;
                }

                else if (iLeftRight == 1)
                {
                    LeftGreen.Fill = gray;
                    LeftYellow.Fill = gray;
                    LeftRed.Fill = red;

                    RightGreen.Fill = gray;
                    RightYellow.Fill = gray;
                    RightRed.Fill = red;

                    TopGreen.Fill = gray;
                    TopYellow.Fill = yellow;
                    TopRed.Fill = gray;

                    BottomGreen.Fill = gray;
                    BottomYellow.Fill = yellow;
                    BottomRed.Fill = gray;

                    iLeftRight = 2;
                }

                else if (iLeftRight == 2)
                {
                    LeftGreen.Fill = green;
                    LeftYellow.Fill = gray;
                    LeftRed.Fill = gray;

                    RightGreen.Fill = green;
                    RightYellow.Fill = gray;
                    RightRed.Fill = gray;

                    TopGreen.Fill = gray;
                    TopYellow.Fill = gray;
                    TopRed.Fill = red;

                    BottomGreen.Fill = gray;
                    BottomYellow.Fill = gray;
                    BottomRed.Fill = red;

                    iLeftRight = 3;
                }

                else if (iLeftRight == 3)
                {
                    LeftGreen.Fill = gray;
                    LeftYellow.Fill = yellow;
                    LeftRed.Fill = gray;

                    RightGreen.Fill = gray;
                    RightYellow.Fill = yellow;
                    RightRed.Fill = gray;

                    TopGreen.Fill = gray;
                    TopYellow.Fill = gray;
                    TopRed.Fill = red;

                    BottomGreen.Fill = gray;
                    BottomYellow.Fill = gray;
                    BottomRed.Fill = red;

                    iLeftRight = 0;
                }
            }
 */

        private void btnleft_Click(object sender, RoutedEventArgs e)
        {
            //dispatcherTimer.IsEnabled = false;
            //iLeftRight = 2;
            //dispatcherTimer.IsEnabled = true;
        }        

        private void Btn3Click(object sender, RoutedEventArgs e)
        {
            Light3.atStoplight = true;
            Btn3.IsEnabled = false;
        }

        private void Btn2Click(object sender, RoutedEventArgs e)
        {
            Light2.atStoplight = true;
            Btn2.IsEnabled = false;
        }

        private void Btn1Click(object sender, RoutedEventArgs e)
        {
            Light1.atStoplight = true;
            Btn1.IsEnabled = false;
        }

        private void Btn4Click(object sender, RoutedEventArgs e)
        {
            Light4.atStoplight = true;
            Btn4.IsEnabled = false;
        }
    }
}