namespace Principal
{
    partial class Compra_form
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
            this.provedor_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.producto_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidad2_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // provedor_txt
            // 
            this.provedor_txt.Location = new System.Drawing.Point(143, 80);
            this.provedor_txt.Name = "provedor_txt";
            this.provedor_txt.Size = new System.Drawing.Size(200, 20);
            this.provedor_txt.TabIndex = 9;
            this.provedor_txt.TextChanged += new System.EventHandler(this.cantidad_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proveedor";
            // 
            // producto_txt
            // 
            this.producto_txt.Location = new System.Drawing.Point(143, 45);
            this.producto_txt.Name = "producto_txt";
            this.producto_txt.Size = new System.Drawing.Size(200, 20);
            this.producto_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha";
            // 
            // cantidad2_txt
            // 
            this.cantidad2_txt.Location = new System.Drawing.Point(143, 111);
            this.cantidad2_txt.Name = "cantidad2_txt";
            this.cantidad2_txt.Size = new System.Drawing.Size(200, 20);
            this.cantidad2_txt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(143, 151);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 15;
            // 
            // Compra_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 248);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidad2_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.provedor_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.producto_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Compra_form";
            this.Text = "Compra_form";
            this.Load += new System.EventHandler(this.Compra_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox provedor_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox producto_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cantidad2_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}