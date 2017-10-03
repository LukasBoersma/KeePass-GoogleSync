namespace GoogleSyncPlugin
{
	partial class GoogleAuthenticateForm
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
			this.SuspendLayout();

			this.codeLabel = new System.Windows.Forms.Label ();
			this.codeLabel.Left = 20;
			this.codeLabel.Top = 20;
			this.codeLabel.Width = 400;
			this.codeLabel.Text = "Complete the authentication in the browser. Enter the resulting code here:";

			this.codeInput = new System.Windows.Forms.TextBox ();
			this.codeInput.Top = 50;
			this.codeInput.Left = 20;
			this.codeInput.Width = 400;

			this.confirmationButton = new System.Windows.Forms.Button ();
			this.confirmationButton.Top = 70;
			this.confirmationButton.Left = 20;
			this.confirmationButton.Width = 100;
			this.confirmationButton.Text = "OK";
			this.confirmationButton.Click += OnCodeEntered;

			this.cancelButton = new System.Windows.Forms.Button ();
			this.cancelButton.Top = 70;
			this.cancelButton.Left = 130;
			this.cancelButton.Width = 100;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += OnCancelled;

			// 
			// GoogleAuthenticateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 100);
			this.Controls.Add(this.codeLabel);
			this.Controls.Add(this.codeInput);
			this.Controls.Add(this.confirmationButton);
			this.Controls.Add(this.cancelButton);
			this.Name = "GoogleAuthenticateForm";
			this.ShowIcon = false;
			this.Text = "Google Sync Plugin Authorization";
			this.Load += new System.EventHandler(this.GoogleAuthenticateForm_Load);
			this.ResumeLayout(false);
		}

		 #endregion

		private System.Windows.Forms.TextBox codeInput;
		private System.Windows.Forms.Label codeLabel;
		private System.Windows.Forms.Button confirmationButton;
		private System.Windows.Forms.Button cancelButton;
	}
}