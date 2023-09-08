namespace SistemaDeAlumnado
{
    partial class FrmMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterias));
            this.BtnRegresar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarMateria = new FontAwesome.Sharp.IconButton();
            this.TxtMateriaBuscar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnInsertar = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.BtnBorrar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdMateria = new System.Windows.Forms.TextBox();
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
            this.BtnRegresar.Location = new System.Drawing.Point(28, 360);
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
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registros de Materias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materias});
            this.dataGridView1.Location = new System.Drawing.Point(236, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 247);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Materias
            // 
            this.Materias.HeaderText = "Materias";
            this.Materias.Name = "Materias";
            this.Materias.ReadOnly = true;
            // 
            // BtnBuscarMateria
            // 
            this.BtnBuscarMateria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBuscarMateria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarMateria.IconChar = FontAwesome.Sharp.IconChar.List;
            this.BtnBuscarMateria.IconColor = System.Drawing.Color.SaddleBrown;
            this.BtnBuscarMateria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarMateria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarMateria.Location = new System.Drawing.Point(738, 16);
            this.BtnBuscarMateria.Name = "BtnBuscarMateria";
            this.BtnBuscarMateria.Size = new System.Drawing.Size(140, 71);
            this.BtnBuscarMateria.TabIndex = 6;
            this.BtnBuscarMateria.Text = "Buscar Materia";
            this.BtnBuscarMateria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarMateria.UseVisualStyleBackColor = false;
            this.BtnBuscarMateria.Click += new System.EventHandler(this.BtnBuscarMateria_Click);
            // 
            // TxtMateriaBuscar
            // 
            this.TxtMateriaBuscar.Location = new System.Drawing.Point(477, 35);
            this.TxtMateriaBuscar.Name = "TxtMateriaBuscar";
            this.TxtMateriaBuscar.Size = new System.Drawing.Size(240, 20);
            this.TxtMateriaBuscar.TabIndex = 5;
            this.TxtMateriaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreBuscar_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.StarHalf;
            this.BtnEliminar.IconColor = System.Drawing.Color.OrangeRed;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(270, 190);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(154, 71);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar Materia";
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
            this.BtnInsertar.Location = new System.Drawing.Point(449, 190);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(144, 71);
            this.BtnInsertar.TabIndex = 8;
            this.BtnInsertar.Text = "Insertar Materia";
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
            this.BtnActualizar.Location = new System.Drawing.Point(619, 190);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(152, 71);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnBorrar.IconColor = System.Drawing.Color.DeepPink;
            this.BtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.Location = new System.Drawing.Point(54, 248);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(152, 71);
            this.BtnBorrar.TabIndex = 10;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresa Materia:";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(50, 147);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(240, 20);
            this.TxtMateria.TabIndex = 12;
            this.TxtMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMateria_KeyPress);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Materia";
            // 
            // TxtIdMateria
            // 
            this.TxtIdMateria.Location = new System.Drawing.Point(69, 91);
            this.TxtIdMateria.Name = "TxtIdMateria";
            this.TxtIdMateria.Size = new System.Drawing.Size(101, 20);
            this.TxtIdMateria.TabIndex = 14;
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1027, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscarMateria);
            this.Controls.Add(this.TxtMateriaBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMaterias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materias;
        private FontAwesome.Sharp.IconButton BtnBuscarMateria;
        private System.Windows.Forms.TextBox TxtMateriaBuscar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnInsertar;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private FontAwesome.Sharp.IconButton BtnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdMateria;
    }
}