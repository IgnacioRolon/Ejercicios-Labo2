namespace WindowsFormsApp1
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
            this.txtLockPeso = new System.Windows.Forms.TextBox();
            this.txtLockDolar = new System.Windows.Forms.TextBox();
            this.txtLockEuro = new System.Windows.Forms.TextBox();
            this.btnLockear = new System.Windows.Forms.Button();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.txtEuro1 = new System.Windows.Forms.TextBox();
            this.txtDolar1 = new System.Windows.Forms.TextBox();
            this.txtPeso1 = new System.Windows.Forms.TextBox();
            this.txtEuro2 = new System.Windows.Forms.TextBox();
            this.txtDolar2 = new System.Windows.Forms.TextBox();
            this.txtPeso2 = new System.Windows.Forms.TextBox();
            this.txtEuro3 = new System.Windows.Forms.TextBox();
            this.txtDolar3 = new System.Windows.Forms.TextBox();
            this.txtPeso3 = new System.Windows.Forms.TextBox();
            this.btnEuroCarga = new System.Windows.Forms.Button();
            this.btnDolarCarga = new System.Windows.Forms.Button();
            this.btnPesoCarga = new System.Windows.Forms.Button();
            this.txtEuroCarga = new System.Windows.Forms.TextBox();
            this.txtDolarCarga = new System.Windows.Forms.TextBox();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLockPeso
            // 
            this.txtLockPeso.Location = new System.Drawing.Point(484, 12);
            this.txtLockPeso.Name = "txtLockPeso";
            this.txtLockPeso.Size = new System.Drawing.Size(100, 20);
            this.txtLockPeso.TabIndex = 0;
            this.txtLockPeso.Leave += new System.EventHandler(this.txtLockPeso_Leave);
            // 
            // txtLockDolar
            // 
            this.txtLockDolar.Location = new System.Drawing.Point(378, 12);
            this.txtLockDolar.Name = "txtLockDolar";
            this.txtLockDolar.ReadOnly = true;
            this.txtLockDolar.Size = new System.Drawing.Size(100, 20);
            this.txtLockDolar.TabIndex = 1;
            this.txtLockDolar.Text = "1";
            this.txtLockDolar.TextChanged += new System.EventHandler(this.txtLockDolar_TextChanged);
            // 
            // txtLockEuro
            // 
            this.txtLockEuro.Location = new System.Drawing.Point(272, 12);
            this.txtLockEuro.Name = "txtLockEuro";
            this.txtLockEuro.Size = new System.Drawing.Size(100, 20);
            this.txtLockEuro.TabIndex = 2;
            this.txtLockEuro.TextChanged += new System.EventHandler(this.txtLockEuro_TextChanged);
            this.txtLockEuro.Leave += new System.EventHandler(this.txtLockEuro_Leave);
            // 
            // btnLockear
            // 
            this.btnLockear.Location = new System.Drawing.Point(184, 12);
            this.btnLockear.Name = "btnLockear";
            this.btnLockear.Size = new System.Drawing.Size(75, 20);
            this.btnLockear.TabIndex = 3;
            this.btnLockear.Text = "Lock";
            this.btnLockear.UseVisualStyleBackColor = true;
            this.btnLockear.Click += new System.EventHandler(this.btnLockear_Click);
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(78, 16);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(56, 13);
            this.lblCotizacion.TabIndex = 4;
            this.lblCotizacion.Text = "Cotización";
            // 
            // txtEuro1
            // 
            this.txtEuro1.Location = new System.Drawing.Point(272, 81);
            this.txtEuro1.Name = "txtEuro1";
            this.txtEuro1.ReadOnly = true;
            this.txtEuro1.Size = new System.Drawing.Size(100, 20);
            this.txtEuro1.TabIndex = 7;
            // 
            // txtDolar1
            // 
            this.txtDolar1.Location = new System.Drawing.Point(378, 81);
            this.txtDolar1.Name = "txtDolar1";
            this.txtDolar1.ReadOnly = true;
            this.txtDolar1.Size = new System.Drawing.Size(100, 20);
            this.txtDolar1.TabIndex = 6;
            // 
            // txtPeso1
            // 
            this.txtPeso1.Location = new System.Drawing.Point(484, 81);
            this.txtPeso1.Name = "txtPeso1";
            this.txtPeso1.ReadOnly = true;
            this.txtPeso1.Size = new System.Drawing.Size(100, 20);
            this.txtPeso1.TabIndex = 5;
            // 
            // txtEuro2
            // 
            this.txtEuro2.Location = new System.Drawing.Point(272, 124);
            this.txtEuro2.Name = "txtEuro2";
            this.txtEuro2.ReadOnly = true;
            this.txtEuro2.Size = new System.Drawing.Size(100, 20);
            this.txtEuro2.TabIndex = 10;
            // 
            // txtDolar2
            // 
            this.txtDolar2.Location = new System.Drawing.Point(378, 124);
            this.txtDolar2.Name = "txtDolar2";
            this.txtDolar2.ReadOnly = true;
            this.txtDolar2.Size = new System.Drawing.Size(100, 20);
            this.txtDolar2.TabIndex = 9;
            // 
            // txtPeso2
            // 
            this.txtPeso2.Location = new System.Drawing.Point(484, 124);
            this.txtPeso2.Name = "txtPeso2";
            this.txtPeso2.ReadOnly = true;
            this.txtPeso2.Size = new System.Drawing.Size(100, 20);
            this.txtPeso2.TabIndex = 8;
            // 
            // txtEuro3
            // 
            this.txtEuro3.Location = new System.Drawing.Point(272, 166);
            this.txtEuro3.Name = "txtEuro3";
            this.txtEuro3.ReadOnly = true;
            this.txtEuro3.Size = new System.Drawing.Size(100, 20);
            this.txtEuro3.TabIndex = 13;
            // 
            // txtDolar3
            // 
            this.txtDolar3.Location = new System.Drawing.Point(378, 166);
            this.txtDolar3.Name = "txtDolar3";
            this.txtDolar3.ReadOnly = true;
            this.txtDolar3.Size = new System.Drawing.Size(100, 20);
            this.txtDolar3.TabIndex = 12;
            // 
            // txtPeso3
            // 
            this.txtPeso3.Location = new System.Drawing.Point(484, 166);
            this.txtPeso3.Name = "txtPeso3";
            this.txtPeso3.ReadOnly = true;
            this.txtPeso3.Size = new System.Drawing.Size(100, 20);
            this.txtPeso3.TabIndex = 11;
            // 
            // btnEuroCarga
            // 
            this.btnEuroCarga.Location = new System.Drawing.Point(184, 81);
            this.btnEuroCarga.Name = "btnEuroCarga";
            this.btnEuroCarga.Size = new System.Drawing.Size(75, 20);
            this.btnEuroCarga.TabIndex = 14;
            this.btnEuroCarga.Text = "->";
            this.btnEuroCarga.UseVisualStyleBackColor = true;
            this.btnEuroCarga.Click += new System.EventHandler(this.btnEuroCarga_Click);
            // 
            // btnDolarCarga
            // 
            this.btnDolarCarga.Location = new System.Drawing.Point(184, 124);
            this.btnDolarCarga.Name = "btnDolarCarga";
            this.btnDolarCarga.Size = new System.Drawing.Size(75, 20);
            this.btnDolarCarga.TabIndex = 15;
            this.btnDolarCarga.Text = "->";
            this.btnDolarCarga.UseVisualStyleBackColor = true;
            this.btnDolarCarga.Click += new System.EventHandler(this.btnDolarCarga_Click);
            // 
            // btnPesoCarga
            // 
            this.btnPesoCarga.Location = new System.Drawing.Point(184, 166);
            this.btnPesoCarga.Name = "btnPesoCarga";
            this.btnPesoCarga.Size = new System.Drawing.Size(75, 20);
            this.btnPesoCarga.TabIndex = 16;
            this.btnPesoCarga.Text = "->";
            this.btnPesoCarga.UseVisualStyleBackColor = true;
            this.btnPesoCarga.Click += new System.EventHandler(this.btnPesoCarga_Click);
            // 
            // txtEuroCarga
            // 
            this.txtEuroCarga.Location = new System.Drawing.Point(57, 81);
            this.txtEuroCarga.Name = "txtEuroCarga";
            this.txtEuroCarga.Size = new System.Drawing.Size(100, 20);
            this.txtEuroCarga.TabIndex = 17;
            // 
            // txtDolarCarga
            // 
            this.txtDolarCarga.Location = new System.Drawing.Point(57, 124);
            this.txtDolarCarga.Name = "txtDolarCarga";
            this.txtDolarCarga.Size = new System.Drawing.Size(100, 20);
            this.txtDolarCarga.TabIndex = 18;
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(57, 166);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCarga.TabIndex = 19;
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(12, 84);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(29, 13);
            this.lblEuro1.TabIndex = 20;
            this.lblEuro1.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 214);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.txtDolarCarga);
            this.Controls.Add(this.txtEuroCarga);
            this.Controls.Add(this.btnPesoCarga);
            this.Controls.Add(this.btnDolarCarga);
            this.Controls.Add(this.btnEuroCarga);
            this.Controls.Add(this.txtEuro3);
            this.Controls.Add(this.txtDolar3);
            this.Controls.Add(this.txtPeso3);
            this.Controls.Add(this.txtEuro2);
            this.Controls.Add(this.txtDolar2);
            this.Controls.Add(this.txtPeso2);
            this.Controls.Add(this.txtEuro1);
            this.Controls.Add(this.txtDolar1);
            this.Controls.Add(this.txtPeso1);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.btnLockear);
            this.Controls.Add(this.txtLockEuro);
            this.Controls.Add(this.txtLockDolar);
            this.Controls.Add(this.txtLockPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtLockPeso;
    private System.Windows.Forms.TextBox txtLockDolar;
    private System.Windows.Forms.TextBox txtLockEuro;
    private System.Windows.Forms.Button btnLockear;
    private System.Windows.Forms.Label lblCotizacion;
    private System.Windows.Forms.TextBox txtEuro1;
    private System.Windows.Forms.TextBox txtDolar1;
    private System.Windows.Forms.TextBox txtPeso1;
    private System.Windows.Forms.TextBox txtEuro2;
    private System.Windows.Forms.TextBox txtDolar2;
    private System.Windows.Forms.TextBox txtPeso2;
    private System.Windows.Forms.TextBox txtEuro3;
    private System.Windows.Forms.TextBox txtDolar3;
    private System.Windows.Forms.TextBox txtPeso3;
    private System.Windows.Forms.Button btnEuroCarga;
    private System.Windows.Forms.Button btnDolarCarga;
    private System.Windows.Forms.Button btnPesoCarga;
    private System.Windows.Forms.TextBox txtEuroCarga;
    private System.Windows.Forms.TextBox txtDolarCarga;
    private System.Windows.Forms.TextBox txtPesoCarga;
    private System.Windows.Forms.Label lblEuro1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

