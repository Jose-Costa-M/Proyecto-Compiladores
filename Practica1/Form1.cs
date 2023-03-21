using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;


        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormBasico(),sender); 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUnir(),sender);
        }



        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConcatenar(), sender);

        }

        private void btnCerradura_Positiva_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormPositiva(), sender);

        }

        private void btnCerradura_Klene_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKlene(), sender);

        }

        private void btnOpcional_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOpcion(), sender);
        }

        private void btnER_AFND_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormER(), sender);

        }

        private void btnAnalizador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUAnalizador_Lexico(), sender);

        }

        private void btnAFND_AFD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAFND_AFD(), sender);

        }

        private void btnAnaliza_Cadena_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAnalizador(), sender);

        }

        private void btnProbar_AL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProbarAL(), sender);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        //methods
         private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex ==  index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null){
               if(currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        } 
       
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(36, 0, 71);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDektopPanel.Controls.Add(childForm);
            this.panelDektopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle.Text = childForm.Text;

        }

    }
}
