namespace Presentacion
{
    partial class frmInicio
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.ckbxMostrar = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(38, 114);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(239, 26);
            this.txtIdentificacion.TabIndex = 0;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(38, 193);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(239, 26);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.Location = new System.Drawing.Point(38, 86);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(239, 25);
            this.lbIdentificacion.TabIndex = 2;
            this.lbIdentificacion.Text = "IDENTIFICACIÓN";
            this.lbIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTRASEÑA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(319, 60);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "INICIO DE SESIÓN";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(137, 288);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(170, 36);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // ckbxMostrar
            // 
            this.ckbxMostrar.AutoSize = true;
            this.ckbxMostrar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxMostrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxMostrar.Location = new System.Drawing.Point(139, 225);
            this.ckbxMostrar.Name = "ckbxMostrar";
            this.ckbxMostrar.Size = new System.Drawing.Size(127, 22);
            this.ckbxMostrar.TabIndex = 8;
            this.ckbxMostrar.Text = "Mostrar contraseña";
            this.ckbxMostrar.UseVisualStyleBackColor = true;
            this.ckbxMostrar.CheckedChanged += new System.EventHandler(this.ckbxMostrar_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(319, 348);
            this.ControlBox = false;
            this.Controls.Add(this.ckbxMostrar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtIdentificacion);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.CheckBox ckbxMostrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

