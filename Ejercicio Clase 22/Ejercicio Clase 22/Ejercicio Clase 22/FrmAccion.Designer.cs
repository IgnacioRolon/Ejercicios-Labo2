namespace Ejercicio_Clase_22
{
  partial class FrmAccion
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
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.Location = new System.Drawing.Point(107, 113);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(88, 26);
            this.btnMostrar1.TabIndex = 2;
            this.btnMostrar1.Text = "btnMostrar";
            this.btnMostrar1.UseVisualStyleBackColor = true;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 3;
            // 
            // FrmAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 177);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMostrar1);
            this.Name = "FrmAccion";
            this.Text = "FrmAccion";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnMostrar1;
    private System.Windows.Forms.TextBox textBox1;
  }
}