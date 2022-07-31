namespace AppClase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtSalarioBasicoHora = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.Label();
            this.txtNumHorasTrabajadas = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.Label();
            this.txtSubsidio = new System.Windows.Forms.Label();
            this.txtSalrioNeto = new System.Windows.Forms.Label();
            this.txtValorHoraExtra = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 23);
            this.textBox1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(369, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(72, 21);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Nómina";
            this.txtTitle.UseWaitCursor = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(92, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(51, 15);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nombre";
            // 
            // txtSalarioBasicoHora
            // 
            this.txtSalarioBasicoHora.AutoSize = true;
            this.txtSalarioBasicoHora.Location = new System.Drawing.Point(92, 163);
            this.txtSalarioBasicoHora.Name = "txtSalarioBasicoHora";
            this.txtSalarioBasicoHora.Size = new System.Drawing.Size(108, 15);
            this.txtSalarioBasicoHora.TabIndex = 3;
            this.txtSalarioBasicoHora.Text = "Salario Básico Hora";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.AutoSize = true;
            this.txtSalarioBruto.Location = new System.Drawing.Point(92, 212);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(74, 15);
            this.txtSalarioBruto.TabIndex = 4;
            this.txtSalarioBruto.Text = "Salario Bruto";
            // 
            // txtNumHorasTrabajadas
            // 
            this.txtNumHorasTrabajadas.AutoSize = true;
            this.txtNumHorasTrabajadas.Location = new System.Drawing.Point(392, 168);
            this.txtNumHorasTrabajadas.Name = "txtNumHorasTrabajadas";
            this.txtNumHorasTrabajadas.Size = new System.Drawing.Size(158, 15);
            this.txtNumHorasTrabajadas.TabIndex = 5;
            this.txtNumHorasTrabajadas.Text = "Numero de Horas trabajadas";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.AutoSize = true;
            this.txtHorasExtras.Location = new System.Drawing.Point(97, 300);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(72, 15);
            this.txtHorasExtras.TabIndex = 6;
            this.txtHorasExtras.Text = "Horas Extras";
            // 
            // txtSubsidio
            // 
            this.txtSubsidio.AutoSize = true;
            this.txtSubsidio.Location = new System.Drawing.Point(59, 350);
            this.txtSubsidio.Name = "txtSubsidio";
            this.txtSubsidio.Size = new System.Drawing.Size(110, 15);
            this.txtSubsidio.TabIndex = 7;
            this.txtSubsidio.Text = "Subsidio Transporte";
            this.txtSubsidio.Click += new System.EventHandler(this.txtSubsidio_Click);
            // 
            // txtSalrioNeto
            // 
            this.txtSalrioNeto.AutoSize = true;
            this.txtSalrioNeto.Location = new System.Drawing.Point(96, 396);
            this.txtSalrioNeto.Name = "txtSalrioNeto";
            this.txtSalrioNeto.Size = new System.Drawing.Size(71, 15);
            this.txtSalrioNeto.TabIndex = 8;
            this.txtSalrioNeto.Text = "Salario Neto";
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.AutoSize = true;
            this.txtValorHoraExtra.Location = new System.Drawing.Point(423, 301);
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.Size = new System.Drawing.Size(91, 15);
            this.txtValorHoraExtra.TabIndex = 9;
            this.txtValorHoraExtra.Text = "Valor Hora Extra";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(570, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 23);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(539, 297);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 23);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 298);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 23);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(181, 347);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(157, 23);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(179, 396);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 23);
            this.textBox8.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(897, 547);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtValorHoraExtra);
            this.Controls.Add(this.txtSalrioNeto);
            this.Controls.Add(this.txtSubsidio);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.txtNumHorasTrabajadas);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtSalarioBasicoHora);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox textBox1;
        private Label txtTitle;
        private Label txtName;
        private Label txtSalarioBasicoHora;
        private Label txtSalarioBruto;
        private Label txtNumHorasTrabajadas;
        private Label txtHorasExtras;
        private Label txtSubsidio;
        private Label txtSalrioNeto;
        private Label txtValorHoraExtra;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}