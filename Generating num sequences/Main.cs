using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Diagnostics;

namespace Generating_num_sequences
{
    public partial class Main : Form
    {
        public const int MAX_MATRIECES_AMMOUNT = 50;                        // Максимальное допустимое кол-во матриц для загрузки

        public static string mainDirPATH;                                   // Имя главного каталога(куда сохраняем проект)

        public static string[] matriecesPATH;                               // Массив файлов с валидными матрицами
        public static int matAm = 1;                                        // Кол-во валидных матриц(первоначально 1)

        public static int[] M;                                              // Массив размеров матриц
        public static uint[] A0;                                            // Массив начальных значений
        public static int[] L;                                              // Массив длин последовательностей

        public static uint[] curMatrix;                                     // Текущая матрица
        public static uint[][] matrieces;                                   // Массив матриц(зубчатый массив)
        public static uint[][] vIndexes;                                    // Массив последовательностей переключений отраженного кода Грея
        public static uint[][] seq;                                         // Массив сформированных последовательностей

        public static uint[][,] cords;                                      // Массив массивов координат x и y функций
        public static uint[] cordSize;                                      // Массив размеров массивов с координатами
                
        public static int extraGraphs = 0;                                  // Счетчик доп. графиков
                                                                        
        public static byte[,] colorsRGB = { { 199, 36, 44 },            // Красный
                                            { 141, 204, 33 },           // Лайм
                                            { 39, 204, 201 },           // Голубой
                                            { 214, 64, 169 },           // Розовый
                                            { 217, 95, 39 },            // Оранжевый
                                            { 48, 122, 29 },            // Темно-зеленый
                                            { 137, 61, 191 },           // Фиолетовый
                                            { 204, 202, 61 },           // Желтый
                                            { 250, 85, 154 }            // Розовый
        };                              // RGB цвета для графиков
 
        public static int colorsAmmount = colorsRGB.GetLength(0);           // Кол-во цветов

        public static float opacity = 0.9f;                                 // Прозрачность функций на графике

        public static FunctionSeries[] fSeries;                             // Массив функций

        public Start start;

        public Stopwatch stp = new Stopwatch();                             // Отслеживание времени

        public Main(ref Start _start)
        {
            InitializeComponent();

            // Ссылаемся на родительское окно
            start = _start;

            // Сохраняем расположение папки проекта
            mainDirPATH = Start.mainDirPATH;

            /* Задаем цвета */
            this.BackColor = ColorTranslator.FromHtml("#292f4d");
            this.ForeColor = ColorTranslator.FromHtml("#ffffff");

            pv.BackColor = ColorTranslator.FromHtml("#292f4d");
            pv.ForeColor = ColorTranslator.FromHtml("#ffffff");

            gen_grafic_title.ForeColor = ColorTranslator.FromHtml("#ffffff");

            add_matrix_button.BackColor = ColorTranslator.FromHtml("#373e63");
            gen_seq_button.BackColor = ColorTranslator.FromHtml("#373e63");
            save_graph_button.BackColor = ColorTranslator.FromHtml("#373e63");

            gen_seq_output.BackColor = ColorTranslator.FromHtml("#292f4d");
            gen_seq_output.ForeColor = ColorTranslator.FromHtml("#ffffff");

            matrix_output.BackColor = ColorTranslator.FromHtml("#292f4d");
            matrix_output.ForeColor = ColorTranslator.FromHtml("#ffffff");

            // Область drag&drop
            FontFamily fontFamily = new FontFamily("Trebuchet MS");
            Font font = new Font(
               fontFamily,
               11,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            drag_space.BackColor = ColorTranslator.FromHtml("#373e63");
            drag_space.ForeColor = ColorTranslator.FromHtml("#ffffff");
            drag_space.Font = font;
            drag_space.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            drag_space.Text = Environment.NewLine + "Перетащите на эту область" + Environment.NewLine + "файлы с матрицами" + Environment.NewLine + "или добавте вручную нажав" + Environment.NewLine + " на кнопку \"Добавить\"";
        }

        /* Кнопка добавить одну матрицу */
        private void add_matrix_button_Click(object sender, EventArgs e)
        {
            // Добавление матрицы из файла
            if (add_matrix_file_rbutton.Checked)
            {
                if (ofd.ShowDialog() == DialogResult.Cancel)
                    return;

                // Получаем выбранный файл
                string filename = ofd.FileName;

                // Проверка на загруженного формата
                if (filename.Contains(".txt"))
                {
                    // Инициализация массивов
                    M = new int[1];
                    A0 = new uint[1];
                    matrieces = new uint[1][];
                    matriecesPATH = new string[1];

                    string seqName = filename.Split(@"\")[filename.Split(@"\").Length - 1].Replace(".txt", "");

                    if (logic.readMatrix(filename, ref M[0], ref A0[0], ref curMatrix, ref matrix_output, seqName))
                    {
                        // Очищаем поле drag&drop
                        drag_space.Clear();
                        // Уменьшаем размер шрифта
                        FontFamily fontFamily = new FontFamily("Trebuchet MS");
                        Font font = new Font(
                           fontFamily,
                           8,
                           FontStyle.Regular,
                           GraphicsUnit.Pixel);
                        drag_space.Font = font;
                        // Делаем выравнивание по левому краю
                        drag_space.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

                        // Добавляем все матрицы + сиды к ним в массивы
                        matrieces[0] = curMatrix;
                        matriecesPATH[0] = filename;

                        drag_space.Text += seqName + ".txt";
                    }
                    else { matAm = 0; }
                }
                // Проверка на пустой массив матриц
                if (matAm != 0)
                {
                    // Появление кнопки сгенерировать после добавления файла
                    gen_panel.Enabled = true;
                    gen_panel.Visible = true;

                    // Скрытие кнопки добавления
                    add_matrix_button.Enabled = false;

                    // Записываем кол-во загруженных матриц
                    matAm_label.Text += matAm;
                }
            }
        }

        /* Кнопка сгенерировать */
        private void gen_seq_button_Click(object sender, EventArgs e)
        {
            // Скрываем кнопку "Сгенерировать" и область drag&drop
            gen_seq_button.Enabled = false;
            drag_space.Enabled = false;

            // Инициализация массивов
            L = new int[matAm];
            vIndexes = new uint[matAm][];
            seq = new uint[matAm][];
            cords = new uint[matAm][,];
            cordSize = new uint[matAm];

            fSeries = new FunctionSeries[matAm];

            gen_seq_output.Clear();

            /* Отрисовка графика */
            pv.Model = new PlotModel { };
            //pv.Model.TextColor = OxyColor.FromRgb(255, 255, 255);

            // Начальные позиции чекбоксов
            int x = 1150;
            int y = 310;

            // Цикл прохода по матрицам
            stp.Start();
            for (int i = 0; i < matAm; i++)
            {
                // Текущее имя Матрицы
                string curFName = matriecesPATH[i].Split(@"\")[matriecesPATH[i].Split(@"\").Length - 1].Replace(".txt", "");

                // Сохраняем размер последовательности
                L[i] = (int)Math.Pow(2, (double)M[i]) - 1;

                // Сохраняем массивы переключателей
                vIndexes[i] = logic.genSwitchingSeq(L[i]);

                // Генерация последовательности
                seq[i] = logic.generateSeq(matrieces[i], vIndexes[i], A0[i], L[i]);

                // Сохранение в файл текущей последовательности
                string bufPATH = mainDirPATH + @"\Sequences\" + curFName + "(seq).txt";
                logic.saveSeq(bufPATH, seq[i]);

                // Вывод текущей последоавательности в текстбокс
                gen_seq_output.Text += "Последовательность " + curFName + ":" + Environment.NewLine;
                for (int j = 0; j < seq[i].Length; j++)
                {
                    gen_seq_output.Text += seq[i][j] + " ";
                }
                gen_seq_output.Text += Environment.NewLine + Environment.NewLine;

                // Сохраняем координаты для графиков(Тут массивы сортятся)
                cords[i] = logic.getCords(seq[i], ref cordSize[i]);

                // Функция
                FunctionSeries fs = new FunctionSeries() { };
                // Цвет графика
                byte opacityRGB = (byte)(opacity * 255);
                fs.Color = OxyColor.FromArgb(opacityRGB, colorsRGB[(i % colorsAmmount), 0], colorsRGB[(i % colorsAmmount), 1], colorsRGB[(i % colorsAmmount), 2]);

                // Добавление точек в функцию
                int counter = 0;
                for (int j = 0; j < L[i]+1; j++)
                {
                    if (cords[i][0, counter] != j) { fs.Points.Add(new DataPoint(j, 0)); }
                    else { fs.Points.Add(new DataPoint(cords[i][0, counter], cords[i][1, counter])); counter++; }
                }
                counter = 0;

                // Добавляем функцию в массив и на график
                fSeries[i] = fs;
                pv.Model.Series.Add(fs);


                /* Генерация радиокнопок для графика */
                // Для кол-ва последовательностей больше 1
                if (matAm > 1)
                {
                    FontFamily fontFamily = new FontFamily("Trebuchet MS");
                    Font font = new Font(
                       fontFamily,
                       8,
                       FontStyle.Regular,
                       GraphicsUnit.Pixel);
                    CheckBox chk = new CheckBox();
                    chk.Location = new Point(x, y);
                    chk.Name = "chk_" + i;
                    chk.Text = curFName;
                    chk.Checked = true;
                    chk.Font = font;
                    chk.Cursor = Cursors.Hand;
                    chk.Width = 50;

                    // Отслеживание нажатия на флажок
                    chk.Click += dispGraph;
                    // Добавляем чекбокс на форму
                    genseq_output_panel.Controls.Add(chk);

                    // Смещаем координаты следующего чекбокса
                    if ((i + 1) % (475 / 20) != 0)
                    {
                        y += 20;
                    }
                    else
                    {
                        y = 310;
                        x += chk.Width;
                    }
                }

                /* Экспорт текущего графика */
                logic.saveGraph(mainDirPATH, (@"\Graphs\" + curFName + ".png"), pv.Model);
                pv.Model.Series.Clear();
            }

            // Добавление всех графиков из массива функций
            for (int i = 0; i < fSeries.Length; i++)
            {
                pv.Model.Series.Add(fSeries[i]);
            }

            stp.Stop();

            // Открываем панель с выводом последовательностей
            genseq_output_panel.Visible = true;
            genseq_output_panel.Enabled = true;

            // Если кол-во последовательностей меньше 2 то скрываем кнопку сохранения доп. графиков
            if (matAm <= 1) { save_graph_button.Enabled = false; }

            // Экспорт основного графика графика(в случае если кол-во последовательностей > 1)
            if (matAm > 1) {
                logic.saveGraph(mainDirPATH, @"\General graph.png", pv.Model);
            }

            // Сохраняем время выполнения в файл
            try
            {
                using (StreamWriter wr = new StreamWriter(mainDirPATH + @"\Lead time.txt"))
                {
                    wr.WriteLine((double)(stp.ElapsedMilliseconds) / 100 + " seconds.");
                }
            }
            catch
            {
                // Вывод сообщения об ошибке
                MessageBox.Show("Отсутствуют необходимые директории\nПопробуйте пересоздать проект",
                                "Ошибка сохранения",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /* Ховер на кнопки */
        // Кнопка добавления матрицы
        private void add_matrix_button_MouseHover(object sender, EventArgs e)
        {
            //#2d3454
            add_matrix_button.BackColor = ColorTranslator.FromHtml("#2d3454");
        }
        private void add_matrix_button_MouseLeave(object sender, EventArgs e)
        {
            add_matrix_button.BackColor = ColorTranslator.FromHtml("#373e63");
        }
        // Кнопка генерации последовательностей
        private void gen_seq_button_MouseHover(object sender, EventArgs e)
        {
            gen_seq_button.BackColor = ColorTranslator.FromHtml("#2d3454");
        }
        private void gen_seq_button_MouseLeave(object sender, EventArgs e)
        {
            gen_seq_button.BackColor = ColorTranslator.FromHtml("#373e63");
        }
        // Кнопка сохранения доп. графика
        private void save_graph_button_MouseHover(object sender, EventArgs e)
        {
            save_graph_button.BackColor = ColorTranslator.FromHtml("#2d3454");
        }
        private void save_graph_button_MouseLeave(object sender, EventArgs e)
        {
            save_graph_button.BackColor = ColorTranslator.FromHtml("#373e63");
        }


        /* Вылавливаем закрытие формы */
        private void Main_FormClosing(object sender, FormClosingEventArgs e) { start.Show(); }


        /* Drag&Drop для матриц */
        private void drag_space_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void drag_space_DragDrop(object sender, DragEventArgs e)
        {
            // Очищаем поле
            drag_space.Clear();
            // Уменьшаем размер шрифта
            FontFamily fontFamily = new FontFamily("Trebuchet MS");
            Font font = new Font(
               fontFamily,
               8,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            drag_space.Font = font;
            // Делаем выравнивение по левому краю
            drag_space.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);    // Массив путей к матрицам

            // Инициализация массивов
            M = new int[files.Length];
            A0 = new uint[files.Length];
            matrieces = new uint[files.Length][];
            matriecesPATH = new string[files.Length];

            int counter = 0;                                                    // Счетчик элементов массива

            // Чтение матриц загруженных на поле Drag&Drop
            foreach (string file in files)
            {
                // Ограничение максимального кол-ва загруженных матриц
                if (counter >= MAX_MATRIECES_AMMOUNT) { break; }

                // Проверка на формать .txt
                if (!file.Contains(".txt")) { continue; }

                string fileName = file.Split(@"\")[file.Split(@"\").Length - 1].Replace(".txt", ""); 
                // Проверка на валидность матрицы
                if (logic.readMatrix(file, ref M[counter], ref A0[counter], ref curMatrix, ref matrix_output, fileName))
                {
                    // Добавляем все матрицы + сиды к ним в массивы
                    matrieces[counter] = curMatrix;
                    matriecesPATH[counter] = file;

                    counter++;
                    drag_space.Text += counter + ". " + file.Split(@"\")[file.Split(@"\").Length - 1] + Environment.NewLine;
                }
            }
            matAm = counter;                                                    // Сохраняем настоящий размер массива с путями к матрицам

            // Проверка на пустой массив матриц
            if (matAm != 0) {

                // Появление кнопки сгенерировать после добавления файла
                gen_panel.Enabled = true;
                gen_panel.Visible = true;

                // Скрытие кнопки добавления
                add_matrix_button.Enabled = false;

                // Записываем кол-во загруженных матриц
                matAm_label.Text += matAm;
            }
        }


        /* Изменнение прозрачноси графика при нажатиии на чекбокс */
        private void dispGraph(object sender, EventArgs eventArgs)
        {
            int index;

            var check_box = (CheckBox)sender;

            byte opacityRGB;

            index = int.Parse(check_box.Name.Replace("chk_", ""));
            if (check_box != null)
            {
                // Меняем прозрачность
                if (check_box.Checked == false) { opacity = 0.05f; }
                else { opacity = 0.9f; }
                opacityRGB = (byte)(opacity * 255);
                fSeries[index].Color = OxyColor.FromArgb(opacityRGB, colorsRGB[index % colorsAmmount, 0], colorsRGB[index % colorsAmmount, 1], colorsRGB[index % colorsAmmount, 2]);

                // Обновляем график
                pv.Model.InvalidatePlot(true);
            }
        }


        /* Сохранение доп. графика */
        private void save_graph_button_Click(object sender, EventArgs e)
        {
            // пока через счетчик(потом придумать как красиво сохранять)
            extraGraphs++;

            var exporter = new PngExporter { Width = 1000, Height = 500 };
            using (var stream = File.Create(mainDirPATH + @"\Extra graphs\ExGraph_" + extraGraphs + ".png" ))
            {
                exporter.Export(pv.Model, stream);
            }
        }

        /* Нажатие на dragspace */
        private void drag_space_DoubleClick(object sender, EventArgs e)
        {
            if (ofd2.ShowDialog() == DialogResult.Cancel)
                return;

            // Получаем выбранный файл
            string[] files = ofd2.FileNames;

            // Инициализация массивов
            M = new int[files.Length];
            A0 = new uint[files.Length];
            matrieces = new uint[files.Length][];
            matriecesPATH = new string[files.Length];

            int counter = 0;

            drag_space.Clear();
            foreach (string file in files)
            {
                // Ограничение максимального кол-ва загруженных матриц
                if (counter >= MAX_MATRIECES_AMMOUNT) { break; }

                // Проверка на формать .txt
                if (!file.Contains(".txt")) { continue; }

                string tempFileName = file.Split(@"\")[file.Split(@"\").Length - 1].Replace(".txt", "");
                // Проверка на валидность матрицы
                if (logic.readMatrix(file, ref M[counter], ref A0[counter], ref curMatrix, ref matrix_output, tempFileName))
                {
                    // Добавляем все матрицы + сиды к ним в массивы
                    matrieces[counter] = curMatrix;
                    matriecesPATH[counter] = file;

                    counter++;
                    drag_space.Text += counter + ". " + file.Split(@"\")[file.Split(@"\").Length - 1] + Environment.NewLine;
                }
            }
            matAm = counter;                                                    // Сохраняем настоящий размер массива с путями к матрицам

            // Проверка на пустой массив матриц
            if (matAm != 0)
            {
                // Появление кнопки сгенерировать после добавления файла
                gen_panel.Enabled = true;
                gen_panel.Visible = true;

                // Скрытие кнопки добавления
                add_matrix_button.Enabled = false;

                // Записываем кол-во загруженных матриц
                matAm_label.Text += matAm;
            }
        }
    }
}
