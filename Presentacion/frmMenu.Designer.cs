namespace Presentacion
{
    partial class frmMenu
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(0, 202);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(388, 65);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "CERRAR SESIÓN";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(0, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(388, 65);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "CONSULTAR PERFILES";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.Teal;
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 137);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(388, 65);
            this.btnMantenimiento.TabIndex = 1;
            this.btnMantenimiento.Text = "MANTENIMIENTO DE PERFILES";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.lbIdentificacion);
            this.gbxInfo.Controls.Add(this.lbNombre);
            this.gbxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxInfo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(0, 0);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxInfo.Size = new System.Drawing.Size(388, 72);
            this.gbxInfo.TabIndex = 3;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "USUARIO";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.ForeColor = System.Drawing.Color.Teal;
            this.lbIdentificacion.Location = new System.Drawing.Point(25, 32);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(84, 20);
            this.lbIdentificacion.TabIndex = 1;
            this.lbIdentificacion.Text = "Identificación";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.ForeColor = System.Drawing.Color.Teal;
            this.lbNombre.Location = new System.Drawing.Point(130, 32);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(116, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre del usuario";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.ControlBox = false;
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.GroupBox gbxInfo;
        public System.Windows.Forms.Label lbIdentificacion;
        public System.Windows.Forms.Label lbNombre;
    }
}