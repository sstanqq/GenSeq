
namespace Generating_num_sequences
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.add_matrix_label = new System.Windows.Forms.Label();
            this.add_matrix_hand_rbutton = new System.Windows.Forms.RadioButton();
            this.add_matrix_file_rbutton = new System.Windows.Forms.RadioButton();
            this.add_matrix_button = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.gen_seq_button = new System.Windows.Forms.Label();
            this.gen_seq_output = new System.Windows.Forms.TextBox();
            this.gen_seq_label = new System.Windows.Forms.Label();
            this.gen_panel = new System.Windows.Forms.Panel();
            this.matAm_label = new System.Windows.Forms.Label();
            this.genseq_output_panel = new System.Windows.Forms.Panel();
            this.save_graph_button = new System.Windows.Forms.Label();
            this.matrix_title = new System.Windows.Forms.Label();
            this.matrix_output = new System.Windows.Forms.TextBox();
            this.gen_grafic_title = new System.Windows.Forms.Label();
            this.pv = new OxyPlot.WindowsForms.PlotView();
            this.drag_space = new System.Windows.Forms.TextBox();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.gen_panel.SuspendLayout();
            this.genseq_output_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_matrix_label
            // 
            this.add_matrix_label.AutoSize = true;
            this.add_matrix_label.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_matrix_label.Location = new System.Drawing.Point(81, 260);
            this.add_matrix_label.Name = "add_matrix_label";
            this.add_matrix_label.Size = new System.Drawing.Size(160, 23);
            this.add_matrix_label.TabIndex = 0;
            this.add_matrix_label.Text = "Добавить матрицу";
            // 
            // add_matrix_hand_rbutton
            // 
            this.add_matrix_hand_rbutton.AutoSize = true;
            this.add_matrix_hand_rbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_matrix_hand_rbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_matrix_hand_rbutton.Location = new System.Drawing.Point(33, 295);
            this.add_matrix_hand_rbutton.Name = "add_matrix_hand_rbutton";
            this.add_matrix_hand_rbutton.Size = new System.Drawing.Size(88, 24);
            this.add_matrix_hand_rbutton.TabIndex = 2;
            this.add_matrix_hand_rbutton.Text = "Вручную";
            this.add_matrix_hand_rbutton.UseVisualStyleBackColor = true;
            // 
            // add_matrix_file_rbutton
            // 
            this.add_matrix_file_rbutton.AutoSize = true;
            this.add_matrix_file_rbutton.Checked = true;
            this.add_matrix_file_rbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_matrix_file_rbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_matrix_file_rbutton.Location = new System.Drawing.Point(127, 295);
            this.add_matrix_file_rbutton.Name = "add_matrix_file_rbutton";
            this.add_matrix_file_rbutton.Size = new System.Drawing.Size(170, 24);
            this.add_matrix_file_rbutton.TabIndex = 3;
            this.add_matrix_file_rbutton.TabStop = true;
            this.add_matrix_file_rbutton.Text = "Загрузить из файла";
            this.add_matrix_file_rbutton.UseVisualStyleBackColor = true;
            // 
            // add_matrix_button
            // 
            this.add_matrix_button.BackColor = System.Drawing.SystemColors.Control;
            this.add_matrix_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_matrix_button.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_matrix_button.Location = new System.Drawing.Point(33, 331);
            this.add_matrix_button.Name = "add_matrix_button";
            this.add_matrix_button.Size = new System.Drawing.Size(264, 29);
            this.add_matrix_button.TabIndex = 5;
            this.add_matrix_button.Text = "Добавить";
            this.add_matrix_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_matrix_button.Click += new System.EventHandler(this.add_matrix_button_Click);
            this.add_matrix_button.MouseLeave += new System.EventHandler(this.add_matrix_button_MouseLeave);
            this.add_matrix_button.MouseHover += new System.EventHandler(this.add_matrix_button_MouseHover);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // gen_seq_button
            // 
            this.gen_seq_button.BackColor = System.Drawing.SystemColors.Control;
            this.gen_seq_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gen_seq_button.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gen_seq_button.Location = new System.Drawing.Point(-3, 37);
            this.gen_seq_button.Name = "gen_seq_button";
            this.gen_seq_button.Size = new System.Drawing.Size(259, 29);
            this.gen_seq_button.TabIndex = 7;
            this.gen_seq_button.Text = "Сгенерировать";
            this.gen_seq_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gen_seq_button.Click += new System.EventHandler(this.gen_seq_button_Click);
            this.gen_seq_button.MouseLeave += new System.EventHandler(this.gen_seq_button_MouseLeave);
            this.gen_seq_button.MouseHover += new System.EventHandler(this.gen_seq_button_MouseHover);
            // 
            // gen_seq_output
            // 
            this.gen_seq_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gen_seq_output.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gen_seq_output.Location = new System.Drawing.Point(394, 36);
            this.gen_seq_output.Multiline = true;
            this.gen_seq_output.Name = "gen_seq_output";
            this.gen_seq_output.ReadOnly = true;
            this.gen_seq_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gen_seq_output.Size = new System.Drawing.Size(753, 227);
            this.gen_seq_output.TabIndex = 8;
            // 
            // gen_seq_label
            // 
            this.gen_seq_label.AutoSize = true;
            this.gen_seq_label.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gen_seq_label.Location = new System.Drawing.Point(603, 10);
            this.gen_seq_label.Name = "gen_seq_label";
            this.gen_seq_label.Size = new System.Drawing.Size(335, 23);
            this.gen_seq_label.TabIndex = 9;
            this.gen_seq_label.Text = "Сгенерированные последовательности";
            // 
            // gen_panel
            // 
            this.gen_panel.Controls.Add(this.matAm_label);
            this.gen_panel.Controls.Add(this.gen_seq_button);
            this.gen_panel.Enabled = false;
            this.gen_panel.Location = new System.Drawing.Point(33, 480);
            this.gen_panel.Name = "gen_panel";
            this.gen_panel.Size = new System.Drawing.Size(283, 75);
            this.gen_panel.TabIndex = 12;
            this.gen_panel.Visible = false;
            // 
            // matAm_label
            // 
            this.matAm_label.AutoSize = true;
            this.matAm_label.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matAm_label.Location = new System.Drawing.Point(-3, 0);
            this.matAm_label.Name = "matAm_label";
            this.matAm_label.Size = new System.Drawing.Size(188, 18);
            this.matAm_label.TabIndex = 17;
            this.matAm_label.Text = "Кол-во загруженных матриц: ";
            // 
            // genseq_output_panel
            // 
            this.genseq_output_panel.Controls.Add(this.save_graph_button);
            this.genseq_output_panel.Controls.Add(this.matrix_title);
            this.genseq_output_panel.Controls.Add(this.matrix_output);
            this.genseq_output_panel.Controls.Add(this.gen_grafic_title);
            this.genseq_output_panel.Controls.Add(this.pv);
            this.genseq_output_panel.Controls.Add(this.gen_seq_label);
            this.genseq_output_panel.Controls.Add(this.gen_seq_output);
            this.genseq_output_panel.Location = new System.Drawing.Point(322, 38);
            this.genseq_output_panel.Name = "genseq_output_panel";
            this.genseq_output_panel.Size = new System.Drawing.Size(1285, 847);
            this.genseq_output_panel.TabIndex = 13;
            this.genseq_output_panel.Visible = false;
            // 
            // save_graph_button
            // 
            this.save_graph_button.BackColor = System.Drawing.SystemColors.Control;
            this.save_graph_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_graph_button.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_graph_button.Location = new System.Drawing.Point(433, 805);
            this.save_graph_button.Name = "save_graph_button";
            this.save_graph_button.Size = new System.Drawing.Size(293, 30);
            this.save_graph_button.TabIndex = 17;
            this.save_graph_button.Text = "Сохранить текущий график";
            this.save_graph_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_graph_button.Click += new System.EventHandler(this.save_graph_button_Click);
            this.save_graph_button.MouseLeave += new System.EventHandler(this.save_graph_button_MouseLeave);
            this.save_graph_button.MouseHover += new System.EventHandler(this.save_graph_button_MouseHover);
            // 
            // matrix_title
            // 
            this.matrix_title.AutoSize = true;
            this.matrix_title.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrix_title.Location = new System.Drawing.Point(104, 10);
            this.matrix_title.Name = "matrix_title";
            this.matrix_title.Size = new System.Drawing.Size(157, 23);
            this.matrix_title.TabIndex = 17;
            this.matrix_title.Text = "Входные матрицы";
            // 
            // matrix_output
            // 
            this.matrix_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrix_output.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrix_output.Location = new System.Drawing.Point(19, 36);
            this.matrix_output.Multiline = true;
            this.matrix_output.Name = "matrix_output";
            this.matrix_output.ReadOnly = true;
            this.matrix_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matrix_output.Size = new System.Drawing.Size(351, 227);
            this.matrix_output.TabIndex = 16;
            // 
            // gen_grafic_title
            // 
            this.gen_grafic_title.AutoSize = true;
            this.gen_grafic_title.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gen_grafic_title.Location = new System.Drawing.Point(433, 280);
            this.gen_grafic_title.Name = "gen_grafic_title";
            this.gen_grafic_title.Size = new System.Drawing.Size(293, 23);
            this.gen_grafic_title.TabIndex = 15;
            this.gen_grafic_title.Text = "График плотности распределения";
            // 
            // pv
            // 
            this.pv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pv.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pv.Location = new System.Drawing.Point(0, 306);
            this.pv.Name = "pv";
            this.pv.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pv.Size = new System.Drawing.Size(1144, 485);
            this.pv.TabIndex = 14;
            this.pv.Text = "plotView1";
            this.pv.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pv.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pv.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // drag_space
            // 
            this.drag_space.AllowDrop = true;
            this.drag_space.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drag_space.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drag_space.Font = new System.Drawing.Font("Trebuchet MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drag_space.Location = new System.Drawing.Point(30, 372);
            this.drag_space.Multiline = true;
            this.drag_space.Name = "drag_space";
            this.drag_space.ReadOnly = true;
            this.drag_space.Size = new System.Drawing.Size(265, 102);
            this.drag_space.TabIndex = 16;
            this.drag_space.DragDrop += new System.Windows.Forms.DragEventHandler(this.drag_space_DragDrop);
            this.drag_space.DragEnter += new System.Windows.Forms.DragEventHandler(this.drag_space_DragEnter);
            this.drag_space.DoubleClick += new System.EventHandler(this.drag_space_DoubleClick);
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog1";
            this.ofd2.Multiselect = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1637, 918);
            this.Controls.Add(this.drag_space);
            this.Controls.Add(this.genseq_output_panel);
            this.Controls.Add(this.gen_panel);
            this.Controls.Add(this.add_matrix_button);
            this.Controls.Add(this.add_matrix_file_rbutton);
            this.Controls.Add(this.add_matrix_hand_rbutton);
            this.Controls.Add(this.add_matrix_label);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "GenSeq - Генерация последовательностей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.gen_panel.ResumeLayout(false);
            this.gen_panel.PerformLayout();
            this.genseq_output_panel.ResumeLayout(false);
            this.genseq_output_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_matrix_label;
        private System.Windows.Forms.RadioButton add_matrix_hand_rbutton;
        private System.Windows.Forms.RadioButton add_matrix_file_rbutton;
        private System.Windows.Forms.Label add_matrix_button;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label gen_seq_button;
        private System.Windows.Forms.TextBox gen_seq_output;
        private System.Windows.Forms.Label gen_seq_label;
        private System.Windows.Forms.Panel gen_panel;
        private System.Windows.Forms.Panel genseq_output_panel;
        private OxyPlot.WindowsForms.PlotView pv;
        private System.Windows.Forms.Label gen_grafic_title;
        private System.Windows.Forms.TextBox drag_space;
        private System.Windows.Forms.Label matrix_title;
        private System.Windows.Forms.TextBox matrix_output;
        private System.Windows.Forms.Label save_graph_button;
        private System.Windows.Forms.Label matAm_label;
        private System.Windows.Forms.OpenFileDialog ofd2;
    }
}

