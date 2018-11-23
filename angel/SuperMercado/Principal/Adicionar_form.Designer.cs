namespace Principal
{
    partial class Adicionar_form
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
            this.productoventa_txt = new System.Windows.Forms.TextBox();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.empleado_txt_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_txt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // productoventa_txt
            // 
            this.productoventa_txt.Location = new System.Drawing.Point(92, 51);
            this.productoventa_txt.Name = "productoventa_txt";
            this.productoventa_txt.Size = new System.Drawing.Size(200, 20);
            this.productoventa_txt.TabIndex = 0;
            // 
            // cliente_txt
            // 
            this.cliente_txt.Location = new System.Drawing.Point(92, 98);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(200, 20);
            this.cliente_txt.TabIndex = 1;
            this.cliente_txt.TextChanged += new System.EventHandler(this.cliente_txt_TextChanged);
            // 
            // empleado_txt_txt
            // 
            this.empleado_txt_txt.Location = new System.Drawing.Point(92, 147);
            this.empleado_txt_txt.Name = "empleado_txt_txt";
            this.empleado_txt_txt.Size = new System.Drawing.Size(200, 20);
            this.empleado_txt_txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(21, 58);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 4;
            this.Producto.Text = "Producto";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(21, 105);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 5;
            this.Cliente.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Location = new System.Drawing.Point(92, 185);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(200, 20);
            this.cantidad_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha";
            // 
            // fecha_txt
            // 
            this.fecha_txt.Location = new System.Drawing.Point(92, 232);
            this.fecha_txt.Name = "fecha_txt";
            this.fecha_txt.Size = new System.Drawing.Size(200, 20);
            this.fecha_txt.TabIndex = 16;
            // 
            // Adicionar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 314);
            this.Controls.Add(this.fecha_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empleado_txt_txt);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.productoventa_txt);
            this.Name = "Adicionar_form";
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productoventa_txt;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.TextBox empleado_txt_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_txt;
    }
}