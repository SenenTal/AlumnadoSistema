namespace SistemaDeAlumnado
{
    partial class FrmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnos));
            this.BtnRegresar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarNombre = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBorrar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnInsertar = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnActivar = new FontAwesome.Sharp.IconButton();
            this.BtnDesactivar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdAlumno = new System.Windows.Forms.TextBox();
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
            this.BtnRegresar.Location = new System.Drawing.Point(31, 412);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(142, 78);
            this.BtnRegresar.TabIndex = 0;
            this.BtnRegresar.Text = "Regresar ";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumnos});
            this.dataGridView1.Location = new System.Drawing.Point(252, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 317);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Alumnos
            // 
            this.Alumnos.HeaderText = "Alumnos";
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros de Alumnos";
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Location = new System.Drawing.Point(429, 110);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(240, 20);
            this.TxtNombreBuscar.TabIndex = 3;
            this.TxtNombreBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreBuscar_KeyPress);
            // 
            // BtnBuscarNombre
            // 
            this.BtnBuscarNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBuscarNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarNombre.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.BtnBuscarNombre.IconColor = System.Drawing.Color.SaddleBrown;
            this.BtnBuscarNombre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarNombre.Location = new System.Drawing.Point(675, 80);
            this.BtnBuscarNombre.Name = "BtnBuscarNombre";
            this.BtnBuscarNombre.Size = new System.Drawing.Size(140, 71);
            this.BtnBuscarNombre.TabIndex = 4;
            this.BtnBuscarNombre.Text = "Buscar Nombre";
            this.BtnBuscarNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarNombre.UseVisualStyleBackColor = false;
            this.BtnBuscarNombre.Click += new System.EventHandler(this.BtnBuscarNombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingresa Alumno:";
            // 
            // TxtAlumno
            // 
            this.TxtAlumno.Location = new System.Drawing.Point(49, 147);
            this.TxtAlumno.Name = "TxtAlumno";
            this.TxtAlumno.Size = new System.Drawing.Size(240, 20);
            this.TxtAlumno.TabIndex = 16;
            this.TxtAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAlumno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar Alumno:";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnBorrar.IconColor = System.Drawing.Color.DeepPink;
            this.BtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.Location = new System.Drawing.Point(31, 262);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(152, 71);
            this.BtnBorrar.TabIndex = 19;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.StarHalf;
            this.BtnEliminar.IconColor = System.Drawing.Color.OrangeRed;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(208, 198);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(154, 71);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar Alumno";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.BtnInsertar.IconColor = System.Drawing.Color.SeaShell;
            this.BtnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInsertar.Location = new System.Drawing.Point(401, 198);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(144, 71);
            this.BtnInsertar.TabIndex = 21;
            this.BtnInsertar.Text = "Insertar Alumno";
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.BtnActualizar.IconColor = System.Drawing.Color.Gold;
            this.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActualizar.Location = new System.Drawing.Point(585, 198);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(152, 71);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BtnActivar
            // 
            this.BtnActivar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnActivar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivar.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.BtnActivar.IconColor = System.Drawing.Color.DarkSlateGray;
            this.BtnActivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActivar.Location = new System.Drawing.Point(769, 198);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(152, 71);
            this.BtnActivar.TabIndex = 23;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnActivar.UseVisualStyleBackColor = false;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDesactivar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesactivar.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.BtnDesactivar.IconColor = System.Drawing.Color.Crimson;
            this.BtnDesactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDesactivar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDesactivar.Location = new System.Drawing.Point(945, 198);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(152, 71);
            this.BtnDesactivar.TabIndex = 24;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDesactivar.UseVisualStyleBackColor = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID Alumno";
            // 
            // TxtIdAlumno
            // 
            this.TxtIdAlumno.Location = new System.Drawing.Point(56, 93);
            this.TxtIdAlumno.Name = "TxtIdAlumno";
            this.TxtIdAlumno.Size = new System.Drawing.Size(117, 20);
            this.TxtIdAlumno.TabIndex = 25;
            this.TxtIdAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1121, 604);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdAlumno);
            this.Controls.Add(this.BtnDesactivar);
            this.Controls.Add(this.BtnActivar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAlumno);
            this.Controls.Add(this.BtnBuscarNombre);
            this.Controls.Add(this.TxtNombreBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumnos;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscarNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAlumno;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnBorrar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnInsertar;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private FontAwesome.Sharp.IconButton BtnDesactivar;
        private FontAwesome.Sharp.IconButton BtnActivar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdAlumno;
    }
}