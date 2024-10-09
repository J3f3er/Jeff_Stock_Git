using JeffStock.FormAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeffStock
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("No puede dejar el nombre Vacio", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if(passwordName.Text == "")
            {
                MessageBox.Show("No puede dejar el password Vacio", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (userName.Text == "Jeff" && passwordName.Text == "Jeff")
            {
                MessageBox.Show($"Usuario Correcto {userName.Text} Clave: {passwordName.Text} Exito!!!");
                
                this.Close();
            }
            else if (userName.Text == "jeff" && passwordName.Text == "jeff") 
            {
                MessageBox.Show($"Usuario Correcto {userName.Text} Clave: {passwordName.Text} Exito!!!");
            }
            else
            {
                MessageBox.Show($"Usuario Incorrecto {userName.Text} no existe");
            }
        }
    }
}
