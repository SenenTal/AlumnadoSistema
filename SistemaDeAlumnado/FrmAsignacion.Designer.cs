namespace SistemaDeAlumnado
{
    partial class FrmAsignacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacion));
            this.BtnRegresar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Asignaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarNombre = new FontAwesome.Sharp.IconButton();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.BtnBorrar = new FontAwesome.Sharp.IconButton();
            this.BtnInsertar = new FontAwesome.Sharp.IconButton();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.LabelMateria = new System.Windows.Forms.Label();
            this.LabelAlumno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Maroon;
            this.BtnRegresar.IconChar = FontAwesome.Sharp.IconChar.School;
            this.BtnRegresar.IconColor = System.Drawing.Color.Khaki;
            this.BtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegresar.Location = new System.Drawing.Point(26, 360);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(142, 78);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar ";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventana para asignar a los alumnos sus materias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignaciones});
            this.dataGridView1.Location = new System.Drawing.Point(363, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // Asignaciones
            // 
            this.Asignaciones.HeaderText = "Asignaciones";
            this.Asignaciones.Name = "Asignaciones";
            this.Asignaciones.ReadOnly = true;
            // 
            // BtnBuscarNombre
            // 
            this.BtnBuscarNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBuscarNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarNombre.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.BtnBuscarNombre.IconColor = System.Drawing.Color.SaddleBrown;
            this.BtnBuscarNombre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarNombre.Location = new System.Drawing.Point(835, 51);
            this.BtnBuscarNombre.Name = "BtnBuscarNombre";
            this.BtnBuscarNombre.Size = new System.Drawing.Size(140, 71);
            this.BtnBuscarNombre.TabIndex = 6;
            this.BtnBuscarNombre.Text = "Buscar Nombre";
            this.BtnBuscarNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarNombre.UseVisualStyleBackColor = false;
            this.BtnBuscarNombre.Click += new System.EventHandler(this.BtnBuscarNombre_Click);
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Location = new System.Drawing.Point(574, 70);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(240, 20);
            this.TxtNombreBuscar.TabIndex = 5;
            this.TxtNombreBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escriba 1 nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asignar Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Asignar Alumno:";
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(26, 117);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(165, 21);
            this.cbMateria.TabIndex = 11;
            this.cbMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMateria_KeyPress);
            // 
            // cbAlumno
            // 
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(256, 117);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(165, 21);
            this.cbAlumno.TabIndex = 12;
            this.cbAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlumno_KeyPress);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnBorrar.IconColor = System.Drawing.Color.DeepPink;
            this.BtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.Location = new System.Drawing.Point(662, 96);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(152, 71);
            this.BtnBorrar.TabIndex = 20;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.IconChar = FontAwesome.Sharp.IconChar.LaughBeam;
            this.BtnInsertar.IconColor = System.Drawing.Color.SeaShell;
            this.BtnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInsertar.Location = new System.Drawing.Point(26, 158);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(144, 71);
            this.BtnInsertar.TabIndex = 22;
            this.BtnInsertar.Text = "Asignar Materia";
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // LabelMateria
            // 
            this.LabelMateria.AutoSize = true;
            this.LabelMateria.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMateria.Location = new System.Drawing.Point(23, 54);
            this.LabelMateria.Name = "LabelMateria";
            this.LabelMateria.Size = new System.Drawing.Size(111, 20);
            this.LabelMateria.TabIndex = 23;
            this.LabelMateria.Text = "ID de Materia:";
            // 
            // LabelAlumno
            // 
            this.LabelAlumno.AutoSize = true;
            this.LabelAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlumno.Location = new System.Drawing.Point(253, 54);
            this.LabelAlumno.Name = "LabelAlumno";
            this.LabelAlumno.Size = new System.Drawing.Size(116, 20);
            this.LabelAlumno.TabIndex = 24;
            this.LabelAlumno.Text = "ID del Alumno:";
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.LabelAlumno);
            this.Controls.Add(this.LabelMateria);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscarNombre);
            this.Controls.Add(this.TxtNombreBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAsignacion";
            this.Text = "Asignacion de Materias";
            this.Load += new System.EventHandler(this.FrmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaciones;
        private FontAwesome.Sharp.IconButton BtnBuscarNombre;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbAlumno;
        private FontAwesome.Sharp.IconButton BtnBorrar;
        private FontAwesome.Sharp.IconButton BtnInsertar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label LabelAlumno;
        private System.Windows.Forms.Label LabelMateria;
    }
}