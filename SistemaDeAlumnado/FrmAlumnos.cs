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
using CapaNegocio;

namespace SistemaDeAlumnado
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = CN_Alumnos.ListarAlumnos();
                this.Formato();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Método Formato
        private void Formato()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Id";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].HeaderText = "Nombre del Alumno";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Fecha de registro";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "Estado";
            dataGridView1.Columns[4].Width = 50;
        }
        //Método del Botón Regresar para volver al Formulario Principal
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal P = new FrmPrincipal();
            P.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }

        //Método para cargar métodos en el Fromulario de Alumnos
        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            //Este método realiza la carga de los registros en el dataGridView1
            this.Listar();
            TxtIdAlumno.ReadOnly = true;
            TxtIdAlumno.Enabled = false;
        }
        //Método Buscar para buscar nombre en los registros de Alumnos
        private void Buscar()
        {
            try
            {
                dataGridView1.DataSource = CN_Alumnos.BuscarAlumnos(TxtNombreBuscar.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Método para generar la busqueda al dar click al Botón
        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        //Método que solo acepta Letras en TextBox
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

        //Método para la entrada de teclas en Txt
        private void TxtAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloLetras(e);
        }

        private void TxtNombreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloLetras(e);
        }

        //Método para limpiar TextBox
        private void Limpiar()
        {
            TxtAlumno.Clear();
            TxtNombreBuscar.Clear();
            TxtIdAlumno.Clear();
        }
        //Método Mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Método de Mensaje de aprobación
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(TxtAlumno.Text == string.Empty)
                {
                    this.MensajeError("Ingrese un nombre, porfavor");
                    ErrorIcono.SetError(TxtAlumno, "Ingresar un nombre");
                }
                else
                {
                    Rpta = CN_Alumnos.InsertarAlumno(TxtAlumno.Text.Trim());
                    if(Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se inserto un nuevo alumno");
                        this.Limpiar();
                        this.Listar();
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            ErrorIcono.SetError(TxtIdAlumno, "");
            ErrorIcono.SetError(TxtAlumno, "");
        }
        //Método que asigna al dar clic a una celda del dataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            //Nota: lo estamos convirtiendo en string para el TextBox
            TxtIdAlumno.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            TxtAlumno.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(TxtAlumno.Text == string.Empty || TxtIdAlumno.Text==string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtIdAlumno, "Como el Id");
                    ErrorIcono.SetError(TxtAlumno, "Como Nombre del alumno");
                }
                else
                {
                    Rpta = CN_Alumnos.ActualizarAlumno((Convert.ToInt32(TxtIdAlumno.Text.Trim())), TxtAlumno.Text.Trim());
                    if(Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizo de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta;
                if (TxtAlumno.Text == string.Empty || TxtIdAlumno.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtIdAlumno, "Como el Id");
                    ErrorIcono.SetError(TxtAlumno, "Como Nombre del alumno");
                }
                else
                {
                    Rpta = CN_Alumnos.EliminarAlumno(Convert.ToInt32(TxtIdAlumno.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se elimino alumno");
                        this.Limpiar();
                        this.Listar();
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
//------------------------------------------------------------------------------------------------------------
        //Eventos para Activar y Desactivar al Alumno

        //Evento para desactivar con el botón BtnDesactivar al Alumno
        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(TxtAlumno.Text == string.Empty || TxtIdAlumno.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtIdAlumno, "Como el Id");
                    ErrorIcono.SetError(TxtAlumno, "Como Nombre del alumno");
                }
                else
                {
                    Rpta = CN_Alumnos.BajaAlumno(Convert.ToInt32(TxtIdAlumno.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se dio de baja al alumno " + TxtAlumno.Text);
                        this.Limpiar();
                        this.Listar();
                        ErrorIcono.SetError(TxtIdAlumno, "");
                        ErrorIcono.SetError(TxtAlumno, "");
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

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtAlumno.Text == string.Empty || TxtIdAlumno.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtIdAlumno, "Como el Id");
                    ErrorIcono.SetError(TxtAlumno, "Como Nombre del alumno");
                }
                else
                {
                    Rpta = CN_Alumnos.AltaAlumno(Convert.ToInt32(TxtIdAlumno.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se dio de alta al alumno " + TxtAlumno.Text);
                        this.Limpiar();
                        this.Listar();
                        ErrorIcono.SetError(TxtIdAlumno, "");
                        ErrorIcono.SetError(TxtAlumno, "");
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
