using System;
using System.Linq;
using System.Windows.Forms;

namespace Lukasz_Kulesza_184764
{
    class changeGame
    {
        Label bannedColorLabel = Application.OpenForms["Form1"].Controls["bannedColorLabel"] as Label;
        Button trainingStartButton = Application.OpenForms["Form1"].Controls["trainingStartButton"] as Button;
        Label pointsLabel = Application.OpenForms["Form1"].Controls["pointsLabel"] as Label;
        PictureBox reflexTestBox = Application.OpenForms["Form1"].Controls["reflexTestBox"] as PictureBox;
        PictureBox bannedColorBox = Application.OpenForms["Form1"].Controls["bannedColorBox"] as PictureBox;
        Label reflexTestTimeLabel = Application.OpenForms["Form1"].Controls["reflexTestTimeLabel"] as Label;
        Label trainingResultLabel = Application.OpenForms["Form1"].Controls["trainingResultLabel"] as Label;
        Label highestScoreLabel = Application.OpenForms["Form1"].Controls["highestScoreLabel"] as Label;

        /// <summary>
        /// Wczytuje komponenty programu odpowiedzialne za tryb sprawdzania refleksu
        /// </summary>
        public void loadReflexTest()
        {
            bannedColorLabel.Visible = false ;
            trainingStartButton.Visible = false;
            pointsLabel.Visible = false;
            reflexTestBox.Visible = true;
            bannedColorBox.Visible = false;
            reflexTestTimeLabel.Visible = true;
            trainingResultLabel.Visible = false;
            highestScoreLabel.Visible = false;
        }

        /// <summary>
        /// Wczytuje komponenty programu odpowiedzialne za tryb ćwiczenia
        /// </summary>
        public void loadTraining()
        {
            bannedColorLabel.Visible = true;
            trainingStartButton.Visible = true;
            pointsLabel.Visible = true;
            reflexTestBox.Visible = false;
            reflexTestTimeLabel.Visible = false;
            bannedColorBox.Visible = true;
            highestScoreLabel.Visible = true;
        }
        
    }
}
