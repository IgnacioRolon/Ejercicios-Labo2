namespace Generics
{
    partial class frmEstanteria
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbParametro = new System.Windows.Forms.ComboBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.lblTamano = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbParametro
            // 
            this.cmbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParametro.FormattingEnabled = true;
            this.cmbParametro.Items.AddRange(new object[] {
            "Alimenticio",
            "Ferreteria"});
            this.cmbParametro.Location = new System.Drawing.Point(56, 25);
            this.cmbParametro.Name = "cmbParametro";
            this.cmbParametro.Size = new System.Drawing.Size(121, 21);
            this.cmbParametro.TabIndex = 1;
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(64, 73);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(100, 20);
            this.txtTamano.TabIndex = 2;
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(12, 76);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(46, 13);
            this.lblTamano.TabIndex = 3;
            this.lblTamano.Text = "Tamaño";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(135, 120);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmEstanteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 155);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.cmbParametro);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmEstanteria";
            this.Text = "frmEstanteria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEstanteria_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEstanteria_FormClosed);
            this.Load += new System.EventHandler(this.frmEstanteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbParametro;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Label lblTamano;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnCerrar;
  }
}
