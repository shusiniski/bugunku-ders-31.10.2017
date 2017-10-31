namespace SelectTest
{
    partial class btnSend
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
            this.Namebox = new System.Windows.Forms.TextBox();
            this.surNameBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(76, 47);
            this.Namebox.Multiline = true;
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(249, 28);
            this.Namebox.TabIndex = 0;
            // 
            // surNameBox
            // 
            this.surNameBox.Location = new System.Drawing.Point(76, 81);
            this.surNameBox.Multiline = true;
            this.surNameBox.Name = "surNameBox";
            this.surNameBox.Size = new System.Drawing.Size(249, 28);
            this.surNameBox.TabIndex = 0;
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(200, 132);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(335, 126);
            this.MessageBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.surNameBox);
            this.Controls.Add(this.Namebox);
            this.Name = "btnSend";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox surNameBox;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button button1;
    }
}

