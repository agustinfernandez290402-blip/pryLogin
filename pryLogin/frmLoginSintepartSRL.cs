using SP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryLogin
{
    public partial class frmLoginSintepartSRL : Form
    {
        int intentos = 0;
        // Diccionario para contener usuarios y sus respectivas claves. Sí, bien seguro :D. Después le hasheamos la pass con MD5 y somos la Tamse LOL.
        Dictionary<string, string> usuarios_cargados = new Dictionary<string, string>()
        {
            {"Adm", "@1a"},
            {"John", "*2b" },
            {"Ceci", "*@3c" },
            {"God", "*@#4d" }
        };

        // Diccionario para contener los permisos de cada user.
        Dictionary<string, string[]> permisos_por_usuario = new Dictionary<string, string[]>()
        {
            {"Adm", new string[] {"ADM", "COM", "VTA" } },
            {"John", new string[] {"SIST" } },
            {"Ceci", new string[] {"ADM", "VTA" } },
            {"God", new string[] {"ADM", "SIST", "COM", "VTA" } }
        };
        private void limpiar_campos()
        {
            TxtUsuario.Clear();
            txtContraseña.Clear();
            TxtUsuario.Focus();
        }

        public frmLoginSintepartSRL()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCombo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = TxtUsuario.Text;
            string pass = txtContraseña.Text;

            // Chequeamos en el diccionario de usuarios si está la key del user ingresado en el textbox, si la key existe chequeamos la pass
            // Si la pass es correcta recién ahí chequeamos si el diccionario de permisos contiene el value acorde al permiso ingresado para ese user.
            if (usuarios_cargados.ContainsKey(user) &&
                usuarios_cargados[user] == pass &&
                permisos_por_usuario[user].Contains(cmbCombo.Text))
            {
                // Si el ingreso es correcto limpiamos los campos, el mensaje de error (de haber alguno) y mostramos el otro form en forma de dialog.
                limpiar_campos();
                lblerror.Text = "";
                this.Hide();
                frmInicio f_inicio = new frmInicio();
                f_inicio.Text = user;
                f_inicio.ShowDialog();
                this.Show();
                // intentos = 0; // Reiniciamos el contador. Lo dejo comentado ya que es a discreción del profe :D
            }
            else
            {
                // Caso negativo se agrega 1 al contador de intentos y se muestra un mensaje de error. Al llegar a 2 intentos fallidos se cierra el form.
                limpiar_campos();
                intentos++;
                lblerror.Text = "Usuario y/o contraseña incorrectos para el formulario seleccionado.";
                if (intentos >= 2) this.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

