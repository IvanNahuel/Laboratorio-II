namespace dataBase
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
            this.cmbPcia = new System.Windows.Forms.ComboBox();
            this.txtProvincia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPcia
            // 
            this.cmbPcia.FormattingEnabled = true;
            this.cmbPcia.Location = new System.Drawing.Point(67, 79);
            this.cmbPcia.Name = "cmbPcia";
            this.cmbPcia.Size = new System.Drawing.Size(121, 21);
            this.cmbPcia.TabIndex = 0;
            // 
            // txtProvincia
            // 
            this.txtProvincia.AutoSize = true;
            this.txtProvincia.Location = new System.Drawing.Point(64, 54);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(51, 13);
            this.txtProvincia.TabIndex = 1;
            this.txtProvincia.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.cmbPcia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbPcia;
    private System.Windows.Forms.Label txtProvincia;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
  }
}

