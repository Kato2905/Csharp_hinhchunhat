﻿namespace Csharp_hinhchunhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(300, 142);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(224, 36);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(300, 46);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(224, 36);
            this.txtb.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(300, 249);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(224, 36);
            this.txtkq.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chu vi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(541, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "Diện tích";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

