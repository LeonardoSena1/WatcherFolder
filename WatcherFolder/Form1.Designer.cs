namespace WatcherFolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFolder = new System.Windows.Forms.Label();
            this.TextBoxPathFolder = new System.Windows.Forms.TextBox();
            this.ButtonCreateOrUpdateFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFolder
            // 
            this.LabelFolder.AutoSize = true;
            this.LabelFolder.Location = new System.Drawing.Point(21, 30);
            this.LabelFolder.Name = "LabelFolder";
            this.LabelFolder.Size = new System.Drawing.Size(35, 15);
            this.LabelFolder.TabIndex = 0;
            this.LabelFolder.Text = "Pasta";
            // 
            // TextBoxPathFolder
            // 
            this.TextBoxPathFolder.Location = new System.Drawing.Point(62, 27);
            this.TextBoxPathFolder.Name = "TextBoxPathFolder";
            this.TextBoxPathFolder.Size = new System.Drawing.Size(267, 23);
            this.TextBoxPathFolder.TabIndex = 1;
            // 
            // ButtonCreateOrUpdateFolder
            // 
            this.ButtonCreateOrUpdateFolder.Location = new System.Drawing.Point(335, 27);
            this.ButtonCreateOrUpdateFolder.Name = "ButtonCreateOrUpdateFolder";
            this.ButtonCreateOrUpdateFolder.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateOrUpdateFolder.TabIndex = 2;
            this.ButtonCreateOrUpdateFolder.Text = "Alterar";
            this.ButtonCreateOrUpdateFolder.UseVisualStyleBackColor = true;
            this.ButtonCreateOrUpdateFolder.Click += new System.EventHandler(this.ButtonCreateOrUpdateFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 82);
            this.Controls.Add(this.ButtonCreateOrUpdateFolder);
            this.Controls.Add(this.TextBoxPathFolder);
            this.Controls.Add(this.LabelFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelFolder;
        private TextBox TextBoxPathFolder;
        private Button ButtonCreateOrUpdateFolder;
    }
}