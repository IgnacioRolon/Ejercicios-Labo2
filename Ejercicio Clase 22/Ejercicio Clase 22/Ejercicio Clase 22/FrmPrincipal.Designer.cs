namespace Ejercicio_Clase_22
{
  partial class FrmPrincipal
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
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.Location = new System.Drawing.Point(131, 101);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(189, 44);
            this.btnMostrar1.TabIndex = 1;
            this.btnMostrar1.Text = "Mostrar 1";
            this.btnMostrar1.UseVisualStyleBackColor = true;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.Location = new System.Drawing.Point(131, 193);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(189, 44);
            this.btnMostrar2.TabIndex = 2;
            this.btnMostrar2.Text = "Mostrar 2";
            this.btnMostrar2.UseVisualStyleBackColor = true;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 393);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.btnMostrar1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnMostrar1;
    private System.Windows.Forms.Button btnMostrar2;
  }
}

