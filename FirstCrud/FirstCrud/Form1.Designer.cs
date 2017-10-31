namespace FirstCrud
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surNameBox = new System.Windows.Forms.TextBox();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(77, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(169, 20);
            this.nameBox.TabIndex = 0;
            // 
            // surNameBox
            // 
            this.surNameBox.Location = new System.Drawing.Point(77, 104);
            this.surNameBox.Name = "surNameBox";
            this.surNameBox.Size = new System.Drawing.Size(169, 20);
            this.surNameBox.TabIndex = 0;
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(77, 177);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(426, 118);
            this.CommentBox.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(445, 301);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 391);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.surNameBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surNameBox;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button Send;
    }
}

