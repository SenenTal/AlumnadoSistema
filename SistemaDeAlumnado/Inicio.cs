using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlumnado
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas cerrar?", "Sistema de Alumnado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Nota: Segun el boton que oprimamos, el resultado en Opcion
            //se indicara 
            if (Opcion == DialogResult.OK)
            { //Recuerda: se utiliza "=="
                Application.Exit();
            }
        }

        private void BtnAcceso_Click(object sender, EventArgs e)
        { 
            FrmPrincipal For = new FrmPrincipal();
            For.Show();
            this.Hide();
        }
    }
}
