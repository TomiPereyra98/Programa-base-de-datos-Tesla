using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Tesla : Form
    {
        //Acá cree la lista principal en base a la clase vehiculos
        List <Vehiculos> ListaPrincipal = new List <Vehiculos> ();
        public bool UService { get; private set; }

        public Tesla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
        //Crear menu en bucle
        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidadTesla() == false)
            {
                return;
            }
            if (ValidadModelo() == false)
            {
                return;
            }

            if (ValidarDueño() == false)
            {
                return;
            }
            if (ValidarColor() == false)
            {
                return;
            }
            if (ValidarAño() == false)
            {
                return;
            }            
            if (ValidarKmtActual() == false)
            {
                return;
            }
            
            
            //Creamos el objeto de la lista
            Vehiculos ListaDatos = new Vehiculos();
            ListaDatos.Dueño = txtDueño.Text;
            ListaDatos.Color = txtColor.Text;
            ListaDatos.Año = int.Parse(txtAño.Text);
            ListaDatos.KmtsActual = int.Parse(txtKmActual.Text);
            ListaDatos.Modelo = BoxModelo.SelectedItem.ToString();
            
            

            if (ListaDatos.Modelo == "X")
            {
                ListaDatos.Autonomia = 560;
                ListaDatos.Asientos = 7;
                ListaDatos.Service = 1000;
                ListaPrincipal.Add(ListaDatos);
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = ListaPrincipal;
                BoxTesla.Focus();                                                      
            }
            if (ListaDatos.Modelo == "S")
            {
                ListaDatos.Autonomia = 650;
                ListaDatos.Asientos = 5;
                ListaDatos.Service = 2000;
                ListaPrincipal.Add(ListaDatos);
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = ListaPrincipal;
                BoxTesla.Focus();
            }
            if (ListaDatos.Modelo == "CYBERTRUCK")
            {
                ListaDatos.Autonomia = 800;
                ListaDatos.Asientos = 6;
                ListaDatos.Service = 3000;
                ListaPrincipal.Add(ListaDatos);
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = ListaPrincipal;
                BoxTesla.Focus();
            }
            if (ListaDatos.Modelo == "STARSHIP")
            {
                ListaDatos.Autonomia = 560;
                ListaDatos.Asientos = 7;
                ListaDatos.Service = 1000;
                ListaPrincipal.Add(ListaDatos);
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = ListaPrincipal;
                BoxTesla.Focus();
            }
            if (ListaDatos.Modelo == "FALCON 9")
            {
                ListaDatos.Autonomia = 500;
                ListaDatos.Service = 200;
                ListaPrincipal.Add(ListaDatos);
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = ListaPrincipal;
                BoxTesla.Focus();
            }


        }
        //Metodos
        //Validar el tesla
        private bool ValidadTesla()
        {
            if (string.IsNullOrEmpty(BoxTesla.Text))
            {
                erpError.SetError(BoxTesla, "Debe elegir un vehículo");
                return false;
            }
            else
            {
                erpError.SetError(BoxTesla, "");
                return true;
            }


        }
        //Validar el modelo
        private bool ValidadModelo()
        {
            if (string.IsNullOrEmpty(BoxModelo.Text))
            {
                erpError.SetError(BoxModelo, "Debe elegir un modelo");
                return false;
            }
            else
            {
                erpError.SetError(BoxModelo, "");
                return true;
            }
        }
        //Valido el dueño
        private bool ValidarDueño()
        {
            if (string.IsNullOrEmpty(txtDueño.Text))
            {
                erpError.SetError(txtDueño, "Debe ingresar un nombre del dueño");
                return false;
            }
            else
            {
                erpError.SetError(txtDueño, "");
                return true;
            }

        }
        //Valido el color
        private bool ValidarColor()
        {
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                erpError.SetError(txtColor, "Debe ingresar el color");
                return false;
            }
            else
            {
                erpError.SetError(txtColor, "");
                return true;
            }
        }


        //Valido el año
        private bool ValidarAño()
        {
            int Año;
            if (!int.TryParse(txtAño.Text, out Año) || txtAño.Text == "")
            {
                erpError.SetError(txtAño, "Debe ingresar el año de fabricacion del vehículo");
                txtAño.Clear();
                txtAño.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtAño, "");
                    return true;
            }

        }
       
        //Valido los kilometros
        private bool ValidarKmtActual()
        {
            int KmtsActual;
            if (!int.TryParse(txtKmActual.Text, out KmtsActual) || txtKmActual.Text == "")
            {
                erpError.SetError(txtKmActual, "Debe ingresar los Kmts. actuales");
                txtKmActual.Clear();
                txtKmActual.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtKmActual, "");
                return true;
            }

        }

        private void BotonBorrarLista_Click(object sender, EventArgs e)
        {
         
        }

        /*private void pictureBox2_Click(object sender, EventArgs e)
        {

        }*/

        private void BotonBorrarTodo_Click(object sender, EventArgs e)
        {
            txtDueño.Clear();
            txtAño.Clear();
            txtColor.Clear();
            txtKmActual.Clear();
            BoxModelo.SelectedIndex = 0;
            BoxTesla.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
