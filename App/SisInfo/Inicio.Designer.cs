namespace SisInfo
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TfNombre = new System.Windows.Forms.TextBox();
            this.BtnSoli = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TfApellido = new System.Windows.Forms.TextBox();
            this.TfCel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TfCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TfDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(256, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco Hollownest";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisInfo.Properties.Resources.HK___mascara;
            this.pictureBox1.Location = new System.Drawing.Point(223, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Su nombre:";
            // 
            // TfNombre
            // 
            this.TfNombre.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfNombre.Location = new System.Drawing.Point(273, 95);
            this.TfNombre.Name = "TfNombre";
            this.TfNombre.Size = new System.Drawing.Size(265, 28);
            this.TfNombre.TabIndex = 3;
            this.TfNombre.TextChanged += new System.EventHandler(this.TfNombre_TextChanged);
            // 
            // BtnSoli
            // 
            this.BtnSoli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSoli.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoli.Location = new System.Drawing.Point(335, 370);
            this.BtnSoli.Name = "BtnSoli";
            this.BtnSoli.Size = new System.Drawing.Size(115, 55);
            this.BtnSoli.TabIndex = 4;
            this.BtnSoli.Text = "Solicitar Prestamo";
            this.BtnSoli.UseVisualStyleBackColor = false;
            this.BtnSoli.Click += new System.EventHandler(this.BtnSoli_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(707, 414);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(85, 35);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Su apellido:";
            // 
            // TfApellido
            // 
            this.TfApellido.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfApellido.Location = new System.Drawing.Point(273, 148);
            this.TfApellido.Name = "TfApellido";
            this.TfApellido.Size = new System.Drawing.Size(265, 28);
            this.TfApellido.TabIndex = 7;
            this.TfApellido.TextChanged += new System.EventHandler(this.TfApellido_TextChanged);
            // 
            // TfCel
            // 
            this.TfCel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfCel.Location = new System.Drawing.Point(273, 254);
            this.TfCel.Name = "TfCel";
            this.TfCel.Size = new System.Drawing.Size(265, 28);
            this.TfCel.TabIndex = 11;
            this.TfCel.TextChanged += new System.EventHandler(this.TfCel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Su celular:";
            // 
            // TfCorreo
            // 
            this.TfCorreo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfCorreo.Location = new System.Drawing.Point(273, 201);
            this.TfCorreo.Name = "TfCorreo";
            this.TfCorreo.Size = new System.Drawing.Size(265, 28);
            this.TfCorreo.TabIndex = 9;
            this.TfCorreo.TextChanged += new System.EventHandler(this.TfCorreo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Su correo:";
            // 
            // TfDir
            // 
            this.TfDir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TfDir.Location = new System.Drawing.Point(273, 308);
            this.TfDir.Name = "TfDir";
            this.TfDir.Size = new System.Drawing.Size(265, 28);
            this.TfDir.TabIndex = 13;
            this.TfDir.TextChanged += new System.EventHandler(this.TfDir_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Su Dirección:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.TfDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TfCel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TfCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TfApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnSoli);
            this.Controls.Add(this.TfNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Hollownest";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TfNombre;
        private System.Windows.Forms.Button BtnSoli;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TfApellido;
        private System.Windows.Forms.TextBox TfCel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TfCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TfDir;
        private System.Windows.Forms.Label label6;
    }
}

