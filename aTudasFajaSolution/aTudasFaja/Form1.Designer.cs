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
            this.buttonQuestion1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuestion1
            // 
            this.buttonQuestion1.Location = new System.Drawing.Point(59, 65);
            this.buttonQuestion1.Name = "buttonQuestion1";
            this.buttonQuestion1.Size = new System.Drawing.Size(183, 43);
            this.buttonQuestion1.TabIndex = 0;
            this.buttonQuestion1.Text = "button1";
            this.buttonQuestion1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "A következő kérdés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aTudasFajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(772, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonQuestion1);
            this.Name = "aTudasFajaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A tudás fája";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuestion1;
        private System.Windows.Forms.Button button1;
    }
}

