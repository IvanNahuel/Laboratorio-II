namespace Clase_6_Login
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckRecordar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.rboHombre = new System.Windows.Forms.RadioButton();
            this.rboMujer = new System.Windows.Forms.RadioButton();
            this.rboOtros = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.cmbCaracteristicas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(226, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(437, 46);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(160, 20);
            this.tbApellido.TabIndex = 1;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(226, 91);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(371, 20);
            this.tbCorreo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion de correo electronico";
            // 
            // ckRecordar
            // 
            this.ckRecordar.AutoSize = true;
            this.ckRecordar.Location = new System.Drawing.Point(226, 139);
            this.ckRecordar.Name = "ckRecordar";
            this.ckRecordar.Size = new System.Drawing.Size(15, 14);
            this.ckRecordar.TabIndex = 6;
            this.ckRecordar.UseVisualStyleBackColor = true;
            this.ckRecordar.CheckedChanged += new System.EventHandler(this.ckRecordar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recordar ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(226, 180);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(371, 20);
            this.tbContrasenia.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(226, 223);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(371, 20);
            this.tbCelular.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(226, 272);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sexo";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContinuar.Location = new System.Drawing.Point(310, 357);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(217, 55);
            this.btnContinuar.TabIndex = 16;
            this.btnContinuar.Text = "continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // rboHombre
            // 
            this.rboHombre.AutoSize = true;
            this.rboHombre.Location = new System.Drawing.Point(210, 331);
            this.rboHombre.Name = "rboHombre";
            this.rboHombre.Size = new System.Drawing.Size(62, 17);
            this.rboHombre.TabIndex = 17;
            this.rboHombre.TabStop = true;
            this.rboHombre.Text = "Hombre";
            this.rboHombre.UseVisualStyleBackColor = true;
            // 
            // rboMujer
            // 
            this.rboMujer.AutoSize = true;
            this.rboMujer.Location = new System.Drawing.Point(325, 331);
            this.rboMujer.Name = "rboMujer";
            this.rboMujer.Size = new System.Drawing.Size(51, 17);
            this.rboMujer.TabIndex = 18;
            this.rboMujer.TabStop = true;
            this.rboMujer.Text = "Mujer";
            this.rboMujer.UseVisualStyleBackColor = true;
            // 
            // rboOtros
            // 
            this.rboOtros.AutoSize = true;
            this.rboOtros.Location = new System.Drawing.Point(442, 331);
            this.rboOtros.Name = "rboOtros";
            this.rboOtros.Size = new System.Drawing.Size(50, 17);
            this.rboOtros.TabIndex = 19;
            this.rboOtros.TabStop = true;
            this.rboOtros.Text = "Otros";
            this.rboOtros.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.Items.AddRange(new object[] {
            "Andorra",
            "Argentina",
            "Argelia"});
            this.lstPaises.Location = new System.Drawing.Point(651, 41);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(120, 95);
            this.lstPaises.TabIndex = 21;
            this.lstPaises.SelectedIndexChanged += new System.EventHandler(this.lstPaises_SelectedIndexChanged);
            // 
            // cmbCaracteristicas
            // 
            this.cmbCaracteristicas.FormattingEnabled = true;
            this.cmbCaracteristicas.Items.AddRange(new object[] {
            "+1",
            "+54",
            "+2",
            "+5",
            "+25",
            "+365"});
            this.cmbCaracteristicas.Location = new System.Drawing.Point(651, 156);
            this.cmbCaracteristicas.Name = "cmbCaracteristicas";
            this.cmbCaracteristicas.Size = new System.Drawing.Size(121, 21);
            this.cmbCaracteristicas.TabIndex = 22;
            this.cmbCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.cmbCaracteristicas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCaracteristicas);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rboOtros);
            this.Controls.Add(this.rboMujer);
            this.Controls.Add(this.rboHombre);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckRecordar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbNombre;
    private System.Windows.Forms.TextBox tbApellido;
    private System.Windows.Forms.TextBox tbCorreo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox ckRecordar;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbContrasenia;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbCelular;
    private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnContinuar;
    private System.Windows.Forms.RadioButton rboHombre;
    private System.Windows.Forms.RadioButton rboMujer;
    private System.Windows.Forms.RadioButton rboOtros;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.ListBox lstPaises;
    private System.Windows.Forms.ComboBox cmbCaracteristicas;
  }
}

