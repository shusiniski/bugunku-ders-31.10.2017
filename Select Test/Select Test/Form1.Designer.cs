namespace Select_Test
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
            this.userName = new System.Windows.Forms.TextBox();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.userMessage = new System.Windows.Forms.TextBox();
            this.SendBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(134, 52);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(248, 20);
            this.userName.TabIndex = 0;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // userSurname
            // 
            this.userSurname.Location = new System.Drawing.Point(134, 78);
            this.userSurname.Multiline = true;
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(248, 20);
            this.userSurname.TabIndex = 0;
            // 
            // userMessage
            // 
            this.userMessage.Location = new System.Drawing.Point(233, 128);
            this.userMessage.Multiline = true;
            this.userMessage.Name = "userMessage";
            this.userMessage.Size = new System.Drawing.Size(461, 140);
            this.userMessage.TabIndex = 0;
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(619, 274);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(75, 23);
            this.SendBox.TabIndex = 1;
            this.SendBox.Text = "Send";
            this.SendBox.UseVisualStyleBackColor = true;
            this.SendBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 422);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.userMessage);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.TextBox userMessage;
        private System.Windows.Forms.Button SendBox;
    }
}

