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

namespace Atividade._1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtEmail.Focus();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string senha = txtSenha.Password.ToString();
            string email = txtEmail.Text;

              if ( email == "lumakama@gmail.com" && senha == "lumakama")
              {
                CalculadoraWindow calculadora = new CalculadoraWindow();
                calculadora.ShowDialog();
                this.Close();
 
              }
              
              else
              {
                MessageBox.Show("Senha ou Email inválido", "Erro", MessageBoxButton.OK);
                //txt_email.Clear();
                //txt_senha.Clear();
                txtEmail.Focus();  

              }

        }

        private void redefinir_senha_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
