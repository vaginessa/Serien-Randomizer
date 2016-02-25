using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Media.Imaging;
using System.Windows;

namespace SouthPark_Randomizer
{
    class Episode
    {
        private string Name;
        private string Link;
        private int Season;
        private int Folge;
        private Uri u;
        private BitmapImage Image;
  
        public Episode(int Season, int Folge, string Name, string Link, string Pic)
        {
            this.Name = Name;
            this.Link = Link;
            this.Season = Season;
            this.Folge = Folge;
            this.u = new Uri(Pic);
            this.Image = new BitmapImage(u);
        }

        public Episode(int Season, int Folge, string Name, string Link)
        {
            this.Season = Season;
            this.Folge = Folge;
            this.Name = Name;
            this.Link = Link;
            this.u = null;
            this.Image = null;
        }

        public BitmapImage image
        {
            get
            {
                return this.Image;
            }
        }

        public void Open()
        {
            try
            {
                System.Diagnostics.Process.Start(Link);
            }
            catch(Exception)
            {
                MessageBox.Show("Diese Folge ist momentan nicht verfügbar", "Error");               
            }
        }


        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string link
        {
            get
            {
                return Link;
            }
            set
            {
                Link = value;
            }
        }

        public int season
        {
            get
            {
                return Season;
            }
            set
            {
                Season = value;
            }
        }

        public int folge
        {
            get
            {
                return Folge;
            }
            set
            {
                Folge = value;
            }
        }
    }
}
