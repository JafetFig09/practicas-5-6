namespace Practicas5_6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHanoi = new System.Windows.Forms.Button();
            this.tbHanoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbHanoi = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.Monedas = new System.Windows.Forms.RadioButton();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbHanoi);
            this.panel1.Controls.Add(this.btnHanoi);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(27, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 435);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 324);
            this.listBox1.TabIndex = 0;
            // 
            // btnHanoi
            // 
            this.btnHanoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHanoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHanoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHanoi.Location = new System.Drawing.Point(292, 45);
            this.btnHanoi.Name = "btnHanoi";
            this.btnHanoi.Size = new System.Drawing.Size(105, 31);
            this.btnHanoi.TabIndex = 1;
            this.btnHanoi.Text = "Resolver";
            this.btnHanoi.UseVisualStyleBackColor = false;
            this.btnHanoi.Click += new System.EventHandler(this.btnHanoi_Click);
            // 
            // tbHanoi
            // 
            this.tbHanoi.Location = new System.Drawing.Point(175, 52);
            this.tbHanoi.Name = "tbHanoi";
            this.tbHanoi.Size = new System.Drawing.Size(79, 22);
            this.tbHanoi.TabIndex = 2;
            this.tbHanoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero:";
            // 
            // rbHanoi
            // 
            this.rbHanoi.AutoSize = true;
            this.rbHanoi.Location = new System.Drawing.Point(202, 54);
            this.rbHanoi.Name = "rbHanoi";
            this.rbHanoi.Size = new System.Drawing.Size(119, 20);
            this.rbHanoi.TabIndex = 1;
            this.rbHanoi.TabStop = true;
            this.rbHanoi.Text = "Torre de Hanoi";
            this.rbHanoi.UseVisualStyleBackColor = true;
            this.rbHanoi.CheckedChanged += new System.EventHandler(this.rbHanoi_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMonedas);
            this.panel2.Controls.Add(this.tbPago);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbPrecio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(498, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 442);
            this.panel2.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(29, 106);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(427, 308);
            this.listBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(81, 63);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(76, 22);
            this.tbPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago:";
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(248, 67);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(78, 22);
            this.tbPago.TabIndex = 5;
            // 
            // Monedas
            // 
            this.Monedas.AutoSize = true;
            this.Monedas.Location = new System.Drawing.Point(621, 44);
            this.Monedas.Name = "Monedas";
            this.Monedas.Size = new System.Drawing.Size(137, 20);
            this.Monedas.TabIndex = 3;
            this.Monedas.TabStop = true;
            this.Monedas.Text = "Calcular Monedas";
            this.Monedas.UseVisualStyleBackColor = true;
            this.Monedas.CheckedChanged += new System.EventHandler(this.Monedas_CheckedChanged);
            // 
            // btnMonedas
            // 
            this.btnMonedas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonedas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonedas.Location = new System.Drawing.Point(361, 67);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(83, 27);
            this.btnMonedas.TabIndex = 6;
            this.btnMonedas.Text = "Calcular";
            this.btnMonedas.UseVisualStyleBackColor = false;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(982, 575);
            this.Controls.Add(this.Monedas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbHanoi);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHanoi;
        private System.Windows.Forms.Button btnHanoi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbHanoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.RadioButton Monedas;
        private System.Windows.Forms.Button btnMonedas;
    }
}

