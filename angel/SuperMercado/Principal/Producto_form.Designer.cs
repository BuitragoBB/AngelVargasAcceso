namespace Principal
{
    partial class Producto_form
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
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.valor_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigop_txt = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(150, 85);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(100, 20);
            this.nombre_txt.TabIndex = 1;
            // 
            // valor_txt
            // 
            this.valor_txt.Location = new System.Drawing.Point(150, 159);
            this.valor_txt.Name = "valor_txt";
            this.valor_txt.Size = new System.Drawing.Size(100, 20);
            this.valor_txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor C/U";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // codigop_txt
            // 
            this.codigop_txt.Location = new System.Drawing.Point(150, 41);
            this.codigop_txt.Name = "codigop_txt";
            this.codigop_txt.Size = new System.Drawing.Size(100, 20);
            this.codigop_txt.TabIndex = 9;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(52, 121);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 12;
            this.Cantidad.Text = "Cantidad";
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Location = new System.Drawing.Point(150, 121);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(100, 20);
            this.cantidad_txt.TabIndex = 11;
            // 
            // Producto_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 276);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigop_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valor_txt);
            this.Controls.Add(this.nombre_txt);
            this.Name = "Producto_form";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox valor_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigop_txt;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox cantidad_txt;
    }
}