using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        public static string password;
        private void button1_Click(object sender, EventArgs e)
        {
            username = entradaUsuario.Text;
            password = contrasenaLogin.Text;
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful");
              
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }   
    }
}
