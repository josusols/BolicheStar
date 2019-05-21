//Librerias.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BolicheStar
{
    public partial class ChuzaTiroExtra : Form
    {
        public ChuzaTiroExtra()
        {
            InitializeComponent();
        }

        //Variable que almacena lo que se ingreso en el TextBox "TB_tirarExtra".
        public int tiroEx;

        //Verifica si el TextBox no esta vacio para activar el botón.
        private void TB_tirarExtra_TextChanged(object sender, EventArgs e)
        {
            if (TB_tirarExtra.Text != "")
            {
                BTN_tirarExtra.Enabled = true;
            }
            else
            {
                BTN_tirarExtra.Enabled = false;
            }
        }

        //Hace la acción del botón "BTN_tirarExtra" si presiona "Enter" en el TextBox "TB_tirarExtra".
        private void TB_tirarExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BTN_tirarExtra_Click(sender, e);
            }
        }

        //Bóton que guarda el valor del TextBox en la variable "tiroEx".
        private void BTN_tirarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TB_tirarExtra.Text) <= 10) //Verifica que el número ingresado sea menor o igual a 10.
                {
                    tiroEx = Convert.ToInt32(TB_tirarExtra.Text); //Guarda en la variable.
                    TB_tirarExtra.Text = ""; //Limpia el TextBox.
                    this.Close(); //Cierra el Form.
                }
                else
                {
                    MessageBox.Show("¡El máximo número de pines que puedes derrivar son 10!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("¡Ingresa una cantidad valida!", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
