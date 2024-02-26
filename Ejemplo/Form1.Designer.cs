namespace Ejemplo
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvTexto = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechanacimiento = new System.Windows.Forms.Label();
            this.lblnumeroFavorito = new System.Windows.Forms.Label();
            this.nudnumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.dtpfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbldondeVive = new System.Windows.Forms.Label();
            this.cbodondeVive = new System.Windows.Forms.ComboBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.btnVerperfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(156, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 444);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvTexto
            // 
            this.lvTexto.HideSelection = false;
            this.lvTexto.Location = new System.Drawing.Point(66, 341);
            this.lvTexto.Name = "lvTexto";
            this.lvTexto.Size = new System.Drawing.Size(316, 88);
            this.lvTexto.TabIndex = 2;
            this.lvTexto.UseCompatibleStateImageBehavior = false;
            this.lvTexto.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechanacimiento
            // 
            this.lblFechanacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechanacimiento.AutoSize = true;
            this.lblFechanacimiento.Location = new System.Drawing.Point(23, 169);
            this.lblFechanacimiento.Name = "lblFechanacimiento";
            this.lblFechanacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechanacimiento.TabIndex = 4;
            this.lblFechanacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblnumeroFavorito
            // 
            this.lblnumeroFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnumeroFavorito.AutoSize = true;
            this.lblnumeroFavorito.Location = new System.Drawing.Point(47, 204);
            this.lblnumeroFavorito.Name = "lblnumeroFavorito";
            this.lblnumeroFavorito.Size = new System.Drawing.Size(85, 13);
            this.lblnumeroFavorito.TabIndex = 6;
            this.lblnumeroFavorito.Text = "Numero favorito:";
            // 
            // nudnumeroFavorito
            // 
            this.nudnumeroFavorito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudnumeroFavorito.Location = new System.Drawing.Point(156, 197);
            this.nudnumeroFavorito.Name = "nudnumeroFavorito";
            this.nudnumeroFavorito.Size = new System.Drawing.Size(248, 20);
            this.nudnumeroFavorito.TabIndex = 3;
            // 
            // dtpfechaNacimiento
            // 
            this.dtpfechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpfechaNacimiento.Location = new System.Drawing.Point(156, 162);
            this.dtpfechaNacimiento.Name = "dtpfechaNacimiento";
            this.dtpfechaNacimiento.Size = new System.Drawing.Size(248, 20);
            this.dtpfechaNacimiento.TabIndex = 2;
            // 
            // lbldondeVive
            // 
            this.lbldondeVive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldondeVive.AutoSize = true;
            this.lbldondeVive.Location = new System.Drawing.Point(63, 236);
            this.lbldondeVive.Name = "lbldondeVive";
            this.lbldondeVive.Size = new System.Drawing.Size(69, 13);
            this.lbldondeVive.TabIndex = 10;
            this.lbldondeVive.Text = "Donde vivis?";
            // 
            // cbodondeVive
            // 
            this.cbodondeVive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbodondeVive.FormattingEnabled = true;
            this.cbodondeVive.Location = new System.Drawing.Point(156, 228);
            this.cbodondeVive.Name = "cbodondeVive";
            this.cbodondeVive.Size = new System.Drawing.Size(248, 21);
            this.cbodondeVive.TabIndex = 4;
            // 
            // lblperfil
            // 
            this.lblperfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.Location = new System.Drawing.Point(81, 54);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(115, 39);
            this.lblperfil.TabIndex = 0;
            this.lblperfil.Text = "PERFIL";
            this.lblperfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerperfil
            // 
            this.btnVerperfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerperfil.Location = new System.Drawing.Point(66, 279);
            this.btnVerperfil.Name = "btnVerperfil";
            this.btnVerperfil.Size = new System.Drawing.Size(93, 34);
            this.btnVerperfil.TabIndex = 5;
            this.btnVerperfil.Text = "Ver Perfil";
            this.btnVerperfil.UseVisualStyleBackColor = true;
            this.btnVerperfil.Click += new System.EventHandler(this.btnVerperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 541);
            this.Controls.Add(this.btnVerperfil);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.cbodondeVive);
            this.Controls.Add(this.lbldondeVive);
            this.Controls.Add(this.dtpfechaNacimiento);
            this.Controls.Add(this.nudnumeroFavorito);
            this.Controls.Add(this.lblnumeroFavorito);
            this.Controls.Add(this.lblFechanacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lvTexto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MinimumSize = new System.Drawing.Size(487, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudnumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvTexto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechanacimiento;
        private System.Windows.Forms.Label lblnumeroFavorito;
        private System.Windows.Forms.NumericUpDown nudnumeroFavorito;
        private System.Windows.Forms.DateTimePicker dtpfechaNacimiento;
        private System.Windows.Forms.Label lbldondeVive;
        private System.Windows.Forms.ComboBox cbodondeVive;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.Button btnVerperfil;
    }
}

