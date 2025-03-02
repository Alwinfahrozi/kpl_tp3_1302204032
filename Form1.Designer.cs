namespace tp3_1302204032
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);

            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(20, 60);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);

            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(20, 100);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(120, 20);
            this.outputLabel.Text = "Output akan muncul di sini";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form Input";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
