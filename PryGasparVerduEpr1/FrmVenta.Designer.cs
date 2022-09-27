namespace PryGasparVerduEpr1
{
    partial class FrmVenta
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTFactuda = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.CboVendedor = new System.Windows.Forms.ComboBox();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudNumeroFactura = new System.Windows.Forms.NumericUpDown();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(12, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(71, 18);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "Vendedor";
            this.lblVendedor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTFactuda
            // 
            this.lblTFactuda.AutoSize = true;
            this.lblTFactuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFactuda.Location = new System.Drawing.Point(12, 135);
            this.lblTFactuda.Name = "lblTFactuda";
            this.lblTFactuda.Size = new System.Drawing.Size(106, 18);
            this.lblTFactuda.TabIndex = 3;
            this.lblTFactuda.Text = "Tipo de factura";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(12, 177);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(131, 18);
            this.lblNumFactura.TabIndex = 4;
            this.lblNumFactura.Text = "Numero de factura";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 217);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(51, 18);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(113, 12);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(124, 21);
            this.cboCliente.TabIndex = 6;
            // 
            // CboVendedor
            // 
            this.CboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVendedor.FormattingEnabled = true;
            this.CboVendedor.Location = new System.Drawing.Point(113, 53);
            this.CboVendedor.Name = "CboVendedor";
            this.CboVendedor.Size = new System.Drawing.Size(124, 21);
            this.CboVendedor.TabIndex = 7;
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoFactura.Location = new System.Drawing.Point(124, 135);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(113, 21);
            this.cboTipoFactura.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(113, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(124, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2022, 9, 27, 16, 34, 26, 0);
            // 
            // nudNumeroFactura
            // 
            this.nudNumeroFactura.Location = new System.Drawing.Point(149, 175);
            this.nudNumeroFactura.Name = "nudNumeroFactura";
            this.nudNumeroFactura.Size = new System.Drawing.Size(88, 20);
            this.nudNumeroFactura.TabIndex = 10;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(149, 215);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(88, 20);
            this.nudMonto.TabIndex = 11;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(164, 257);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 292);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.nudNumeroFactura);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.CboVendedor);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.lblTFactuda);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTFactuda;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox CboVendedor;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudNumeroFactura;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Button btnCargar;
    }
}