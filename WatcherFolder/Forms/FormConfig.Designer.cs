namespace WatcherFolder.Forms
{
    partial class FormConfig
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
            this.LabelFolder = new System.Windows.Forms.Label();
            this.ButtonCreateOrUpdatePathFolder = new System.Windows.Forms.Button();
            this.TexBoxFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelFolder
            // 
            this.LabelFolder.AutoSize = true;
            this.LabelFolder.Location = new System.Drawing.Point(19, 30);
            this.LabelFolder.Name = "LabelFolder";
            this.LabelFolder.Size = new System.Drawing.Size(35, 15);
            this.LabelFolder.TabIndex = 0;
            this.LabelFolder.Text = "Pasta";
            // 
            // ButtonCreateOrUpdatePathFolder
            // 
            this.ButtonCreateOrUpdatePathFolder.Location = new System.Drawing.Point(331, 26);
            this.ButtonCreateOrUpdatePathFolder.Name = "ButtonCreateOrUpdatePathFolder";
            this.ButtonCreateOrUpdatePathFolder.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateOrUpdatePathFolder.TabIndex = 1;
            this.ButtonCreateOrUpdatePathFolder.Text = "Alterar";
            this.ButtonCreateOrUpdatePathFolder.UseVisualStyleBackColor = true;
            this.ButtonCreateOrUpdatePathFolder.Click += new System.EventHandler(this.ButtonCreateOrUpdateFolder_Click);
            // 
            // TexBoxFolder
            // 
            this.TexBoxFolder.Location = new System.Drawing.Point(60, 27);
            this.TexBoxFolder.Name = "TexBoxFolder";
            this.TexBoxFolder.Size = new System.Drawing.Size(265, 23);
            this.TexBoxFolder.TabIndex = 2;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 82);
            this.Controls.Add(this.TexBoxFolder);
            this.Controls.Add(this.ButtonCreateOrUpdatePathFolder);
            this.Controls.Add(this.LabelFolder);
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelFolder;
        private Button ButtonCreateOrUpdatePathFolder;
        private TextBox TexBoxFolder;
    }
}