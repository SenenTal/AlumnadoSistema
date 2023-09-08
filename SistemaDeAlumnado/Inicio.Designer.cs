namespace SistemaDeAlumnado
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnAcceso = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.BackColor = System.Drawing.Color.IndianRed;
            this.BtnAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcceso.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAcceso.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.BtnAcceso.IconColor = System.Drawing.Color.Black;
            this.BtnAcceso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAcceso.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAcceso.Location = new System.Drawing.Point(357, 71);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(163, 77);
            this.BtnAcceso.TabIndex = 0;
            this.BtnAcceso.Text = "Acceso al Sistema";
            this.BtnAcceso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAcceso.UseVisualStyleBackColor = false;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Orange;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnCerrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrar.Location = new System.Drawing.Point(81, 71);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(163, 73);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar Sistema";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 251);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAcceso);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Sistema de Gestor de Alumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAcceso;
        private FontAwesome.Sharp.IconButton BtnCerrar;
    }
}

