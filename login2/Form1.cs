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

        private void Registrar_Click(object sender, EventArgs e)
        {
            string username = Nombre.Text;
            string password = Contrasena.Text;

            // Verifica si los campos están vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            
            MessageBox.Show("¡Registro exitoso!");
           
        }
    }
    }

