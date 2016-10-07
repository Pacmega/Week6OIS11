namespace Opdr2
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
            this.R1box = new System.Windows.Forms.TextBox();
            this.R2box = new System.Windows.Forms.TextBox();
            this.R3box = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.OppLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R1box
            // 
            this.R1box.Location = new System.Drawing.Point(111, 12);
            this.R1box.Name = "R1box";
            this.R1box.Size = new System.Drawing.Size(100, 20);
            this.R1box.TabIndex = 0;
            // 
            // R2box
            // 
            this.R2box.Location = new System.Drawing.Point(111, 39);
            this.R2box.Name = "R2box";
            this.R2box.Size = new System.Drawing.Size(100, 20);
            this.R2box.TabIndex = 1;
            // 
            // R3box
            // 
            this.R3box.Location = new System.Drawing.Point(111, 66);
            this.R3box.Name = "R3box";
            this.R3box.Size = new System.Drawing.Size(100, 20);
            this.R3box.TabIndex = 2;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(15, 94);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(196, 23);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Bereken totale oppervlakte";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // OppLabel
            // 
            this.OppLabel.AutoSize = true;
            this.OppLabel.Location = new System.Drawing.Point(12, 125);
            this.OppLabel.Name = "OppLabel";
            this.OppLabel.Size = new System.Drawing.Size(185, 13);
            this.OppLabel.TabIndex = 4;
            this.OppLabel.Text = "Totale oppervlakte drie rechthoeken: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zijde rechthoek 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zijde rechthoek 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zijde rechthoek 3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 149);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OppLabel);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.R3box);
            this.Controls.Add(this.R2box);
            this.Controls.Add(this.R1box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox R1box;
        private System.Windows.Forms.TextBox R2box;
        private System.Windows.Forms.TextBox R3box;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label OppLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

