namespace PryGasparVerduEpr1
{
    partial class FrmVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskNumeroVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.btnCargarVendedor = new System.Windows.Forms.Button();
            this.lblRegistrarVendedor = new System.Windows.Forms.Label();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero vendedor";
            // 
            // mskNumeroVendedor
            // 
            this.mskNumeroVendedor.Location = new System.Drawing.Point(128, 101);
            this.mskNumeroVendedor.Mask = "000000";
            this.mskNumeroVendedor.Name = "mskNumeroVendedor";
            this.mskNumeroVendedor.Size = new System.Drawing.Size(43, 20);
            this.mskNumeroVendedor.TabIndex = 16;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(85, 56);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendedor.TabIndex = 15;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(22, 56);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreVendedor.TabIndex = 14;
            this.lblNombreVendedor.Text = "Nombre ";
            // 
            // btnCargarVendedor
            // 
            this.btnCargarVendedor.Location = new System.Drawing.Point(110, 214);
            this.btnCargarVendedor.Name = "btnCargarVendedor";
            this.btnCargarVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnCargarVendedor.TabIndex = 13;
            this.btnCargarVendedor.Text = "Cargar";
            this.btnCargarVendedor.UseVisualStyleBackColor = true;
            this.btnCargarVendedor.Click += new System.EventHandler(this.btnCargarVendedor_Click);
            // 
            // lblRegistrarVendedor
            // 
            this.lblRegistrarVendedor.AutoSize = true;
            this.lblRegistrarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarVendedor.Location = new System.Drawing.Point(32, 18);
            this.lblRegistrarVendedor.Name = "lblRegistrarVendedor";
            this.lblRegistrarVendedor.Size = new System.Drawing.Size(153, 18);
            this.lblRegistrarVendedor.TabIndex = 12;
            this.lblRegistrarVendedor.Text = "Registrar Vendedor";
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Location = new System.Drawing.Point(25, 185);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(68, 17);
            this.chkComision.TabIndex = 11;
            this.chkComision.Text = "Comisión";
            this.chkComision.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(25, 149);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskNumeroVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.btnCargarVendedor);
            this.Controls.Add(this.lblRegistrarVendedor);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.chkActivo);
            this.Name = "FrmVendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.FrmVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNumeroVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Button btnCargarVendedor;
        private System.Windows.Forms.Label lblRegistrarVendedor;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}