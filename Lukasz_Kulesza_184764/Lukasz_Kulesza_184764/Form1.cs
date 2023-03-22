using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lukasz_Kulesza_184764
{
    public partial class Form1 : Form
    {
        trainingGame game = new trainingGame();
        Image bannedColor;
        int gameIndex = 1;
        int circleSize;
        double tInterval = 0;

        bool clicked = false;
        long dtPreviousClick;

        int circleCounter=0, timerIntervalCounter=0;

        trainingGame tG = new trainingGame();
        public Form1()
        {
            InitializeComponent();
           highestScoreLabel.Text = "Twój najwyższy wynik to: " + tG.findHighestScore();
        }

        private void trainingStartButton_Click(object sender, EventArgs e)
        {
            pointsLabel.Text = "Liczba zdobytych punktów: 0";
            timerIntervalCounter = 0;
            circleCounter = 0;
            Timer.Interval = 1000;
            bannedColor = game.generateImage();
            bannedColorBox.Image = bannedColor; //generowanie zakazanego koloru
            Timer.Start();
            trainingStartButton.Visible = false;
            changeGameButton.Enabled = false;
            trainingResultLabel.Visible = false;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timerIntervalCounter > circleCounter + 3) //jeżeli nie naciśniemy poprawnie 4 kół
            {
                Timer.Stop();
                trainingResultLabel.Visible = true;
                trainingResultLabel.Text = "Twój wynik to: " + game.checkPoints();
                game.savePoints();
                trainingStartButton.Visible = true;
                circleBox.Visible = false;
                changeGameButton.Enabled = true;
                highestScoreLabel.Text = "Twój najwyższy wynik to: " + tG.findHighestScore();
                Timer.Interval = 1000;
            }
            else
            {
                circleBox.Visible = true;
                circleSize = game.generateSize();
                circleBox.Width = circleSize;
                circleBox.Height = circleSize;

                timerIntervalCounter++;
                game.update();
                int size = game.getSize();
                circleBox.Height = size;
                circleBox.Width = size;
                // circleBox.BackColor = game.getColor();
                circleBox.Image = game.getImage();

                int x, y;
                x = game.generateXLocation();
                y = game.generateYLocation();

                circleBox.Location = new Point(x, y);
            }
        }

        private void circleBox_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound1);


            
            if (tG.compareImages(bannedColorBox.Image, circleBox.Image)) //jeżeli naciśniemy zakazany kolor
            {
                Timer.Stop();
                trainingResultLabel.Visible = true;
                trainingResultLabel.Text = "Twój wynik to: " + game.checkPoints();
                game.savePoints();
                trainingStartButton.Visible = true;
                circleBox.Visible = false;
                changeGameButton.Enabled = true;
                highestScoreLabel.Text = "Twój najwyższy wynik to: " + tG.findHighestScore();
                Timer.Interval = 1000;
            }
            else //jeżeli klikniemy kolor inny niż zakazany
            {
                soundPlayer.Play();
                game.addPoint(); //dodawanie punktów po kliknięciu
                circleBox.Visible = false; //klikniety to znika
                pointsLabel.Text = "Liczba zdobytych punktów: " + game.addPoint().ToString();
                Timer.Interval -= 30;
                circleCounter++;
            }
        }
        
        private void changeGameButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
           changeGame cg = new changeGame();
            if (gameIndex % 2 == 1)
            {
                cg.loadReflexTest();
                ++gameIndex;
            }
            else
            {
                cg.loadTraining();
                ++gameIndex;
            }
        }



        private void reflexTestBox_Click(object sender, EventArgs e)
        {
            reflexTest rt = new reflexTest();
            
            if (!clicked)
            {
                dtPreviousClick = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                clicked = true;
                rt.startTest();
                tInterval = rt.timerInterval;
                //reflexTestTimeLabel.Text = tInterval.ToString();
                
            }
            else if(reflexTestBox.BackColor == Color.Green)
            {
                reflexTestTimeLabel.Text = "Kliknąłeś za szybko!";
            }
            else if(reflexTestBox.BackColor == Color.Red)
            {
                rt.reflexTimer.Stop();
                reflexTestTimeLabel.Text = "Twój refleks to:" + "\n" + Math.Round(((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds - dtPreviousClick) - tInterval),2).ToString() + " ms";
                clicked = false;
                reflexTestBox.BackColor = Color.Green;
                
            }
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tryb treningowy: Na początku gry losowany jest zakazany kolor oraz zaczynają się pojawiać różnokolorowe koła. Twoim zadaniem jest kliknięcie jak największej ilości kółek oraz omijanie koła o zakazanym kolorze. Jeżeli nie naciśniesz 4 razy koła gra również się zakończy." + "\n" + "\n" + "Tryb sprawdzenia: Kliknij raz zielony obszar, jego kolor w losowym momencie zmieni kolor na czerwony. Twoim zadaniem jest jak najszybsze kliknięcie czerwonego koloru","Jak grać?",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
