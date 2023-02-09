namespace ADB
{
    partial class Form7
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Radiobutton2 = new System.Windows.Forms.RadioButton();
            this.Skriv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Blod";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Radiobutton2
            // 
            this.Radiobutton2.AutoSize = true;
            this.Radiobutton2.Location = new System.Drawing.Point(12, 74);
            this.Radiobutton2.Name = "Radiobutton2";
            this.Radiobutton2.Size = new System.Drawing.Size(59, 21);
            this.Radiobutton2.TabIndex = 1;
            this.Radiobutton2.TabStop = true;
            this.Radiobutton2.Text = "FISH";
            this.Radiobutton2.UseVisualStyleBackColor = true;
            // 
            // Skriv
            // 
            this.Skriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skriv.Location = new System.Drawing.Point(200, 267);
            this.Skriv.Name = "Skriv";
            this.Skriv.Size = new System.Drawing.Size(75, 23);
            this.Skriv.TabIndex = 2;
            this.Skriv.Text = "Skriv";
            this.Skriv.UseVisualStyleBackColor = true;
            this.Skriv.Click += new System.EventHandler(this.Skriv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Skriv);
            this.Controls.Add(this.Radiobutton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Radiobutton2;
        private System.Windows.Forms.Button Skriv;
        private System.Windows.Forms.Button button1;
    }
}