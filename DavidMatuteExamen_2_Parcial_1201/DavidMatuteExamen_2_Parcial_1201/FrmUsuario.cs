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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "" || txt_Usuario.Text!="dmatute")
            {
                errorProvider1.SetError(txt_Usuario, "Campo obligatorio, Ingrese un Usuario o verifique su nombre de Usuario");
                txt_Usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_Usuario, " ");

            if (txt_Contrasenia.Text == " " || txt_Contrasenia.Text != "1914reyna".ToString())
            {
                errorProvider1.SetError(txt_Contrasenia, "Campo obligatorio, Contraseña incorrecta!!!, Ingrese su contraseña correcta");
                return;
            }
            errorProvider1.SetError(txt_Contrasenia, " ");

            FrmPrincipal Formulario = new FrmPrincipal();
            this.Hide();
            Formulario.Show();

        }
    }
}
