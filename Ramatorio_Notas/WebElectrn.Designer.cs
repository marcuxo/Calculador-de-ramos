namespace Ramatorio_Notas
{
    partial class WebElectrn
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
            this.n1_25 = new System.Windows.Forms.TextBox();
            this.n2_25 = new System.Windows.Forms.TextBox();
            this.n3_25 = new System.Windows.Forms.TextBox();
            this.n4_25 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rspta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1_25
            // 
            this.n1_25.Location = new System.Drawing.Point(43, 35);
            this.n1_25.Name = "n1_25";
            this.n1_25.Size = new System.Drawing.Size(33, 20);
            this.n1_25.TabIndex = 0;
            // 
            // n2_25
            // 
            this.n2_25.Location = new System.Drawing.Point(98, 35);
            this.n2_25.Name = "n2_25";
            this.n2_25.Size = new System.Drawing.Size(33, 20);
            this.n2_25.TabIndex = 1;
            // 
            // n3_25
            // 
            this.n3_25.Location = new System.Drawing.Point(155, 35);
            this.n3_25.Name = "n3_25";
            this.n3_25.Size = new System.Drawing.Size(33, 20);
            this.n3_25.TabIndex = 2;
            // 
            // n4_25
            // 
            this.n4_25.Location = new System.Drawing.Point(209, 35);
            this.n4_25.Name = "n4_25";
            this.n4_25.Size = new System.Drawing.Size(33, 20);
            this.n4_25.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "25%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "25%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "25%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "25%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado:\r\n";
            // 
            // rspta
            // 
            this.rspta.AutoSize = true;
            this.rspta.Location = new System.Drawing.Point(40, 134);
            this.rspta.Name = "rspta";
            this.rspta.Size = new System.Drawing.Size(16, 13);
            this.rspta.TabIndex = 9;
            this.rspta.Text = "...";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(344, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Promedio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(251, 166);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // WebElectrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 201);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rspta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n4_25);
            this.Controls.Add(this.n3_25);
            this.Controls.Add(this.n2_25);
            this.Controls.Add(this.n1_25);
            this.Name = "WebElectrn";
            this.Text = "Servicio Web y Comercio Electronico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1_25;
        private System.Windows.Forms.TextBox n2_25;
        private System.Windows.Forms.TextBox n3_25;
        private System.Windows.Forms.TextBox n4_25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rspta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
    }
}