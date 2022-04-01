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
using System.Windows.Shapes;

namespace Atividade._1
{
    /// <summary>
    /// Lógica interna para CalculadoraWindow.xaml
    /// </summary>
    public partial class CalculadoraWindow : Window
    {
        decimal calcular;
        bool adicao = false;
        bool subtracao = false;
        bool divisao = false;
        bool multiplicacao = false;
        bool valor = false;
        bool resultado = false;

        public CalculadoraWindow()
        {
            


            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtZero_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "0";
            txtcalculo.Text += "0";
        }

        private void BtUm_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "1";
            txtcalculo.Text += "1";
        }

        private void BtDois_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "2";
            txtcalculo.Text += "2";
        }

        private void BtTres_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "3";
            txtcalculo.Text += "3";
        }

        private void BtQuatro_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "4";
            txtcalculo.Text += "4";
        }

        private void BtCinco_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "5";
            txtcalculo.Text += "5";
        }

        private void BtSeis_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "6";
            txtcalculo.Text += "6";
        }

        private void BtSete_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "7";
            txtcalculo.Text += "7";
        }

        private void BtOito_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "8";
            txtcalculo.Text += "8";
        }

        private void BtNove_Click(object sender, RoutedEventArgs e)
        {
            txtValor.Text += "9";
            txtcalculo.Text += "9";
        }

        private void BtSomar_Click(object sender, RoutedEventArgs e)
        {
            calcular = Convert.ToDecimal(txtValor.Text);

            txtcalculo.Text += "+";
            txtValor.Text = "";

            adicao = true;
            subtracao = false;
            divisao = false;
            multiplicacao = false;

        }

        private void BtIgualdade_Click(object sender, RoutedEventArgs e)
        {
            resultado = true;

            txtcalculo.Text += "=";

            if(adicao == true)
            {
                txtValor.Text = Convert.ToString (Convert.ToDecimal(txtValor.Text) + calcular);
                txtcalculo.Text += txtValor.Text;

            }

            if (subtracao == true)
            {
                txtValor.Text = Convert.ToString( calcular - Convert.ToDecimal(txtValor.Text) );
                txtcalculo.Text += txtValor.Text;
            }

            if (divisao == true)
            {
                txtValor.Text = Convert.ToString( calcular / Convert.ToDecimal(txtValor.Text) );
                txtcalculo.Text += txtValor.Text;
            }

            if (multiplicacao == true)
            {
                txtValor.Text = Convert.ToString(Convert.ToDecimal(txtValor.Text) * calcular  );
                txtcalculo.Text += txtValor.Text;
            }
        }

        private void BtLimparTudo_Click(object sender, RoutedEventArgs e)
        {
            txtcalculo.Text = "";
            txtValor.Text = "";
        }

        private void BtSubtracao_Click(object sender, RoutedEventArgs e)
        {
            calcular = Convert.ToDecimal(txtValor.Text);

            txtcalculo.Text += "-";
            txtValor.Text = "";

            adicao = false;
            subtracao = true;
            divisao = false;
            multiplicacao = false;
        }

        private void BtMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            calcular = Convert.ToDecimal(txtValor.Text);

            txtcalculo.Text += "*";
            txtValor.Text = "";

            adicao = false;
            subtracao = false;
            divisao = false;
            multiplicacao = true;

        }

        private void BtDivisao_Click(object sender, RoutedEventArgs e)
        {
            calcular = Convert.ToDecimal(txtValor.Text);

            txtcalculo.Text += "/";
            txtValor.Text = "";

            adicao = false;
            subtracao = false;
            divisao = true;
            multiplicacao = false;
        }
    }
}
