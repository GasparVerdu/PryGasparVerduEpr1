namespace PryGasparVerduEpr1
{
    partial class FrmClientes
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
            this.nudIdentificador = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblRegistroClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificador)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIdentificador
            // 
            this.nudIdentificador.Location = new System.Drawing.Point(82, 99);
            this.nudIdentificador.Name = "nudIdentificador";
            this.nudIdentificador.Size = new System.Drawing.Size(80, 20);
            this.nudIdentificador.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(80, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(11, 99);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificador.TabIndex = 9;
            this.lblIdentificador.Text = "Identificador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(87, 144);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblRegistroClientes
            // 
            this.lblRegistroClientes.AutoSize = true;
            this.lblRegistroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroClientes.Location = new System.Drawing.Point(27, 9);
            this.lblRegistroClientes.Name = "lblRegistroClientes";
            this.lblRegistroClientes.Size = new System.Drawing.Size(135, 18);
            this.lblRegistroClientes.TabIndex = 6;
            this.lblRegistroClientes.Text = "Registro clientes";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 182);
            this.Controls.Add(this.nudIdentificador);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblRegistroClientes);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIdentificador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblRegistroClientes;
    }
}