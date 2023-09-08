using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SistemaDeAlumnado
{
    public partial class FrmAsignacion : Form
    {
        public FrmAsignacion()
        {
            InitializeComponent();
        }

        //Método Formato para asignar los registros y ser utilizado
        //para el dataGridView1
        private void Formato()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[1].HeaderText = "Materia Asignada";
            dataGridView1.Columns[2].Width = 190;
            dataGridView1.Columns[2].HeaderText = "Alumno";
        }
        //Método Listar, para enlistar los datos agrupados desde Alumnos
        //y Materias
        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = CN_AsignacionMaterias.SeleccionarMateriasAlumnos();
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal P = new FrmPrincipal();
            P.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }

        //No olvides agregar el método Load para cargar los datos al instante
        private void FrmAsignacion_Load(object sender, EventArgs e)
        {
            this.Listar();
            cbAlumno.DataSource = CN_AsignacionMaterias.SeleccionarIdAlumno();
            cbMateria.DataSource = CN_AsignacionMaterias.SeleccionarIdMateria();
            cbAlumno.DisplayMember = "IdAlumno";
            cbMateria.DisplayMember = "IdMateria";
            cbAlumno.Text = String.Empty;
            cbMateria.Text = String.Empty;
            
        }
        private void Buscar()
        {
            try
            {
                dataGridView1.DataSource = CN_AsignacionMaterias.BuscarAsignacion(TxtNombreBuscar.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Busca los registros en el TextBox una vez selecciones el Botón Buscar nombre
        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void SoloLetras(KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 129) || (e.KeyChar >= 131 && e.KeyChar <= 159) || (e.KeyChar >= 164 && e.KeyChar <= 238) || (e.KeyChar >= 240 && e.KeyChar <= 255))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void BloquearTeclas(KeyPressEventArgs e)
        {
            if (!(e.KeyChar>=1 && e.KeyChar<=255))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TxtNombreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloLetras(e);
        }
        //Método para el mensaje de Ok
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Asignacion Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Método para Mostrar error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Asignacion Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Se bloquean las teclas para los comboBox
        private void cbAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.BloquearTeclas(e);
        }

        private void cbMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.BloquearTeclas(e);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtNombreBuscar.Text = string.Empty;
            cbAlumno.Text = string.Empty;
            cbMateria.Text = string.Empty;
            ErrorIcono.SetError(cbMateria, "");
            ErrorIcono.SetError(cbAlumno, "");
        }

         private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (cbAlumno.Text == String.Empty || cbMateria.Text == String.Empty)
                {
                    ErrorIcono.SetError(cbAlumno, "Seleccione un Id");
                    ErrorIcono.SetError(cbMateria, "Seleccione un Id");
                }
                else
                {
                    Rpta = CN_AsignacionMaterias.MateriaNueva((Convert.ToInt32(cbAlumno.Text.Trim())), (Convert.ToInt32(cbMateria.Text.Trim())));
                    if(Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se realizo la asignación");
                        this.Listar();
                        cbAlumno.Text = string.Empty;
                        cbMateria.Text = string.Empty;
                        TxtNombreBuscar.Text = string.Empty;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
