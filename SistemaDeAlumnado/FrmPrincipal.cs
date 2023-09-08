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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Inicio A = new Inicio();
            A.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos C = new FrmAlumnos();
            C.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias M = new FrmMaterias();
            M.Show();
            this.Hide(); 
            this.Close();
            this.Dispose();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            FrmAsignacion P = new FrmAsignacion();
            P.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }
    }
}
