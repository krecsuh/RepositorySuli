namespace Grafika_1
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.ColorChanger = new System.Windows.Forms.Button();
            this.eredmenyLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.szam1 = new System.Windows.Forms.TextBox();
            this.szam2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 117);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(84, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Felhasználónév:";
            this.labelUserName.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(86, 91);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(80, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Módosítva";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(15, 65);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(236, 20);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ColorChanger
            // 
            this.ColorChanger.Location = new System.Drawing.Point(59, 187);
            this.ColorChanger.Name = "ColorChanger";
            this.ColorChanger.Size = new System.Drawing.Size(154, 23);
            this.ColorChanger.TabIndex = 5;
            this.ColorChanger.Text = "ColorChanger";
            this.ColorChanger.UseVisualStyleBackColor = true;
            this.ColorChanger.Click += new System.EventHandler(this.ColorChanger_Click);
            // 
            // eredmenyLabel
            // 
            this.eredmenyLabel.AutoSize = true;
            this.eredmenyLabel.Location = new System.Drawing.Point(383, 126);
            this.eredmenyLabel.Name = "eredmenyLabel";
            this.eredmenyLabel.Size = new System.Drawing.Size(56, 13);
            this.eredmenyLabel.TabIndex = 8;
            this.eredmenyLabel.Text = "eredmény:";
            this.eredmenyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(298, 148);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 9;
            this.sum.Text = "sum";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // szam1
            // 
            this.szam1.Location = new System.Drawing.Point(287, 103);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(100, 20);
            this.szam1.TabIndex = 10;
            this.szam1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // szam2
            // 
            this.szam2.Location = new System.Drawing.Point(419, 103);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(100, 20);
            this.szam2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "szorzás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(206, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grafika_1.Properties.Resources.Képernyőkép_2026_01_05_120712;
            this.ClientSize = new System.Drawing.Size(520, 318);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.eredmenyLabel);
            this.Controls.Add(this.ColorChanger);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12A elso grafikus programja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button ColorChanger;
        private System.Windows.Forms.Label eredmenyLabel;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.TextBox szam1;
        private System.Windows.Forms.TextBox szam2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

