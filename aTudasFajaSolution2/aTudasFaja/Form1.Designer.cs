namespace aTudasFaja
{
    partial class aTudasFajaForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.labelKerdes = new System.Windows.Forms.Label();
            this.buttonValaszA = new System.Windows.Forms.Button();
            this.buttonValaszB = new System.Windows.Forms.Button();
            this.buttonValaszC = new System.Windows.Forms.Button();
            this.buttonValaszD = new System.Windows.Forms.Button();
            this.labelValaszA = new System.Windows.Forms.Label();
            this.labelValaszB = new System.Windows.Forms.Label();
            this.labelValaszC = new System.Windows.Forms.Label();
            this.labelValaszD = new System.Windows.Forms.Label();
            this.labelMagyarazat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelElet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(500, 708);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(145, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Kezdés";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(732, 708);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(145, 40);
            this.buttonNextQuestion.TabIndex = 1;
            this.buttonNextQuestion.Text = "A következő kérdés";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Visible = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // labelKerdes
            // 
            this.labelKerdes.AutoSize = true;
            this.labelKerdes.Font = new System.Drawing.Font("Minecraftia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKerdes.ForeColor = System.Drawing.Color.Red;
            this.labelKerdes.Location = new System.Drawing.Point(398, 310);
            this.labelKerdes.Name = "labelKerdes";
            this.labelKerdes.Size = new System.Drawing.Size(196, 65);
            this.labelKerdes.TabIndex = 2;
            this.labelKerdes.Text = "Kérdés";
            this.labelKerdes.UseMnemonic = false;
            this.labelKerdes.Visible = false;
            this.labelKerdes.Click += new System.EventHandler(this.labelKerdes_Click);
            // 
            // buttonValaszA
            // 
            this.buttonValaszA.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValaszA.Location = new System.Drawing.Point(398, 473);
            this.buttonValaszA.Name = "buttonValaszA";
            this.buttonValaszA.Size = new System.Drawing.Size(204, 64);
            this.buttonValaszA.TabIndex = 3;
            this.buttonValaszA.Text = "A";
            this.buttonValaszA.UseVisualStyleBackColor = true;
            this.buttonValaszA.Visible = false;
            // 
            // buttonValaszB
            // 
            this.buttonValaszB.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValaszB.Location = new System.Drawing.Point(673, 473);
            this.buttonValaszB.Name = "buttonValaszB";
            this.buttonValaszB.Size = new System.Drawing.Size(204, 64);
            this.buttonValaszB.TabIndex = 4;
            this.buttonValaszB.Text = "B";
            this.buttonValaszB.UseVisualStyleBackColor = true;
            this.buttonValaszB.Visible = false;
            // 
            // buttonValaszC
            // 
            this.buttonValaszC.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValaszC.Location = new System.Drawing.Point(925, 473);
            this.buttonValaszC.Name = "buttonValaszC";
            this.buttonValaszC.Size = new System.Drawing.Size(204, 64);
            this.buttonValaszC.TabIndex = 5;
            this.buttonValaszC.Text = "C";
            this.buttonValaszC.UseVisualStyleBackColor = true;
            this.buttonValaszC.Visible = false;
            // 
            // buttonValaszD
            // 
            this.buttonValaszD.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValaszD.Location = new System.Drawing.Point(1157, 473);
            this.buttonValaszD.Name = "buttonValaszD";
            this.buttonValaszD.Size = new System.Drawing.Size(204, 64);
            this.buttonValaszD.TabIndex = 6;
            this.buttonValaszD.Text = "D";
            this.buttonValaszD.UseVisualStyleBackColor = true;
            this.buttonValaszD.Visible = false;
            // 
            // labelValaszA
            // 
            this.labelValaszA.AutoSize = true;
            this.labelValaszA.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValaszA.Location = new System.Drawing.Point(472, 578);
            this.labelValaszA.Name = "labelValaszA";
            this.labelValaszA.Size = new System.Drawing.Size(45, 13);
            this.labelValaszA.TabIndex = 7;
            this.labelValaszA.Text = "Válasz";
            this.labelValaszA.Visible = false;
            // 
            // labelValaszB
            // 
            this.labelValaszB.AutoSize = true;
            this.labelValaszB.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValaszB.Location = new System.Drawing.Point(769, 583);
            this.labelValaszB.Name = "labelValaszB";
            this.labelValaszB.Size = new System.Drawing.Size(45, 13);
            this.labelValaszB.TabIndex = 8;
            this.labelValaszB.Text = "Válasz";
            this.labelValaszB.Visible = false;
            // 
            // labelValaszC
            // 
            this.labelValaszC.AutoSize = true;
            this.labelValaszC.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValaszC.Location = new System.Drawing.Point(1027, 578);
            this.labelValaszC.Name = "labelValaszC";
            this.labelValaszC.Size = new System.Drawing.Size(45, 13);
            this.labelValaszC.TabIndex = 9;
            this.labelValaszC.Text = "Válasz";
            this.labelValaszC.Visible = false;
            // 
            // labelValaszD
            // 
            this.labelValaszD.AutoSize = true;
            this.labelValaszD.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValaszD.Location = new System.Drawing.Point(1241, 578);
            this.labelValaszD.Name = "labelValaszD";
            this.labelValaszD.Size = new System.Drawing.Size(45, 13);
            this.labelValaszD.TabIndex = 10;
            this.labelValaszD.Text = "Válasz";
            this.labelValaszD.Visible = false;
            // 
            // labelMagyarazat
            // 
            this.labelMagyarazat.AutoSize = true;
            this.labelMagyarazat.Font = new System.Drawing.Font("Minecraftia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagyarazat.Location = new System.Drawing.Point(1132, 751);
            this.labelMagyarazat.Name = "labelMagyarazat";
            this.labelMagyarazat.Size = new System.Drawing.Size(315, 33);
            this.labelMagyarazat.TabIndex = 11;
            this.labelMagyarazat.Text = "............................................................";
            this.labelMagyarazat.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1130, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Magyarázat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelElet
            // 
            this.labelElet.AutoSize = true;
            this.labelElet.Font = new System.Drawing.Font("Minecraftia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelElet.Location = new System.Drawing.Point(202, 258);
            this.labelElet.Name = "labelElet";
            this.labelElet.Size = new System.Drawing.Size(60, 23);
            this.labelElet.TabIndex = 13;
            this.labelElet.Text = "Életek";
            this.labelElet.Visible = false;
            // 
            // aTudasFajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aTudasFaja.Properties.Resources.ChatGPT_Image_2026__márc__2__08_10_26;
            this.ClientSize = new System.Drawing.Size(1392, 806);
            this.Controls.Add(this.labelElet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMagyarazat);
            this.Controls.Add(this.labelValaszD);
            this.Controls.Add(this.labelValaszC);
            this.Controls.Add(this.labelValaszB);
            this.Controls.Add(this.labelValaszA);
            this.Controls.Add(this.buttonValaszD);
            this.Controls.Add(this.buttonValaszC);
            this.Controls.Add(this.buttonValaszB);
            this.Controls.Add(this.buttonValaszA);
            this.Controls.Add(this.labelKerdes);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.buttonStart);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "aTudasFajaForm";
            this.Text = "A Tudás fája";
            this.Load += new System.EventHandler(this.aTudasFajaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelKerdes;
        private System.Windows.Forms.Button buttonValaszA;
        private System.Windows.Forms.Button buttonValaszB;
        private System.Windows.Forms.Button buttonValaszC;
        private System.Windows.Forms.Button buttonValaszD;
        private System.Windows.Forms.Label labelValaszA;
        private System.Windows.Forms.Label labelValaszB;
        private System.Windows.Forms.Label labelValaszC;
        private System.Windows.Forms.Label labelValaszD;
        private System.Windows.Forms.Label labelMagyarazat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelElet;
    }
}

