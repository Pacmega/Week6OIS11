namespace Week666
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
            this.Ubox = new System.Windows.Forms.TextBox();
            this.Ibox = new System.Windows.Forms.TextBox();
            this.VivaLaResistance = new System.Windows.Forms.Button();
            this.ResLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spanning (V):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stroom (I):";
            // 
            // Ubox
            // 
            this.Ubox.Location = new System.Drawing.Point(90, 10);
            this.Ubox.Name = "Ubox";
            this.Ubox.Size = new System.Drawing.Size(100, 20);
            this.Ubox.TabIndex = 2;
            this.Ubox.Text = "6";
            // 
            // Ibox
            // 
            this.Ibox.Location = new System.Drawing.Point(90, 35);
            this.Ibox.Name = "Ibox";
            this.Ibox.Size = new System.Drawing.Size(100, 20);
            this.Ibox.TabIndex = 3;
            this.Ibox.Text = "6";
            // 
            // VivaLaResistance
            // 
            this.VivaLaResistance.Location = new System.Drawing.Point(90, 62);
            this.VivaLaResistance.Name = "VivaLaResistance";
            this.VivaLaResistance.Size = new System.Drawing.Size(100, 23);
            this.VivaLaResistance.TabIndex = 4;
            this.VivaLaResistance.Text = "Bereken R";
            this.VivaLaResistance.UseVisualStyleBackColor = true;
            this.VivaLaResistance.Click += new System.EventHandler(this.VivaLaResistance_Click);
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.Location = new System.Drawing.Point(13, 95);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(62, 13);
            this.ResLabel.TabIndex = 5;
            this.ResLabel.Text = "Weerstand:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResLabel);
            this.Controls.Add(this.VivaLaResistance);
            this.Controls.Add(this.Ibox);
            this.Controls.Add(this.Ubox);
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
        private System.Windows.Forms.TextBox Ubox;
        private System.Windows.Forms.TextBox Ibox;
        private System.Windows.Forms.Button VivaLaResistance;
        private System.Windows.Forms.Label ResLabel;
    }
}

