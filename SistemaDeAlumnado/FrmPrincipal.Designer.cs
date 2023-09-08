namespace SistemaDeAlumnado
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.BtnAlumnos = new FontAwesome.Sharp.IconButton();
            this.btnMaterias = new FontAwesome.Sharp.IconButton();
            this.btnAsignaciones = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Tomato;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.HouseFlag;
            this.BtnInicio.IconColor = System.Drawing.Color.Silver;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInicio.Location = new System.Drawing.Point(12, 238);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(122, 82);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Regresar a Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.BackColor = System.Drawing.Color.Snow;
            this.BtnAlumnos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumnos.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtnAlumnos.IconColor = System.Drawing.Color.IndianRed;
            this.BtnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlumnos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAlumnos.Location = new System.Drawing.Point(249, 12);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(168, 82);
            this.BtnAlumnos.TabIndex = 1;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAlumnos.UseVisualStyleBackColor = false;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.Snow;
            this.btnMaterias.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMaterias.IconColor = System.Drawing.Color.DarkOrange;
            this.btnMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterias.Location = new System.Drawing.Point(25, 12);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(168, 82);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.BackColor = System.Drawing.Color.Snow;
            this.btnAsignaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.IconChar = FontAwesome.Sharp.IconChar.University;
            this.btnAsignaciones.IconColor = System.Drawing.Color.Gray;
            this.btnAsignaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignaciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsignaciones.Location = new System.Drawing.Point(457, 12);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(164, 82);
            this.btnAsignaciones.TabIndex = 3;
            this.btnAsignaciones.Text = "Asignaciones";
            this.btnAsignaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAsignaciones.UseVisualStyleBackColor = false;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(656, 332);
            this.Controls.Add(this.btnAsignaciones);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnAlumnos;
        private FontAwesome.Sharp.IconButton btnMaterias;
        private FontAwesome.Sharp.IconButton btnAsignaciones;
    }
}