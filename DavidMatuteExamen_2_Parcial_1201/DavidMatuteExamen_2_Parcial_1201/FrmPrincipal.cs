using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidMatuteExamen_2_Parcial_1201
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txt_Nombre_Cl.Focus();
        }

        List<Clientes> clientesLista = new List<Clientes>();

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre_Cl.Clear();
            
            txt_Direccion_Cl.Clear();
            txt_Nomb_Medicamento.Clear();
            txt_Tipo_Medicamento.Clear();
            txt_Presentacion.Clear();
            txt_Cantidad.Clear();
            txt_Precio_Medicamento.Clear();
            txt_Subtotal.Clear();
            txt_Descuento.Clear();
            txt_Total_Pagar.Clear();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //VALIDACION DE TEXTBOX           
            validacion();
            
        }

        private void validacion()
        {
            if (txt_Nombre_Cl.Text == "")
            {
                               
                PrincipalerrorProvider.SetError(txt_Nombre_Cl, "Campos obligatorios, Ingrese el nombre del cliente");
                txt_Nombre_Cl.Focus();
                return;

            }
            PrincipalerrorProvider.SetError(txt_Nombre_Cl, "");

            if (txt_Nomb_Medicamento.Text == "")
            {

                errorProvider1.SetError(txt_Nomb_Medicamento, "Campo obligatorio, Ingrese su nombre del medicamento");
                //txt_Nomb_Medicamento.Focus();
                return;

            }
            errorProvider1.SetError(txt_Nomb_Medicamento, "");

            if (txt_Tipo_Medicamento.Text == "")
            {

                errorProvider2.SetError(txt_Tipo_Medicamento, "Campo obligatorio, Ingrese el tipo de medicamento");
                //txt_Tipo_Medicamento.Focus();
                return;

            }
            errorProvider2.SetError(txt_Tipo_Medicamento, "");

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
          
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult respuesta = MessageBox.Show("Desea confirmar la cancelación de la compra", "Confirmación de venta",
                            botones, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {

                Clientes clientes = new Clientes(txt_Nombre_Cl.Text, txt_Direccion_Cl.Text,
                txt_Nomb_Medicamento.Text, txt_Tipo_Medicamento.Text,
                txt_Presentacion.Text, Convert.ToInt32(txt_Cantidad.Text),
                Convert.ToInt32(txt_Precio_Medicamento.Text));                

                txt_Subtotal.Text = (Convert.ToInt32(txt_Precio_Medicamento.Text) * Convert.ToInt32(txt_Cantidad.Text)).ToString();
                txt_Descuento.Text = (Convert.ToInt32(txt_Subtotal.Text) * 0.10).ToString();
                txt_Total_Pagar.Text = (Convert.ToDouble(txt_Subtotal.Text) - Convert.ToDouble(txt_Descuento.Text)).ToString();


                clientesLista.Add(clientes);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientesLista;

            }
            else
            {
                txt_Nombre_Cl.Clear();
                txt_Direccion_Cl.Clear();
                txt_Nomb_Medicamento.Clear();
                txt_Tipo_Medicamento.Clear();
                txt_Presentacion.Clear();
                txt_Cantidad.Clear();
                txt_Precio_Medicamento.Clear();
                txt_Subtotal.Clear();
                txt_Descuento.Clear();
                txt_Total_Pagar.Clear();
            }

        }
    }
}
