namespace Presentacion
{
    partial class frmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cbxProceso = new System.Windows.Forms.ComboBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lbSeleccion = new System.Windows.Forms.Label();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbFechaN = new System.Windows.Forms.Label();
            this.lbNombreC = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(249, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(208, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR CAMBIOS";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(77, 499);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 34);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbxProceso
            // 
            this.cbxProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProceso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProceso.FormattingEnabled = true;
            this.cbxProceso.Items.AddRange(new object[] {
            "AGREGAR PERFIL"});
            this.cbxProceso.Location = new System.Drawing.Point(90, 44);
            this.cbxProceso.Name = "cbxProceso";
            this.cbxProceso.Size = new System.Drawing.Size(228, 28);
            this.cbxProceso.TabIndex = 15;
            this.cbxProceso.SelectedIndexChanged += new System.EventHandler(this.cbxProceso_SelectedIndexChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(340, 41);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(98, 34);
            this.btnCambiar.TabIndex = 16;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lbSeleccion
            // 
            this.lbSeleccion.AutoSize = true;
            this.lbSeleccion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccion.Location = new System.Drawing.Point(86, 22);
            this.lbSeleccion.Name = "lbSeleccion";
            this.lbSeleccion.Size = new System.Drawing.Size(232, 19);
            this.lbSeleccion.TabIndex = 17;
            this.lbSeleccion.Text = "SELECCIONE UN PROCEDIMIENTO";
            // 
            // gbxControles
            // 
            this.gbxControles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxControles.Controls.Add(this.dtpFechaN);
            this.gbxControles.Controls.Add(this.lbImagen);
            this.gbxControles.Controls.Add(this.lbTelefono);
            this.gbxControles.Controls.Add(this.lbCorreo);
            this.gbxControles.Controls.Add(this.lbContraseña);
            this.gbxControles.Controls.Add(this.lbFechaN);
            this.gbxControles.Controls.Add(this.lbNombreC);
            this.gbxControles.Controls.Add(this.lbID);
            this.gbxControles.Controls.Add(this.btnExaminar);
            this.gbxControles.Controls.Add(this.pbxImagen);
            this.gbxControles.Controls.Add(this.txtTelefono);
            this.gbxControles.Controls.Add(this.txtCorreo);
            this.gbxControles.Controls.Add(this.txtContraseña);
            this.gbxControles.Controls.Add(this.txtNombreC);
            this.gbxControles.Controls.Add(this.txtID);
            this.gbxControles.Location = new System.Drawing.Point(12, 97);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(512, 385);
            this.gbxControles.TabIndex = 18;
            this.gbxControles.TabStop = false;
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaN.CustomFormat = "";
            this.dtpFechaN.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(48, 339);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(202, 26);
            this.dtpFechaN.TabIndex = 20;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.Location = new System.Drawing.Point(270, 13);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(135, 19);
            this.lbImagen.TabIndex = 29;
            this.lbImagen.Text = "IMÁGEN DE PERFIL:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(44, 257);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(81, 19);
            this.lbTelefono.TabIndex = 28;
            this.lbTelefono.Text = "TELÉFONO:";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(44, 196);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(74, 19);
            this.lbCorreo.TabIndex = 27;
            this.lbCorreo.Text = "CORREO:";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(44, 135);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(103, 19);
            this.lbContraseña.TabIndex = 26;
            this.lbContraseña.Text = "CONTRASEÑA:";
            // 
            // lbFechaN
            // 
            this.lbFechaN.AutoSize = true;
            this.lbFechaN.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaN.Location = new System.Drawing.Point(44, 317);
            this.lbFechaN.Name = "lbFechaN";
            this.lbFechaN.Size = new System.Drawing.Size(168, 19);
            this.lbFechaN.TabIndex = 25;
            this.lbFechaN.Text = "FECHA DE NACIMIENTO:";
            // 
            // lbNombreC
            // 
            this.lbNombreC.AutoSize = true;
            this.lbNombreC.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreC.Location = new System.Drawing.Point(44, 74);
            this.lbNombreC.Name = "lbNombreC";
            this.lbNombreC.Size = new System.Drawing.Size(152, 19);
            this.lbNombreC.TabIndex = 24;
            this.lbNombreC.Text = "NOMBRE COMPLETO:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(44, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(118, 19);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "IDENTIFICACIÓN:";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(307, 239);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(122, 34);
            this.btnExaminar.TabIndex = 21;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImagen.InitialImage")));
            this.pbxImagen.Location = new System.Drawing.Point(274, 35);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(195, 193);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxImagen.TabIndex = 22;
            this.pbxImagen.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(48, 279);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(202, 26);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(48, 218);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(202, 26);
            this.txtCorreo.TabIndex = 18;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(48, 157);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(202, 26);
            this.txtContraseña.TabIndex = 17;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreC
            // 
            this.txtNombreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Location = new System.Drawing.Point(48, 96);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(202, 26);
            this.txtNombreC.TabIndex = 16;
            this.txtNombreC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(48, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 26);
            this.txtID.TabIndex = 15;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 590);
            this.ControlBox = false;
            this.Controls.Add(this.gbxControles);
            this.Controls.Add(this.lbSeleccion);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.cbxProceso);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de perfiles";
            this.Load += new System.EventHandler(this.frmMantenimiento_Load);
            this.gbxControles.ResumeLayout(false);
            this.gbxControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cbxProceso;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lbSeleccion;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbFechaN;
        private System.Windows.Forms.Label lbNombreC;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtID;
    }
}