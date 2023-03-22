using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukasz_Kulesza_184764
{
    class Circle
    {
        Color color = new Color();

        int size;

        Image image = Properties.Resources.blueCircle;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="image"></param>
        /// <param name="size"></param>
        public Circle(Image image, int size)
        {
            this.image = image;
            this.size = size;
        }

        /// <summary>
        /// Pobiera rozmiar koła
        /// </summary>
        /// <returns>Zwraca rozmiar koła</returns>
        public int getSize()
        {
            return size;
        }

        /// <summary>
        /// Pobiera zdjęcie koła
        /// </summary>
        /// <returns>Zwraca zdjęcie koła</returns>
        public Image getImage()
        {
            return image;
        }

        /// <summary>
        /// Ustawia zdjęcie koła
        /// </summary>
        /// <param name="x">Zdjęcie koła</param>
        public void setImage(Image x)
        {
            this.image = x;
        }


        /// <summary>
        /// Ustawia rozmiar koła
        /// </summary>
        /// <param name="x">Rozmiar koła</param>
        public void setSize(int x)
        {

            this.size = x;
        }



    }
}
