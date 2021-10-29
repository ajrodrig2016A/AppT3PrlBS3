using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppT3PrlBS3
{
    public partial class MainPage : ContentPage
    {
        private double dblInputNotaSegUno = 0.00;
        private double dblInputNotaExamUno = 0.00;
        private double dblInputNotaSegDos = 0.00;
        private double dblInputNotaExamDos = 0.00;

        private double dblOutputNotaSegUno = 0.00;
        private double dblOutputNotaExamUno = 0.00;
        private double dblOutputNotaSegDos = 0.00;
        private double dblOutputNotaExamDos = 0.00;

        public MainPage(string usuario, string clave)
        {
            InitializeComponent();
            //Envío a los labels
            lblUsuario.Text = usuario;
            lblContrasena.Text = clave;
        }
        private void txtNotaSegUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtMostrarNotaSegUno.Text = String.Empty;
            try
            {
                if (txtNotaSegUno.Text != String.Empty)
                {
                    dblInputNotaSegUno = Convert.ToDouble(txtNotaSegUno.Text);
                    if (dblInputNotaSegUno > 10)
                    {
                        mostrarMsjCalificacionesInvalidas();
                    }
                    else
                    {
                        dblOutputNotaSegUno = Math.Round(0.3 * dblInputNotaSegUno, 2);
                        txtMostrarNotaSegUno.Text = Convert.ToString(dblOutputNotaSegUno);
                        if (dblOutputNotaSegUno > 0 && dblOutputNotaExamUno > 0)
                        {
                            txtMostrarNotaParcialUno.Text = Convert.ToString(dblOutputNotaSegUno + dblOutputNotaExamUno);
                        }
                    }
                }
                else
                {
                    mostrarMsjIngresoDatos();
                    dblOutputNotaSegUno = 0.00;
                    txtMostrarNotaParcialUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtNotaExamUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtMostrarNotaExamUno.Text = String.Empty;
            try
            {
                if (txtNotaExamUno.Text != String.Empty)
                {
                    dblInputNotaExamUno = Convert.ToDouble(txtNotaExamUno.Text);
                    if (dblInputNotaExamUno > 10)
                    {
                        mostrarMsjCalificacionesInvalidas();
                    }
                    else
                    {
                        dblOutputNotaExamUno = Math.Round(0.2 * dblInputNotaExamUno, 2);
                        txtMostrarNotaSegUno.Text = Convert.ToString(dblOutputNotaSegUno);
                        txtMostrarNotaExamUno.Text = Convert.ToString(dblOutputNotaExamUno);
                        if (dblOutputNotaSegUno > 0 && dblOutputNotaExamUno > 0)
                        {
                            txtMostrarNotaParcialUno.Text = Convert.ToString(dblOutputNotaSegUno + dblOutputNotaExamUno);
                        }
                    }
                }
                else
                {
                    mostrarMsjIngresoDatos();
                    dblOutputNotaExamUno = 0.00;
                    txtMostrarNotaParcialUno.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtNotaSegDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtMostrarNotaSegDos.Text = String.Empty;
            try
            {
                if (txtNotaSegDos.Text != String.Empty)
                {
                    dblInputNotaSegDos = Convert.ToDouble(txtNotaSegDos.Text);
                    if (dblInputNotaSegDos > 10)
                    {
                        mostrarMsjCalificacionesInvalidas();
                    }
                    else
                    {
                        dblOutputNotaSegDos = Math.Round(0.3 * dblInputNotaSegDos, 2);
                        txtMostrarNotaSegDos.Text = Convert.ToString(dblOutputNotaSegDos);
                        if (dblOutputNotaSegDos > 0 && dblOutputNotaExamDos > 0)
                        {
                            txtMostrarNotaParcialDos.Text = Convert.ToString(dblOutputNotaSegDos + dblOutputNotaExamDos);
                        }
                    }
                }
                else
                {
                    mostrarMsjIngresoDatos();
                    dblOutputNotaSegDos = 0.00;
                    txtMostrarNotaParcialDos.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void txtNotaExamDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtMostrarNotaExamDos.Text = String.Empty;
            try
            {
                if (txtNotaExamDos.Text != String.Empty)
                {
                    dblInputNotaExamDos = Convert.ToDouble(txtNotaExamDos.Text);
                    if (dblInputNotaExamDos > 10)
                    {
                        mostrarMsjCalificacionesInvalidas();
                    }
                    else
                    {
                        dblOutputNotaExamDos = Math.Round(0.2 * dblInputNotaExamDos, 2);
                        txtMostrarNotaSegDos.Text = Convert.ToString(dblOutputNotaSegDos);
                        txtMostrarNotaExamDos.Text = Convert.ToString(dblOutputNotaExamDos);
                        if (dblOutputNotaSegDos > 0 && dblOutputNotaExamDos > 0)
                        {
                            txtMostrarNotaParcialDos.Text = Convert.ToString(dblOutputNotaSegDos + dblOutputNotaExamDos);
                        }

                    }
                }
                else
                {
                    mostrarMsjIngresoDatos();
                    dblOutputNotaExamDos = 0.00;
                    txtMostrarNotaParcialDos.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void mostrarMsjIngresoDatos()
        {
            DisplayAlert("Mensaje de alerta", "El campo está vacío, favor ingrese el dato", "OK");
        }

        private void mostrarMsjCalificacionesInvalidas()
        {
            DisplayAlert("Mensaje de alerta", "No se permiten calificaciones mayores que 10", "OK");
        }

        private void btnNotaFinal_Clicked(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtNotaSegUno.Text) && !String.IsNullOrEmpty(txtNotaSegDos.Text) && !String.IsNullOrEmpty(txtNotaExamUno.Text) && !String.IsNullOrEmpty(txtNotaExamDos.Text))
            {
                double dblNotaParcialUno = Math.Round(dblOutputNotaSegUno + dblOutputNotaExamUno, 2);
                double dblNotaParcialDos = Math.Round(dblOutputNotaSegDos + dblOutputNotaExamDos, 2);

                double dblNotaFinal = dblNotaParcialUno + dblNotaParcialDos;

                if (dblNotaFinal >= 7)
                {
                    DisplayAlert("Mensaje informativo", "Estado: " + Convert.ToString(dblNotaFinal) + " - Aprobado", "OK");
                }
                else if (dblNotaFinal >= 5 && dblNotaFinal <= 6.9)
                {
                    DisplayAlert("Mensaje informativo", "Estado: " + Convert.ToString(dblNotaFinal) + " - Complementario", "OK");
                }
                else
                {
                    DisplayAlert("Mensaje informativo", "Estado: " + Convert.ToString(dblNotaFinal) + " - REPROBADO", "OK");
                }

                limpiarCampos();
            }
            else
            {
                mostrarMsjIngresoDatos();
            }
        }

        private void limpiarCampos()
        {
            txtMostrarNotaSegUno.Text = "";
            txtMostrarNotaExamUno.Text = "";
            txtMostrarNotaParcialDos.Text = "";
            txtMostrarNotaSegDos.Text = "";
            txtMostrarNotaExamDos.Text = "";
            txtMostrarNotaParcialUno.Text = "";
            txtMostrarNotaParcialDos.Text = "";
        }

        private async void btnSalir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new viewLogin());
        }
    }
}
