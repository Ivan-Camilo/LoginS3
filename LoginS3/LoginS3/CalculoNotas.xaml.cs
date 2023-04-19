using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginS3
{
    public partial class CalculoNotas : ContentPage
    {
        public CalculoNotas()
        {
            InitializeComponent();
            DisplayAlert("Advertencia", "\nSolo ingresar valores entre 0.1 y 10", "OK");
        }
        void Calcular_Clicked(System.Object sender, System.EventArgs e)
        {
            Encerar();
            var NS1 = double.Parse(txtNota1.Text);
            var examen1 = double.Parse(txtExamen1.Text);
            var NP1 = (NS1 * 0.3) + (examen1 * 0.2);
            lblNotaparcial.Text = NP1.ToString();

            var NS2 = double.Parse(txtNota2.Text);
            var examen2 = double.Parse(txtExamen2.Text);
            var NP2 = (NS2 * 0.3) + (examen2 * 0.2);
            lblNotaparcial2.Text = NP2.ToString();

            var notafinal = NP1 + NP2;
            lblNotafinal.Text = notafinal.ToString();

            if (notafinal >= 7)
            {
                DisplayAlert("Aprobado", notafinal + "\nFelicitaciones", "OK");
            }
            else if (notafinal >= 5 && notafinal <= 6.9)
            {
                DisplayAlert("Examen Complementario", notafinal + "\nA estudiar", "OK");
            }
            else
            {
                DisplayAlert("Reprobado", notafinal + "\nNos vemos el proximo semestre", "OK");
            }

        }

        private void Encerar()

        {
            if (string.IsNullOrEmpty(txtNota1.Text))
                txtNota1.Text = "0.1";
            if (string.IsNullOrEmpty(txtExamen1.Text))
                txtExamen1.Text = "0.1";
            if (string.IsNullOrEmpty(txtNota2.Text))
                txtNota2.Text = "0.1";
            if (string.IsNullOrEmpty(txtExamen2.Text))
                txtExamen2.Text = "0.1";

        }

        void Borrar_Clicked(System.Object sender, System.EventArgs e)
        {
            txtNota1.Text = "";
            txtExamen1.Text = "";
            txtNota2.Text = "";
            txtExamen2.Text = "";
            lblNotaparcial.Text = "";
            lblNotaparcial2.Text = "";
            lblNotafinal.Text = "";
        }

    }
}

