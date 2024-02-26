namespace PRACTICA1
{
    partial class frmNombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombre));
            this.btnBoton = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.Location = new System.Drawing.Point(361, 191);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(84, 39);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Boton";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(342, 165);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(345, 246);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombre.Size = new System.Drawing.Size(126, 31);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // frmNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnBoton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Titulo del Formulario";
            this.Load += new System.EventHandler(this.frmNombre_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmNombre_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

