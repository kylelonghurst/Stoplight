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
        Stoplight Light3L = new Stoplight(false, false);
        Stoplight Light4 = new Stoplight(false, false);
        Stoplight Light4R = new Stoplight(false, false);

        int index;

        public MainWindow()
        {
            InitializeComponent();

            index = 3;

            DefaultLogic();
            
            do
            {
                if (index == 3)
                {
                    LightLogic3();
                }
                else if (index == 2)
                {
                    LightLogic2and4();
                }
                else if (index == 1)
                {
                    LightLogic1();
                }
                else
                {
                    index = 5;
                }
            } while (index != 5);

            if (index == 5)
            {
                this.Close();
            }

            //iLeftRight = 0;

            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            //dispatcherTimer.Start();
        }

        private void DefaultLogic()
        {
            // turn light 3 and 4R on
            Light3.turnON(BottomRed,BottomYellow, BottomGreen);
            Light3L.turnON(BottomRed, BottomLeftYellow, BottomLeftGreen);
            Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen);

            // turn off lights 1, 2, and 4
            Light1.turnOFF(TopRed, TopYellow, TopGreen);
            Light2.turnOFF(RightRed, RightYellow, RightGreen);
            Light4.turnOFF(LeftRed, LeftYellow, LeftGreen); 
        }

        private void SleepFive()
        {
            Thread.Sleep(5000);
        }

        private void SleepTwentyFive()
        {
            Thread.Sleep(25000);
        }

        private void enableButtons()
        {
            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
        }

        private void LightLogic1()
        {
                SleepFive();

                if (Light1.atStoplight == true)
                {
                    SleepTwentyFive();
                }
                
                if (Light3.atStoplight == true)
                {
                    Light1.turnOFF(TopRed, TopYellow, TopGreen); //turn off

                    Light3.turnON(BottomRed, BottomYellow, BottomGreen); //turn on
                    Light3L.turnON(BottomRed, BottomLeftYellow, BottomLeftGreen);
                    Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen); //turn on

                    index = 3;
                }
                else if (Light2.atStoplight == true || Light4.atStoplight == true)
                {
                    Light1.turnOFF(TopRed, TopYellow, TopGreen); //turn off

                    Light2.turnON(RightRed, RightYellow, RightGreen);
                    Light4.turnON(LeftRed, LeftYellow, LeftGreen);
                    Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen); //turn on

                    index = 2;
                }
                else
                {
                    Light1.turnOFF(TopRed, TopYellow, TopGreen); //turn off

                    Light3.turnON(BottomRed, BottomYellow, BottomGreen); //turn on defaults
                    Light3L.turnON(BottomRed, BottomLeftYellow, BottomLeftGreen);
                    Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen);//turn on defaults

                    index = 1;
                }
        }

        private void LightLogic2and4()
        {
                enableButtons();
                SleepFive();

                if (Light2.atStoplight== true || Light4.atStoplight == true)
                {
                    SleepTwentyFive();
                }
                
                if (Light1.atStoplight == true)
                {
                    Light2.turnOFF(RightRed, RightYellow, RightGreen);
                    Light4.turnOFF(LeftRed, LeftYellow, LeftGreen); // turn off

                    Light1.turnON(TopRed, TopYellow, TopGreen);

                    index = 1;
                }
                else
                {
                    Light2.turnOFF(RightRed, RightYellow, RightGreen);
                    Light4.turnOFF(LeftRed, LeftYellow, LeftGreen); //turn off

                    Light3.turnON(BottomRed, BottomYellow, BottomGreen);  //turn on Defaults.No cars at other lights
                    Light3L.turnON(BottomRed, BottomLeftYellow, BottomLeftGreen);
                    Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen); //turn on Defaults.No cars at other lights

                    index = 3;
                }
        }

        private void LightLogic3()
        {
                enableButtons();
                SleepFive();

                if (Light3.atStoplight == true)
                {
                    SleepTwentyFive();
                }
                
                if (Light2.atStoplight == true || Light4.atStoplight == true)
                {
                    Light3.isActive = false; //Turn off
                    Light4R.isActive = false; //Turn off

                    Light2.turnON(RightRed, RightYellow, RightGreen);
                    Light4.turnON(LeftRed, LeftYellow, LeftGreen); // turn on

                    index = 2;
                }
                else if (Light1.atStoplight == true)
                {
                    Light3.turnOFF(BottomRed, BottomYellow, BottomGreen);
                    Light3L.turnOFF(BottomRed, BottomLeftYellow, BottomLeftGreen);
                    Light4R.turnOFF(LeftRed, LeftRightYellow, LeftRightGreen);

                    Light1.turnON(TopRed, TopYellow, TopGreen);

                    index = 1;
                }
                else
                {
                    //return back to default. No cars at any other lights
                          // turn light 3 and 4R on
                    Light3.turnON(BottomRed, BottomYellow, BottomGreen);
                    Light3L.turnON(BottomRed, BottomLeftYellow, BottomLeftGreen);
                    Light4R.turnON(LeftRed, LeftRightYellow, LeftRightGreen);

                         // turn off lights 1, 2, and 4
                    Light1.turnOFF(TopRed, TopYellow, TopGreen);
                    Light2.turnOFF(RightRed, RightYellow, RightGreen);
                    Light4.turnOFF(LeftRed, LeftYellow, LeftGreen);

                    index = 3;
                }
        }
        
        private void Btn3Click(object sender, RoutedEventArgs e)
        {
            Light3.atStoplight = true;
            Btn3.IsEnabled = false;
            //LightLogic3();
        }
       
        private void Btn2Click(object sender, RoutedEventArgs e)
        {
            Light2.atStoplight = true;
            Btn2.IsEnabled = false;
            //LightLogic2and4();
        }

        private void Btn1Click(object sender, RoutedEventArgs e)
        {
            Light1.atStoplight = true;
            Btn1.IsEnabled = false;
            //LightLogic1();
            
        }

        private void Btn4Click(object sender, RoutedEventArgs e)
        {
            Light4.atStoplight = true;
            Btn4.IsEnabled = false;
            //LightLogic2and4();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            index = 5;
        }
    }
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

/* Code from Ganderson
private void btnleft_Click(object sender, RoutedEventArgs e)
{
    //dispatcherTimer.IsEnabled = false;
    //iLeftRight = 2;
    //dispatcherTimer.IsEnabled = true;
}        
*/
