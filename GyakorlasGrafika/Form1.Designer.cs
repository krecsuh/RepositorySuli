namespace GyakorlasGrafika
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
            this.checkBoxKaveKrem = new System.Windows.Forms.CheckBox();
            this.checkBoxTejszin = new System.Windows.Forms.CheckBox();
            this.checkBoxTejpor = new System.Windows.Forms.CheckBox();
            this.radioButtonEspresso = new System.Windows.Forms.RadioButton();
            this.radioButtonDuplaKave = new System.Windows.Forms.RadioButton();
            this.radioButtonHosszuKave = new System.Windows.Forms.RadioButton();
            this.radioButtonCukorSok = new System.Windows.Forms.RadioButton();
            this.radioButtonCukorKeves = new System.Windows.Forms.RadioButton();
            this.radioButtonCukorNelkul = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFizetes = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.Kiegeszitok = new System.Windows.Forms.GroupBox();
            this.checkBoxCitrom = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOsszesenAr = new System.Windows.Forms.TextBox();
            this.textBoxCukorAr = new System.Windows.Forms.TextBox();
            this.textBoxHozzavaloAr = new System.Windows.Forms.TextBox();
            this.textBoxItalAr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBankkartya = new System.Windows.Forms.Button();
            this.buttonKeszpenz = new System.Windows.Forms.Button();
            this.labelTajekoztatas = new System.Windows.Forms.Label();
            this.textBoxGep = new System.Windows.Forms.TextBox();
            this.buttonPenzBedobas = new System.Windows.Forms.Button();
            this.groupBoxKeszpenz = new System.Windows.Forms.GroupBox();
            this.RESET = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Kiegeszitok.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxKeszpenz.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxKaveKrem
            // 
            this.checkBoxKaveKrem.AutoSize = true;
            this.checkBoxKaveKrem.Location = new System.Drawing.Point(6, 19);
            this.checkBoxKaveKrem.Name = "checkBoxKaveKrem";
            this.checkBoxKaveKrem.Size = new System.Drawing.Size(73, 17);
            this.checkBoxKaveKrem.TabIndex = 0;
            this.checkBoxKaveKrem.Text = "kávékrém";
            this.checkBoxKaveKrem.UseVisualStyleBackColor = true;
            this.checkBoxKaveKrem.CheckedChanged += new System.EventHandler(this.checkBoxKávéKrém_CheckedChanged);
            // 
            // checkBoxTejszin
            // 
            this.checkBoxTejszin.AutoSize = true;
            this.checkBoxTejszin.Location = new System.Drawing.Point(81, 19);
            this.checkBoxTejszin.Name = "checkBoxTejszin";
            this.checkBoxTejszin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxTejszin.TabIndex = 1;
            this.checkBoxTejszin.Text = "tejszin";
            this.checkBoxTejszin.UseVisualStyleBackColor = true;
            this.checkBoxTejszin.CheckedChanged += new System.EventHandler(this.checkBoxTejszin_CheckedChanged);
            // 
            // checkBoxTejpor
            // 
            this.checkBoxTejpor.AutoSize = true;
            this.checkBoxTejpor.Location = new System.Drawing.Point(142, 19);
            this.checkBoxTejpor.Name = "checkBoxTejpor";
            this.checkBoxTejpor.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTejpor.TabIndex = 2;
            this.checkBoxTejpor.Text = "tejpor";
            this.checkBoxTejpor.UseVisualStyleBackColor = true;
            this.checkBoxTejpor.CheckedChanged += new System.EventHandler(this.checkBoxTejpor_CheckedChanged);
            // 
            // radioButtonEspresso
            // 
            this.radioButtonEspresso.AutoSize = true;
            this.radioButtonEspresso.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEspresso.Name = "radioButtonEspresso";
            this.radioButtonEspresso.Size = new System.Drawing.Size(67, 17);
            this.radioButtonEspresso.TabIndex = 3;
            this.radioButtonEspresso.TabStop = true;
            this.radioButtonEspresso.Text = "espresso";
            this.radioButtonEspresso.UseVisualStyleBackColor = true;
            this.radioButtonEspresso.CheckedChanged += new System.EventHandler(this.radioButtonEspresso_CheckedChanged);
            // 
            // radioButtonDuplaKave
            // 
            this.radioButtonDuplaKave.AutoSize = true;
            this.radioButtonDuplaKave.Location = new System.Drawing.Point(79, 20);
            this.radioButtonDuplaKave.Name = "radioButtonDuplaKave";
            this.radioButtonDuplaKave.Size = new System.Drawing.Size(78, 17);
            this.radioButtonDuplaKave.TabIndex = 4;
            this.radioButtonDuplaKave.TabStop = true;
            this.radioButtonDuplaKave.Text = "dupla kávé";
            this.radioButtonDuplaKave.UseVisualStyleBackColor = true;
            this.radioButtonDuplaKave.CheckedChanged += new System.EventHandler(this.radioButtonDuplaKave_CheckedChanged);
            // 
            // radioButtonHosszuKave
            // 
            this.radioButtonHosszuKave.AutoSize = true;
            this.radioButtonHosszuKave.Location = new System.Drawing.Point(163, 20);
            this.radioButtonHosszuKave.Name = "radioButtonHosszuKave";
            this.radioButtonHosszuKave.Size = new System.Drawing.Size(85, 17);
            this.radioButtonHosszuKave.TabIndex = 5;
            this.radioButtonHosszuKave.TabStop = true;
            this.radioButtonHosszuKave.Text = "hosszú kávé";
            this.radioButtonHosszuKave.UseVisualStyleBackColor = true;
            this.radioButtonHosszuKave.CheckedChanged += new System.EventHandler(this.radioButtonHosszuKave_CheckedChanged);
            // 
            // radioButtonCukorSok
            // 
            this.radioButtonCukorSok.AutoSize = true;
            this.radioButtonCukorSok.Location = new System.Drawing.Point(17, 19);
            this.radioButtonCukorSok.Name = "radioButtonCukorSok";
            this.radioButtonCukorSok.Size = new System.Drawing.Size(72, 17);
            this.radioButtonCukorSok.TabIndex = 6;
            this.radioButtonCukorSok.Text = "sok cukor";
            this.radioButtonCukorSok.UseVisualStyleBackColor = true;
            this.radioButtonCukorSok.CheckedChanged += new System.EventHandler(this.radioButtonCukorSok_CheckedChanged);
            // 
            // radioButtonCukorKeves
            // 
            this.radioButtonCukorKeves.AutoSize = true;
            this.radioButtonCukorKeves.Location = new System.Drawing.Point(95, 20);
            this.radioButtonCukorKeves.Name = "radioButtonCukorKeves";
            this.radioButtonCukorKeves.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCukorKeves.TabIndex = 7;
            this.radioButtonCukorKeves.Text = "kevés cukor";
            this.radioButtonCukorKeves.UseVisualStyleBackColor = true;
            this.radioButtonCukorKeves.CheckedChanged += new System.EventHandler(this.radioButtonCukorKeves_CheckedChanged);
            // 
            // radioButtonCukorNelkul
            // 
            this.radioButtonCukorNelkul.AutoSize = true;
            this.radioButtonCukorNelkul.Checked = true;
            this.radioButtonCukorNelkul.Location = new System.Drawing.Point(184, 20);
            this.radioButtonCukorNelkul.Name = "radioButtonCukorNelkul";
            this.radioButtonCukorNelkul.Size = new System.Drawing.Size(83, 17);
            this.radioButtonCukorNelkul.TabIndex = 8;
            this.radioButtonCukorNelkul.TabStop = true;
            this.radioButtonCukorNelkul.Text = "cukor nélkül";
            this.radioButtonCukorNelkul.UseVisualStyleBackColor = true;
            this.radioButtonCukorNelkul.CheckedChanged += new System.EventHandler(this.radioButtonCukorNelkul_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTea);
            this.groupBox1.Controls.Add(this.radioButtonEspresso);
            this.groupBox1.Controls.Add(this.radioButtonDuplaKave);
            this.groupBox1.Controls.Add(this.radioButtonHosszuKave);
            this.groupBox1.Location = new System.Drawing.Point(351, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forró italok";
            // 
            // radioButtonTea
            // 
            this.radioButtonTea.AutoSize = true;
            this.radioButtonTea.Location = new System.Drawing.Point(254, 20);
            this.radioButtonTea.Name = "radioButtonTea";
            this.radioButtonTea.Size = new System.Drawing.Size(40, 17);
            this.radioButtonTea.TabIndex = 6;
            this.radioButtonTea.TabStop = true;
            this.radioButtonTea.Text = "tea";
            this.radioButtonTea.UseVisualStyleBackColor = true;
            this.radioButtonTea.CheckedChanged += new System.EventHandler(this.radioButtonTea_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCukorSok);
            this.groupBox2.Controls.Add(this.radioButtonCukorKeves);
            this.groupBox2.Controls.Add(this.radioButtonCukorNelkul);
            this.groupBox2.Location = new System.Drawing.Point(54, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cukor";
            // 
            // buttonFizetes
            // 
            this.buttonFizetes.Location = new System.Drawing.Point(111, 275);
            this.buttonFizetes.Name = "buttonFizetes";
            this.buttonFizetes.Size = new System.Drawing.Size(254, 48);
            this.buttonFizetes.TabIndex = 11;
            this.buttonFizetes.Text = "Fizetés";
            this.buttonFizetes.UseVisualStyleBackColor = true;
            this.buttonFizetes.Click += new System.EventHandler(this.buttonGomb_Click);
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(6, 56);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(49, 13);
            this.labelEredmeny.TabIndex = 13;
            this.labelEredmeny.Text = "No result";
            this.labelEredmeny.Click += new System.EventHandler(this.labelEredmeny_Click);
            // 
            // Kiegeszitok
            // 
            this.Kiegeszitok.Controls.Add(this.checkBoxCitrom);
            this.Kiegeszitok.Controls.Add(this.checkBoxKaveKrem);
            this.Kiegeszitok.Controls.Add(this.checkBoxTejszin);
            this.Kiegeszitok.Controls.Add(this.checkBoxTejpor);
            this.Kiegeszitok.Location = new System.Drawing.Point(229, 12);
            this.Kiegeszitok.Name = "Kiegeszitok";
            this.Kiegeszitok.Size = new System.Drawing.Size(265, 55);
            this.Kiegeszitok.TabIndex = 14;
            this.Kiegeszitok.TabStop = false;
            this.Kiegeszitok.Text = "Kiegészitők";
            this.Kiegeszitok.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBoxCitrom
            // 
            this.checkBoxCitrom.AutoSize = true;
            this.checkBoxCitrom.Location = new System.Drawing.Point(200, 19);
            this.checkBoxCitrom.Name = "checkBoxCitrom";
            this.checkBoxCitrom.Size = new System.Drawing.Size(54, 17);
            this.checkBoxCitrom.TabIndex = 3;
            this.checkBoxCitrom.Text = "citrom";
            this.checkBoxCitrom.UseVisualStyleBackColor = true;
            this.checkBoxCitrom.CheckedChanged += new System.EventHandler(this.checkBoxCitrom_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOsszesenAr);
            this.groupBox3.Controls.Add(this.textBoxCukorAr);
            this.groupBox3.Controls.Add(this.textBoxHozzavaloAr);
            this.groupBox3.Controls.Add(this.textBoxItalAr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(271, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 120);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fizetés";
            // 
            // textBoxOsszesenAr
            // 
            this.textBoxOsszesenAr.Location = new System.Drawing.Point(63, 89);
            this.textBoxOsszesenAr.Name = "textBoxOsszesenAr";
            this.textBoxOsszesenAr.ReadOnly = true;
            this.textBoxOsszesenAr.Size = new System.Drawing.Size(68, 20);
            this.textBoxOsszesenAr.TabIndex = 7;
            // 
            // textBoxCukorAr
            // 
            this.textBoxCukorAr.Location = new System.Drawing.Point(63, 63);
            this.textBoxCukorAr.Name = "textBoxCukorAr";
            this.textBoxCukorAr.ReadOnly = true;
            this.textBoxCukorAr.Size = new System.Drawing.Size(68, 20);
            this.textBoxCukorAr.TabIndex = 6;
            // 
            // textBoxHozzavaloAr
            // 
            this.textBoxHozzavaloAr.Location = new System.Drawing.Point(63, 44);
            this.textBoxHozzavaloAr.Name = "textBoxHozzavaloAr";
            this.textBoxHozzavaloAr.ReadOnly = true;
            this.textBoxHozzavaloAr.Size = new System.Drawing.Size(68, 20);
            this.textBoxHozzavaloAr.TabIndex = 5;
            // 
            // textBoxItalAr
            // 
            this.textBoxItalAr.Location = new System.Drawing.Point(63, 21);
            this.textBoxItalAr.Name = "textBoxItalAr";
            this.textBoxItalAr.ReadOnly = true;
            this.textBoxItalAr.Size = new System.Drawing.Size(68, 20);
            this.textBoxItalAr.TabIndex = 4;
            this.textBoxItalAr.TextChanged += new System.EventHandler(this.textBoxItalAr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Összesen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cukor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hozzávaló:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ital:";
            // 
            // buttonBankkartya
            // 
            this.buttonBankkartya.Location = new System.Drawing.Point(430, 256);
            this.buttonBankkartya.Name = "buttonBankkartya";
            this.buttonBankkartya.Size = new System.Drawing.Size(192, 47);
            this.buttonBankkartya.TabIndex = 16;
            this.buttonBankkartya.Text = "Bankkártya";
            this.buttonBankkartya.UseVisualStyleBackColor = true;
            this.buttonBankkartya.Visible = false;
            this.buttonBankkartya.Click += new System.EventHandler(this.buttonBankkartya_Click);
            // 
            // buttonKeszpenz
            // 
            this.buttonKeszpenz.Location = new System.Drawing.Point(430, 309);
            this.buttonKeszpenz.Name = "buttonKeszpenz";
            this.buttonKeszpenz.Size = new System.Drawing.Size(192, 47);
            this.buttonKeszpenz.TabIndex = 17;
            this.buttonKeszpenz.Text = "Készpénz";
            this.buttonKeszpenz.UseVisualStyleBackColor = true;
            this.buttonKeszpenz.Visible = false;
            this.buttonKeszpenz.Click += new System.EventHandler(this.buttonKeszpenz_Click);
            // 
            // labelTajekoztatas
            // 
            this.labelTajekoztatas.AutoSize = true;
            this.labelTajekoztatas.Location = new System.Drawing.Point(6, 16);
            this.labelTajekoztatas.Name = "labelTajekoztatas";
            this.labelTajekoztatas.Size = new System.Drawing.Size(171, 13);
            this.labelTajekoztatas.TabIndex = 18;
            this.labelTajekoztatas.Text = "Mennyi készpénzt dobsz a gépbe?";
            // 
            // textBoxGep
            // 
            this.textBoxGep.Location = new System.Drawing.Point(61, 32);
            this.textBoxGep.Name = "textBoxGep";
            this.textBoxGep.Size = new System.Drawing.Size(114, 20);
            this.textBoxGep.TabIndex = 8;
            // 
            // buttonPenzBedobas
            // 
            this.buttonPenzBedobas.Location = new System.Drawing.Point(86, 71);
            this.buttonPenzBedobas.Name = "buttonPenzBedobas";
            this.buttonPenzBedobas.Size = new System.Drawing.Size(114, 29);
            this.buttonPenzBedobas.TabIndex = 19;
            this.buttonPenzBedobas.Text = "Bedob";
            this.buttonPenzBedobas.UseVisualStyleBackColor = true;
            this.buttonPenzBedobas.Click += new System.EventHandler(this.buttonPenzBedobas_Click);
            // 
            // groupBoxKeszpenz
            // 
            this.groupBoxKeszpenz.Controls.Add(this.labelTajekoztatas);
            this.groupBoxKeszpenz.Controls.Add(this.buttonPenzBedobas);
            this.groupBoxKeszpenz.Controls.Add(this.textBoxGep);
            this.groupBoxKeszpenz.Controls.Add(this.labelEredmeny);
            this.groupBoxKeszpenz.Location = new System.Drawing.Point(149, 353);
            this.groupBoxKeszpenz.Name = "groupBoxKeszpenz";
            this.groupBoxKeszpenz.Size = new System.Drawing.Size(200, 100);
            this.groupBoxKeszpenz.TabIndex = 20;
            this.groupBoxKeszpenz.TabStop = false;
            this.groupBoxKeszpenz.Text = "Készpénzes Fizetés";
            this.groupBoxKeszpenz.Visible = false;
            this.groupBoxKeszpenz.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // RESET
            // 
            this.RESET.ForeColor = System.Drawing.Color.Red;
            this.RESET.Location = new System.Drawing.Point(407, 362);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(255, 100);
            this.RESET.TabIndex = 22;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 480);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.groupBoxKeszpenz);
            this.Controls.Add(this.buttonKeszpenz);
            this.Controls.Add(this.buttonBankkartya);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Kiegeszitok);
            this.Controls.Add(this.buttonFizetes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "cukor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Kiegeszitok.ResumeLayout(false);
            this.Kiegeszitok.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxKeszpenz.ResumeLayout(false);
            this.groupBoxKeszpenz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKaveKrem;
        private System.Windows.Forms.CheckBox checkBoxTejszin;
        private System.Windows.Forms.CheckBox checkBoxTejpor;
        private System.Windows.Forms.RadioButton radioButtonEspresso;
        private System.Windows.Forms.RadioButton radioButtonDuplaKave;
        private System.Windows.Forms.RadioButton radioButtonHosszuKave;
        private System.Windows.Forms.RadioButton radioButtonCukorSok;
        private System.Windows.Forms.RadioButton radioButtonCukorKeves;
        private System.Windows.Forms.RadioButton radioButtonCukorNelkul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFizetes;
        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.GroupBox Kiegeszitok;
        private System.Windows.Forms.CheckBox checkBoxCitrom;
        private System.Windows.Forms.RadioButton radioButtonTea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOsszesenAr;
        private System.Windows.Forms.TextBox textBoxCukorAr;
        private System.Windows.Forms.TextBox textBoxHozzavaloAr;
        private System.Windows.Forms.TextBox textBoxItalAr;
        private System.Windows.Forms.Button buttonBankkartya;
        private System.Windows.Forms.Button buttonKeszpenz;
        private System.Windows.Forms.Label labelTajekoztatas;
        private System.Windows.Forms.TextBox textBoxGep;
        private System.Windows.Forms.Button buttonPenzBedobas;
        private System.Windows.Forms.GroupBox groupBoxKeszpenz;
        private System.Windows.Forms.Button RESET;
    }
}

