using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lukasz_Kulesza_184764
{
    class trainingGame
    {
      
        StreamWriter sw;
        StreamReader reader;

        Random random = new Random();

        int index; // generowanie koloru
        Color color = new Color();
        Image image;

        int highestScore=0;

        int size; //generowanie rozmiaru kola
        int lrange = 40, trange = 60; //zmienne przechowujace minimalne i maksymalne wymiary losowanego kola
        Circle circle = new Circle(Properties.Resources.blueCircle, 15);

        double points = 0;




        public trainingGame()
        {
            this.points = points;
        }


       
        /// <summary>
        /// Losuje zdjęcie
        /// </summary>
        /// <returns>Zwraca losowe zdjęcie koła (Czerwone/Zielone/Niebieskie/Czarne)</returns>
        public Image generateImage()
        {
            index = random.Next(1, 5);
            switch (index)
            {
                case 1:
                    image = Properties.Resources.blackCircle;
                    break;

                case 2:
                    image = Properties.Resources.redCircle;
                    break;

                case 3:
                    image = Properties.Resources.greenCircle;
                    break;

                case 4:
                    image = Properties.Resources.blueCircle;
                    break;
            }
            return image;
        }

        /// <summary>
        /// Generuje rozmiar koła
        /// </summary>
        /// <returns>Zwraca losowo wygenerowany rozmiar okręgu z określonego przedziału</returns>
        public int generateSize()
        {
            size = random.Next(lrange, trange);
            return size;
        }

        /// <summary>
        /// Generuje lokalizację x
        /// </summary>
        /// <returns>Zwraca losowo wygenerowany punkt w płaszczyźnie x z przedziału (200,700)</returns>
        public int generateXLocation()
        {
            return random.Next(200, 700);
        }

        /// <summary>
        /// Generuje lokalizację y
        /// </summary>
        /// <returns>Zwraca losowo wygenerowany punkt w płaszczyźnie y z przedziału (200,600)</returns>
        public int generateYLocation()
        {
            return random.Next(200, 600);
        }

        /// <summary>
        /// Zmiana parametrów koła (rozmiaru i koloru)
        /// </summary>
        public void update()
        {
            int size = generateSize();
            Image image = generateImage();
            
            circle.setSize(size);
            circle.setImage(image);
        }

        /// <summary>
        /// Pobiera rozmiar koła
        /// </summary>
        /// <returns>Zwraca rozmiar koła</returns>
        public int getSize()
        {
            return circle.getSize();
        }

        /// <summary>
        /// Pobiera zdjęcie koła (kolor)
        /// </summary>
        /// <returns>Zwraca zdjęcie koła</returns>
        public Image getImage()
        {
            return circle.getImage();
        }

        /// <summary>
        /// Dodaje punkty
        /// </summary>
        /// <returns>Zwraca dodanie jednego punktu po kliknięciu myszą w obiekt</returns>
        public double addPoint()
        {
            points += 0.5;
            return points;
        }

        /// <summary>
        /// Sprawdza ile punktów zdobyto
        /// </summary>
        /// <returns>Zwraca ilość zdobytych punktów</returns>
        public double checkPoints()
        {
            return points;
        }

        /// <summary>
        /// Zapisuje ilość zdobytych punktów do pliku tekstowego wraz z aktualną datą
        /// </summary>
        public void savePoints()
        {
            sw = File.AppendText("wyniki.txt");

            DateTime thisDay = DateTime.Today;
            sw.WriteLine(thisDay + " Liczba zdobytych punktów = " + points);
            sw.Close();

            points = 0;
        }

        /// <summary>
        /// Porównuje dwa zdjęcia na podstawie koloru pixeli na środku koła
        /// </summary>
        /// <param name="img1">Pierwsze zdjęcie</param>
        /// <param name="img2">Drugie zdjęcie</param>
        /// <returns>Zwraca prawdę lub fałsz</returns>
        public bool compareImages(Image img1, Image img2)
        {

            Bitmap bmp1 = (Bitmap)img1;
            Bitmap bmp2 = (Bitmap)img2;

            if (bmp1.GetPixel(200, 200) == bmp2.GetPixel(200, 200))
            {
                return true;
            }
            else return false;

        }
        
        /// <summary>
        /// Sortuje aby znaleźć najwyższą wartość punktową
        /// </summary>
        /// <returns>Zwraca najwyższą wartość punktową</returns>
        public int findHighestScore()
        {
            reader = File.OpenText("wyniki.txt");
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lineTab = new string[2];
                lineTab = line.Split('=');

                if (int.TryParse(lineTab[1], out int number))
                {
                    if(number > highestScore)
                    {
                        highestScore = number;
                    }
                    
                }
            }
           
            reader.Close();

            return highestScore;


        }
        
    }
}
