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

namespace CalculatriceV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Déclaration des "operands" et des operations en global
        double NombreA;
        double NombreB;
        double Total;
        string Operation;
        private void Additionner_Click(object sender, RoutedEventArgs e)
        {
            NombreA = Convert.ToDouble(Resultat.Text);
            Resultat.Text = "0";
            //Resultat.Text = Resultat.Text + " " + "+ ";
            Operation = "+";
        }

        private void Soustraire_Click(object sender, RoutedEventArgs e)
        {
            NombreA = Convert.ToDouble(Resultat.Text);
            Resultat.Text = "0";
            Operation = "-";
        }

        private void Multiplier_Click(object sender, RoutedEventArgs e)
        {
            NombreA = Convert.ToDouble(Resultat.Text);
            Resultat.Text = "0";
            Operation = "*";
        }

        private void Diviser_Click(object sender, RoutedEventArgs e)
        {
            NombreA = Convert.ToDouble(Resultat.Text);
            Resultat.Text = "0";
            Operation = "/";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Resultat.Text = "0";
        }

        private void Virgule_Click(object sender, RoutedEventArgs e)
        {
            Resultat.Text = Resultat.Text + ",";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Resultat.Text = Resultat.Text + "0";
        }
        private void Un_Click(object sender, RoutedEventArgs e)
        {
            //Au click du chiffre, ajout ou remplacement selon l'élément présent dans la textbox
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "1";
            }
            else
            {
                Resultat.Text = Resultat.Text + "1";
            }
        }

        private void Deux_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "2";
            }
            else
            {
                Resultat.Text = Resultat.Text + "2";
            }
        }

        private void Trois_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "3";
            }
            else
            {
                Resultat.Text = Resultat.Text + "3";
            }
        }

        private void Quatre_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "4";
            }
            else
            {
                Resultat.Text = Resultat.Text + "4";
            }
        }

        private void Cinq_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "5";
            }
            else
            {
                Resultat.Text = Resultat.Text + "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "6";
            }
            else
            {
                Resultat.Text = Resultat.Text + "6";
            }
        }

        private void Sept_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "7";
            }
            else
            {
                Resultat.Text = Resultat.Text + "7";
            }
        }

        private void Huit_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "8";
            }
            else
            {
                Resultat.Text = Resultat.Text + "8";
            }
        }

        private void Neuf_Click(object sender, RoutedEventArgs e)
        {
            if (Resultat.Text == "0" && Resultat.Text != null)
            {
                Resultat.Text = "9";
            }
            else
            {
                Resultat.Text = Resultat.Text + "9";
            }
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            NombreB = Convert.ToDouble(Resultat.Text);

            if (Operation == "+")
            {
                Total = (NombreA + NombreB);
                Resultat.Text = Convert.ToString(Total);
                NombreA = Total;
            }
            if (Operation == "-")
            {
                Total = (NombreA - NombreB);
                Resultat.Text = Convert.ToString(Total);
                NombreA = Total;
            }
            if (Operation == "*")
            {
                Total = (NombreA * NombreB);
                Resultat.Text = Convert.ToString(Total);
                NombreA = Total;
            }
            if (Operation == "/")
            {
                if (NombreB == 0)
                {
                    Resultat.Text = "Division par 0";
                }
                else
                {
                    Total = (NombreA / NombreB);
                    Resultat.Text = Convert.ToString(Total);
                    NombreA = Total;
                }
            }
        }
    }
}
