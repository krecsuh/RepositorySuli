namespace kekturaForm
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
            this.listBoxUtvonalLista = new System.Windows.Forms.ListBox();
            this.labelSorokSzama = new System.Windows.Forms.Label();
            this.buttonAdatokMegjelenitese = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKiinduloPont = new System.Windows.Forms.TextBox();
            this.textBoxVegPont = new System.Windows.Forms.TextBox();
            this.textBoxSzakaszHosszKm = new System.Windows.Forms.TextBox();
            this.textBoxEmelkedes = new System.Windows.Forms.TextBox();
            this.textBoxLejtes = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxUtvonalLista
            // 
            this.listBoxUtvonalLista.FormattingEnabled = true;
            this.listBoxUtvonalLista.Location = new System.Drawing.Point(12, 12);
            this.listBoxUtvonalLista.Name = "listBoxUtvonalLista";
            this.listBoxUtvonalLista.Size = new System.Drawing.Size(337, 173);
            this.listBoxUtvonalLista.TabIndex = 0;
            // 
            // labelSorokSzama
            // 
            this.labelSorokSzama.AutoSize = true;
            this.labelSorokSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSorokSzama.Location = new System.Drawing.Point(299, 188);
            this.labelSorokSzama.Name = "labelSorokSzama";
            this.labelSorokSzama.Size = new System.Drawing.Size(50, 13);
            this.labelSorokSzama.TabIndex = 1;
            this.labelSorokSzama.Text = "0 darab";
            this.labelSorokSzama.Click += new System.EventHandler(this.labelSorokSzama_Click);
            // 
            // buttonAdatokMegjelenitese
            // 
            this.buttonAdatokMegjelenitese.Location = new System.Drawing.Point(410, 12);
            this.buttonAdatokMegjelenitese.Name = "buttonAdatokMegjelenitese";
            this.buttonAdatokMegjelenitese.Size = new System.Drawing.Size(145, 23);
            this.buttonAdatokMegjelenitese.TabIndex = 2;
            this.buttonAdatokMegjelenitese.Text = "Adatok megjelenítése";
            this.buttonAdatokMegjelenitese.UseVisualStyleBackColor = true;
            this.buttonAdatokMegjelenitese.Click += new System.EventHandler(this.buttonAdatokMegjelenitese_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kiinduló pont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Végpont";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Szakaszhosz (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emelkedés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lejtés";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pecsételőhely";
            // 
            // textBoxKiinduloPont
            // 
            this.textBoxKiinduloPont.Location = new System.Drawing.Point(99, 218);
            this.textBoxKiinduloPont.Name = "textBoxKiinduloPont";
            this.textBoxKiinduloPont.ReadOnly = true;
            this.textBoxKiinduloPont.Size = new System.Drawing.Size(803, 20);
            this.textBoxKiinduloPont.TabIndex = 9;
            // 
            // textBoxVegPont
            // 
            this.textBoxVegPont.Location = new System.Drawing.Point(78, 243);
            this.textBoxVegPont.Name = "textBoxVegPont";
            this.textBoxVegPont.ReadOnly = true;
            this.textBoxVegPont.Size = new System.Drawing.Size(803, 20);
            this.textBoxVegPont.TabIndex = 10;
            // 
            // textBoxSzakaszHosszKm
            // 
            this.textBoxSzakaszHosszKm.Location = new System.Drawing.Point(123, 270);
            this.textBoxSzakaszHosszKm.Name = "textBoxSzakaszHosszKm";
            this.textBoxSzakaszHosszKm.ReadOnly = true;
            this.textBoxSzakaszHosszKm.Size = new System.Drawing.Size(803, 20);
            this.textBoxSzakaszHosszKm.TabIndex = 11;
            // 
            // textBoxEmelkedes
            // 
            this.textBoxEmelkedes.Location = new System.Drawing.Point(90, 296);
            this.textBoxEmelkedes.Name = "textBoxEmelkedes";
            this.textBoxEmelkedes.ReadOnly = true;
            this.textBoxEmelkedes.Size = new System.Drawing.Size(803, 20);
            this.textBoxEmelkedes.TabIndex = 12;
            // 
            // textBoxLejtes
            // 
            this.textBoxLejtes.Location = new System.Drawing.Point(66, 325);
            this.textBoxLejtes.Name = "textBoxLejtes";
            this.textBoxLejtes.ReadOnly = true;
            this.textBoxLejtes.Size = new System.Drawing.Size(803, 20);
            this.textBoxLejtes.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(105, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 653);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxLejtes);
            this.Controls.Add(this.textBoxEmelkedes);
            this.Controls.Add(this.textBoxSzakaszHosszKm);
            this.Controls.Add(this.textBoxVegPont);
            this.Controls.Add(this.textBoxKiinduloPont);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdatokMegjelenitese);
            this.Controls.Add(this.labelSorokSzama);
            this.Controls.Add(this.listBoxUtvonalLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kéktúra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtvonalLista;
        private System.Windows.Forms.Label labelSorokSzama;
        private System.Windows.Forms.Button buttonAdatokMegjelenitese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKiinduloPont;
        private System.Windows.Forms.TextBox textBoxVegPont;
        private System.Windows.Forms.TextBox textBoxSzakaszHosszKm;
        private System.Windows.Forms.TextBox textBoxEmelkedes;
        private System.Windows.Forms.TextBox textBoxLejtes;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

