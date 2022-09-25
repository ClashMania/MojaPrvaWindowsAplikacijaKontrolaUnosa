namespace MojaPrvaWindowsAplikacija
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
            this.txtUnosBrojaA = new System.Windows.Forms.TextBox();
            this.txtUnosBrojaB = new System.Windows.Forms.TextBox();
            this.txtIzlazBrojaA = new System.Windows.Forms.TextBox();
            this.Lable1 = new System.Windows.Forms.Label();
            this.Lable2 = new System.Windows.Forms.Label();
            this.Lable3 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.Greska = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnosBrojaA
            // 
            this.txtUnosBrojaA.Location = new System.Drawing.Point(104, 85);
            this.txtUnosBrojaA.Name = "txtUnosBrojaA";
            this.txtUnosBrojaA.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrojaA.TabIndex = 0;
            // 
            // txtUnosBrojaB
            // 
            this.txtUnosBrojaB.Location = new System.Drawing.Point(603, 85);
            this.txtUnosBrojaB.Name = "txtUnosBrojaB";
            this.txtUnosBrojaB.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrojaB.TabIndex = 1;
            // 
            // txtIzlazBrojaA
            // 
            this.txtIzlazBrojaA.Location = new System.Drawing.Point(101, 257);
            this.txtIzlazBrojaA.Name = "txtIzlazBrojaA";
            this.txtIzlazBrojaA.ReadOnly = true;
            this.txtIzlazBrojaA.Size = new System.Drawing.Size(100, 20);
            this.txtIzlazBrojaA.TabIndex = 6;
            this.txtIzlazBrojaA.TabStop = false;
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(104, 66);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(35, 13);
            this.Lable1.TabIndex = 3;
            this.Lable1.Text = "Broj A";
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Location = new System.Drawing.Point(603, 66);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(35, 13);
            this.Lable2.TabIndex = 4;
            this.Lable2.Text = "Broj B";
            // 
            // Lable3
            // 
            this.Lable3.AutoSize = true;
            this.Lable3.Location = new System.Drawing.Point(101, 241);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(31, 13);
            this.Lable3.TabIndex = 5;
            this.Lable3.Text = "Zbroj";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzracun.Location = new System.Drawing.Point(606, 257);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 2;
            this.btnIzracun.Text = "Izračunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // Greska
            // 
            this.Greska.Location = new System.Drawing.Point(317, 331);
            this.Greska.Multiline = true;
            this.Greska.Name = "Greska";
            this.Greska.ReadOnly = true;
            this.Greska.Size = new System.Drawing.Size(159, 62);
            this.Greska.TabIndex = 7;
            this.Greska.TextChanged += new System.EventHandler(this.Greska_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(317, 312);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Greške";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Greska);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.Lable3);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.txtIzlazBrojaA);
            this.Controls.Add(this.txtUnosBrojaB);
            this.Controls.Add(this.txtUnosBrojaA);
            this.Name = "Form1";
            this.Text = "Moja prva Windows aplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBrojaA;
        private System.Windows.Forms.TextBox txtUnosBrojaB;
        private System.Windows.Forms.TextBox txtIzlazBrojaA;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.Label Lable3;
        private System.Windows.Forms.Button btnIzracun;
        private System.Windows.Forms.TextBox Greska;
        private System.Windows.Forms.Label Label4;
    }
}

