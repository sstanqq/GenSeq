
namespace Generating_num_sequences
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.title = new System.Windows.Forms.Label();
            this.create_project_button = new System.Windows.Forms.Label();
            this.import_project_button = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(243, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(213, 28);
            this.title.TabIndex = 0;
            this.title.Text = "Создание проекта";
            // 
            // create_project_button
            // 
            this.create_project_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_project_button.Location = new System.Drawing.Point(243, 183);
            this.create_project_button.Name = "create_project_button";
            this.create_project_button.Size = new System.Drawing.Size(213, 36);
            this.create_project_button.TabIndex = 1;
            this.create_project_button.Text = "Создать";
            this.create_project_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_project_button.Click += new System.EventHandler(this.create_project_button_Click);
            this.create_project_button.MouseLeave += new System.EventHandler(this.create_project_button_MouseLeave);
            this.create_project_button.MouseHover += new System.EventHandler(this.create_project_button_MouseHover);
            // 
            // import_project_button
            // 
            this.import_project_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_project_button.Location = new System.Drawing.Point(243, 234);
            this.import_project_button.Name = "import_project_button";
            this.import_project_button.Size = new System.Drawing.Size(213, 36);
            this.import_project_button.TabIndex = 2;
            this.import_project_button.Text = "Импортировать проект";
            this.import_project_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.import_project_button.MouseLeave += new System.EventHandler(this.import_project_button_MouseLeave);
            this.import_project_button.MouseHover += new System.EventHandler(this.import_project_button_MouseHover);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 417);
            this.Controls.Add(this.import_project_button);
            this.Controls.Add(this.create_project_button);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenSeq - Create project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label create_project_button;
        private System.Windows.Forms.Label import_project_button;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}