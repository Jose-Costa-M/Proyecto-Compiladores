using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Forms
{
    public partial class FormBasico : Form
    {
        public FormBasico()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrear_AFND_Click(object sender, EventArgs e)
        {

        }

        private void FormBasico_Load(object sender, EventArgs e)
        {
            //deshabilitamos el boton hasta que se validen los datos
            btnCrear_AFND.Enabled = false;

        }

        private void Caracter_Inf_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }


        private void controlBotones()
        {
            if(Caracter_Inf.Text.Trim() != string.Empty && (Caracter_Inf.Text.All(Char.IsLetter) || Caracter_Inf.Text.All(Char.IsNumber))){

                if (Caracter_Inf.Text.All(Char.IsLetter) && (Caracter_Inf.Text.Length == 1))
                {
                    btnCrear_AFND.Enabled = true;
                    errorProvider1.SetError(Caracter_Inf, "");
                }
                else
                {
                    errorProvider1.SetError(Caracter_Inf, "El caracter inferior no debe de sobrepasar de 1 caracter");
                    btnCrear_AFND.Enabled = false;
                    Caracter_Inf.Focus();
                }

                if (Caracter_Inf.Text.All(Char.IsNumber))
                {
                    btnCrear_AFND.Enabled = true;
                    errorProvider1.SetError(Caracter_Inf, "");
                }

            }
            else
            {
                if (!((Caracter_Inf.Text.All(Char.IsLetter) || Caracter_Inf.Text.All(Char.IsNumber))))
                {
                    errorProvider1.SetError(Caracter_Inf, "El caracter inferior debe de ser una letra o un número");
                }
                else
                {
                    errorProvider1.SetError(Caracter_Inf, "Debe introducir un número o una letra");
                }
                btnCrear_AFND.Enabled = false;
                Caracter_Inf.Focus(); 
            }


        }
    }
}
