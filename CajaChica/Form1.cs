using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaChica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ModeloBD.CajaChicaEntities db= new ModeloBD.CajaChicaEntities()) {

                var u = from d in db.Usuario
                        where d.email == textBox2.Text && d.UsuarioPassword == textBox1.Text select d;

                if (u.Count() > 0) {
                    

                    this.Hide();
                    CajaForm2 frm = new CajaForm2();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();
                  

                }
                else
                    MessageBox.Show("Usuario inexistente");

            }
        }
    }
}
