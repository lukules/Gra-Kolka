using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Lukasz_Kulesza_184764
{
    class reflexTest
    {
        PictureBox reflexTestBox = Application.OpenForms["Form1"].Controls["reflexTestBox"] as PictureBox;
        Random random = new Random();
        public System.Timers.Timer reflexTimer = new System.Timers.Timer();
        public double timerInterval;

        /// <summary>
        /// Odpowiada za tryb sprawdzania refleksu (start gry, timera)
        /// </summary>
        public void startTest()
        { 
            reflexTestBox.Visible = true;
            reflexTestBox.BackColor = Color.Green;
            timerInterval = random.Next(1000, 5000);
            reflexTimer.Interval = timerInterval;
            
            reflexTimer.Elapsed += OnTimedEvent;
            reflexTimer.Enabled = true;
            
        }

        /// <summary>
        /// Zmienia kolor na czerwony po upłynięciu czasu Timera
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            reflexTestBox.BackColor = Color.Red;
            reflexTimer.Stop();
        }

    }
}
