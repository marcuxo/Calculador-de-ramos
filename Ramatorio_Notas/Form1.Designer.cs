namespace Ramatorio_Notas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPnet = new System.Windows.Forms.Button();
            this.btnSweb = new System.Windows.Forms.Button();
            this.btnLemgts = new System.Windows.Forms.Button();
            this.btnEtica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 105);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(213, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Herramientas de Administracion";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPnet
            // 
            this.btnPnet.Location = new System.Drawing.Point(12, 76);
            this.btnPnet.Name = "btnPnet";
            this.btnPnet.Size = new System.Drawing.Size(126, 23);
            this.btnPnet.TabIndex = 1;
            this.btnPnet.Text = "Programacion .Net";
            this.btnPnet.UseVisualStyleBackColor = true;
            this.btnPnet.Click += new System.EventHandler(this.btnPnet_Click);
            // 
            // btnSweb
            // 
            this.btnSweb.Location = new System.Drawing.Point(12, 134);
            this.btnSweb.Name = "btnSweb";
            this.btnSweb.Size = new System.Drawing.Size(213, 23);
            this.btnSweb.TabIndex = 2;
            this.btnSweb.Text = "Servicio web y Comercio Electronico";
            this.btnSweb.UseVisualStyleBackColor = true;
            this.btnSweb.Click += new System.EventHandler(this.btnSweb_Click);
            // 
            // btnLemgts
            // 
            this.btnLemgts.Location = new System.Drawing.Point(12, 47);
            this.btnLemgts.Name = "btnLemgts";
            this.btnLemgts.Size = new System.Drawing.Size(140, 23);
            this.btnLemgts.TabIndex = 3;
            this.btnLemgts.Text = "Lenguajes Emergentes";
            this.btnLemgts.UseVisualStyleBackColor = true;
            this.btnLemgts.Click += new System.EventHandler(this.btnLemgts_Click);
            // 
            // btnEtica
            // 
            this.btnEtica.Location = new System.Drawing.Point(12, 18);
            this.btnEtica.Name = "btnEtica";
            this.btnEtica.Size = new System.Drawing.Size(75, 23);
            this.btnEtica.TabIndex = 4;
            this.btnEtica.Text = "Etica Profecional";
            this.btnEtica.UseVisualStyleBackColor = true;
            this.btnEtica.Click += new System.EventHandler(this.btnEtica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por MarcuXo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEtica);
            this.Controls.Add(this.btnLemgts);
            this.Controls.Add(this.btnSweb);
            this.Controls.Add(this.btnPnet);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.Text = "CalculadoraRamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPnet;
        private System.Windows.Forms.Button btnSweb;
        private System.Windows.Forms.Button btnLemgts;
        private System.Windows.Forms.Button btnEtica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;



    }
}

