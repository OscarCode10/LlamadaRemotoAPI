namespace SisInfo
{
    partial class Prestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.label1 = new System.Windows.Forms.Label();
            this.saludo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.DtsPresta = new System.Windows.Forms.Panel();
            this.TfGastos = new System.Windows.Forms.TextBox();
            this.TfSueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TfMonto = new System.Windows.Forms.TextBox();
            this.CbCuotas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.DtsPresta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(12, 9);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(205, 36);
            this.saludo.TabIndex = 1;
            this.saludo.Text = "Bienvenido, ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalle del Préstamo:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(707, 414);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(85, 35);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnConfirmar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(335, 350);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(115, 55);
            this.BtnConfirmar.TabIndex = 5;
            this.BtnConfirmar.Text = "Confirmar Solicitud";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // DtsPresta
            // 
            this.DtsPresta.BackColor = System.Drawing.Color.AliceBlue;
            this.DtsPresta.Controls.Add(this.TfGastos);
            this.DtsPresta.Controls.Add(this.TfSueldo);
            this.DtsPresta.Controls.Add(this.label6);
            this.DtsPresta.Controls.Add(this.label5);
            this.DtsPresta.Location = new System.Drawing.Point(36, 153);
            this.DtsPresta.Name = "DtsPresta";
            this.DtsPresta.Size = new System.Drawing.Size(335, 168);
            this.DtsPresta.TabIndex = 6;
            // 
            // TfGastos
            // 
            this.TfGastos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfGastos.Location = new System.Drawing.Point(152, 97);
            this.TfGastos.Name = "TfGastos";
            this.TfGastos.Size = new System.Drawing.Size(140, 25);
            this.TfGastos.TabIndex = 11;
            // 
            // TfSueldo
            // 
            this.TfSueldo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfSueldo.Location = new System.Drawing.Point(152, 41);
            this.TfSueldo.Name = "TfSueldo";
            this.TfSueldo.Size = new System.Drawing.Size(140, 25);
            this.TfSueldo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gastos Mensuales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos Personales:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.TfMonto);
            this.panel1.Controls.Add(this.CbCuotas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(431, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 168);
            this.panel1.TabIndex = 7;
            // 
            // TfMonto
            // 
            this.TfMonto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfMonto.Location = new System.Drawing.Point(168, 41);
            this.TfMonto.Name = "TfMonto";
            this.TfMonto.Size = new System.Drawing.Size(130, 25);
            this.TfMonto.TabIndex = 12;
            // 
            // CbCuotas
            // 
            this.CbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbCuotas.FormattingEnabled = true;
            this.CbCuotas.Location = new System.Drawing.Point(168, 97);
            this.CbCuotas.MaxDropDownItems = 20;
            this.CbCuotas.Name = "CbCuotas";
            this.CbCuotas.Size = new System.Drawing.Size(130, 21);
            this.CbCuotas.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cuotas:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monto del préstamo:";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Aqua;
            this.BtnVolver.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(12, 414);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(85, 35);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.button3_Click);
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtsPresta);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saludo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamo";
            this.Text = "Préstamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.DtsPresta.ResumeLayout(false);
            this.DtsPresta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Panel DtsPresta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TfGastos;
        private System.Windows.Forms.TextBox TfSueldo;
        private System.Windows.Forms.TextBox TfMonto;
        private System.Windows.Forms.ComboBox CbCuotas;
        private System.Windows.Forms.Button BtnVolver;
    }
}