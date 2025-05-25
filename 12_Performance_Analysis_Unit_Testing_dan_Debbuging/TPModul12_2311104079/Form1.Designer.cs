namespace TPModul12_2311104079
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(181, 43);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(297, 20);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(317, 137);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OutputLabel;
    }
}

