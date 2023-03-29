using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Generating_num_sequences
{
    public partial class Start : Form
    {
        public static string mainDirPATH;

        public Start start; // Костыли

        public Start()
        {
            InitializeComponent();

            start = this;

            // Задаем цвет фона
            this.BackColor = ColorTranslator.FromHtml("#292f4d");
            this.ForeColor = ColorTranslator.FromHtml("#ffffff");

            // Цвет кнопок
            create_project_button.BackColor = ColorTranslator.FromHtml("#373e63");
            import_project_button.BackColor = ColorTranslator.FromHtml("#373e63");

            import_project_button.Enabled = false;      // Потом убрать
        }

        // Нажатие на кнопку создания проекта
        private void create_project_button_Click(object sender, EventArgs e)
        {
            // Указываем путь сохранения проекта
            if (fbd.ShowDialog() == DialogResult.OK) { mainDirPATH = fbd.SelectedPath; }

            // Создаем папки проекта 
            if (!Directory.Exists(mainDirPATH + @"\Sequences") || !Directory.Exists(mainDirPATH + @"\Graphs") || !Directory.Exists(mainDirPATH + @"\Matrices") || !Directory.Exists(mainDirPATH + @"\Extra graphs"))
            {
                Directory.CreateDirectory(mainDirPATH + @"\Sequences");
                Directory.CreateDirectory(mainDirPATH + @"\Graphs");
                //Directory.CreateDirectory(mainDirPATH + @"\Matrices"); Пока без этого
                Directory.CreateDirectory(mainDirPATH + @"\Extra graphs");
            }

            // Открываем форму с генерацией
            Main form = new Main(ref start);
            form.Show();
            // Скрываем форму создания
            this.Hide();
        }

        /* Ховеры на кнопки */
        private void create_project_button_MouseHover(object sender, EventArgs e)
        {
            create_project_button.BackColor = ColorTranslator.FromHtml("#2d3454");
        }
        private void create_project_button_MouseLeave(object sender, EventArgs e)
        {
            create_project_button.BackColor = ColorTranslator.FromHtml("#373e63");
        }
        private void import_project_button_MouseHover(object sender, EventArgs e)
        {
            import_project_button.BackColor = ColorTranslator.FromHtml("#2d3454");
        }
        private void import_project_button_MouseLeave(object sender, EventArgs e)
        {
            import_project_button.BackColor = ColorTranslator.FromHtml("#373e63");
        }
    
    }
}
