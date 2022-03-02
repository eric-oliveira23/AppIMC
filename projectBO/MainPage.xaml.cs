using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace projectBO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var altura = double.Parse(entAlt.Text);
                var peso = double.Parse(entPes.Text);

                double imc = peso / (altura * altura);

                string resultado = $"Seu IMC é de: {imc.ToString("F")} ";


                if (imc < 18.5)
                {
                    resultado += "e seu status é de Baixo Peso.";
                }
                else if (imc > 18.6 && imc < 29.9)
                {
                    resultado += "e seu status é de Peso Normal.";
                }
                else if (imc > 25 && imc < 30)
                {
                    resultado += "e seu status é de Sobre Peso.";
                }
                else if (imc > 30 && imc < 35)
                {
                    resultado += "e seu status é de Obesidade I.";
                }
                else if (imc > 35 && imc < 40)
                {
                    resultado += "e seu status é de Obesidade II.";
                }
                else if (imc > 40)
                {
                    resultado += "e seu status é de Obesidade III.";
                }

                lblResult.Text = resultado;

            }

            catch (FormatException)
            {
                DisplayAlert("Aviso", "Formato digitado fora de contexto.", "OK");
            }

            catch (ArgumentNullException)
            {
                DisplayAlert("Aviso", "Preencha os campos corretamente.", "OK");
            }
        }            
    }
}
