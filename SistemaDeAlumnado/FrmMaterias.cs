using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using CapaNegocio;

namespace SistemaDeAlumnado
{
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = CN_Materias.ListarMaterias();
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Método para formar los registros y luego asignarlo en el método Listar
        private void Formato()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Id Materia";
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].HeaderText = "Materia";
            dataGridView1.Columns[2].Width = 190;
        }
        //Método para cargar los registros al seleccionar la ventana FrmMaterias
        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            this.Listar();
            TxtIdMateria.ReadOnly = true;
            TxtIdMateria.Enabled = false;
        }
        //Evento Click del botón Regresar
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal P = new FrmPrincipal();
            P.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }
        //Evento Buscar
        private void Buscar()
        {
            try
            {
                dataGridView1.DataSource = CN_Materias.BuscarMaterias(TxtMateriaBuscar.Text);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //Evento Click del botón Buscar Nombre
        private void BtnBuscarMateria_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        //Método para vaciar los TextBox en este formulario (FrmMaterias)
        private void Limpiar()
        {
            TxtMateriaBuscar.Clear();
            TxtMateria.Clear();
            TxtIdMateria.Clear();
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            ErrorIcono.SetError(TxtIdMateria, "");
            ErrorIcono.SetError(TxtMateria, "");
        }
        //Método para validar solo letras en el TextBox
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
        //Método de Mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método de Mensaje de Ok
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Método para programar las teclas de entrada en TxtMateria
        private void TxtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloLetras(e);
        }
        //Método para programar las teclas de entrada de TxtNombreBuscar
        private void TxtNombreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloLetras(e);
        }
        //Método para seleccionar las filas dentro del dataGridView1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            TxtIdMateria.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            TxtMateria.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }
        //Método para el Botón Insertar Materia
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtMateria.Text == string.Empty)
                {
                    this.MensajeError("Escriba una materia, porfavor");
                    ErrorIcono.SetError(TxtMateria, "Ingresar materia nueva");
                }
                else
                {
                    Rpta = CN_Materias.InsertarMateria(TxtMateria.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se ingreso una nueva materia");
                        this.Limpiar();
                        this.Listar();
                        ErrorIcono.SetError(TxtIdMateria, "");
                        ErrorIcono.SetError(TxtMateria, "");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta;
                if (TxtMateria.Text == string.Empty || TxtIdMateria.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtIdMateria, "Como el Id");
                    ErrorIcono.SetError(TxtMateria, "Como titulo de la materia");
                }
                else
                {
                    Rpta = CN_Materias.EliminaMateria(Convert.ToInt32(TxtIdMateria.Text.Trim()));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se elimino materia");
                        this.Limpiar();
                        this.Listar();
                        ErrorIcono.SetError(TxtIdMateria, "");
                        ErrorIcono.SetError(TxtMateria, "");
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtMateria.Text == string.Empty || TxtIdMateria.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos");
                    ErrorIcono.SetError(TxtMateria, "Como el Id");
                    ErrorIcono.SetError(TxtMateria, "Como Nombre del alumno");
                }
                else
                {
                    Rpta = CN_Materias.ActualizarMateria((Convert.ToInt32(TxtIdMateria.Text.Trim())), TxtMateria.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizo de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                        ErrorIcono.SetError(TxtIdMateria, "");
                        ErrorIcono.SetError(TxtMateria, "");
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

    
