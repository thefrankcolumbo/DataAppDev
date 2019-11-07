namespace AdminGUI
{
   partial class Login
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
         this.txtUserName = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.btnSubmit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtUserName
         // 
         this.txtUserName.Location = new System.Drawing.Point(12, 12);
         this.txtUserName.Name = "txtUserName";
         this.txtUserName.Size = new System.Drawing.Size(144, 20);
         this.txtUserName.TabIndex = 0;
         this.txtUserName.Text = "User Name";
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(12, 38);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '*';
         this.txtPassword.Size = new System.Drawing.Size(144, 20);
         this.txtPassword.TabIndex = 1;
         // 
         // btnSubmit
         // 
         this.btnSubmit.Location = new System.Drawing.Point(13, 65);
         this.btnSubmit.Name = "btnSubmit";
         this.btnSubmit.Size = new System.Drawing.Size(143, 23);
         this.btnSubmit.TabIndex = 2;
         this.btnSubmit.Text = "Submit";
         this.btnSubmit.UseVisualStyleBackColor = true;
         this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(168, 106);
         this.Controls.Add(this.btnSubmit);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUserName);
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtUserName;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Button btnSubmit;
   }
}

