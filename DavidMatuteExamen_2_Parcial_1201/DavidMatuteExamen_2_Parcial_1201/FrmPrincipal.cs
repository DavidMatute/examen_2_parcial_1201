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

        }

        List<Clientes> clientesLista = new List<Clientes>();

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre_Cl.Clear();
            txt_Nombre_Cl.Focus();
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
    }
}
