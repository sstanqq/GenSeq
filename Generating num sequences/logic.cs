using System;
using System.IO;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;

namespace Generating_num_sequences
{
    class logic
    {
        public const int MAX_MATRIX_WIDTH = 12;                             // Максимальное значение длины для столбцов матрицы
        public const int MAX_MATRIX_HEIGHT = 12;                            // Максимальное значение длины для строк матрицы

        public static uint bStrToNum(string str)
        {
            uint num = 0;
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                if (str[i] == '1') { num += (uint)Math.Pow(2, j); }
            }

            return num;
        }

        public static int sizeofM(string path)
        {
            int counter = 0;

            string line;
            TextReader reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
            {
                counter++;
            }
            reader.Close();

            return (counter-2); // Первые две строки не считаем
        }

        public static bool readMatrix(string path, ref int M, ref uint A0, ref uint[] matrix, ref TextBox textbox, string nameSeq)
        {
            string line;
            int lCounter = 0; 

            using (StreamReader reader = new StreamReader(path))
            {
                string strA0 = reader.ReadLine();
                if (strA0.Length > MAX_MATRIX_WIDTH) { return false; }
                A0 = bStrToNum(strA0);

                // Пропуск строки
                reader.ReadLine();

                // Размер полинома
                M = sizeofM(path);                                          // Размер полинома(кол-во строк)
                if (M < 2) { return false; }                                // Кол-во строк должно быть больше одного
                matrix = new uint[M];

                textbox.Text += "Последовательность " + nameSeq + ":" + Environment.NewLine;
                textbox.Text += "\tSID:\t" + strA0 + Environment.NewLine;
                textbox.Text += "\tMatrix:" + Environment.NewLine;

                // Считываем построчно
                while ((line = reader.ReadLine()) != null)
                {

                    if (line.Length != strA0.Length || line.Length > MAX_MATRIX_WIDTH || lCounter > MAX_MATRIX_HEIGHT) { return false; }

                    textbox.Text += "\t\t" + line + Environment.NewLine;

                    matrix[lCounter] = bStrToNum(line);
                    lCounter++;
                }

                if (lCounter < strA0.Length) { return false; }
            }
            textbox.Text += Environment.NewLine;

            return true;
        }


        public static uint[] genSwitchingSeq(int L)
        {
            uint[] vIndexes = new uint[L];

            // i и i+1 число в коде грея
            for (uint i = 1; i <= L; i++)
            {
                uint Tm;
                uint temp = (grayCode(i) ^ grayCode(i - 1));    // Ng xor Ng-1

                uint bits = 0;                                  // Счетчик разрядов разрядов 

                if (temp == 1) { Tm = 0; }
                else
                {
                    while (temp != 1)
                    {
                        temp /= 2;
                        bits++;
                    }
                    Tm = bits;
                }

                vIndexes[i - 1] = Tm;
            }

            return vIndexes;
        }

        public static uint grayCode(uint num)
        {
            uint grayNum = num >> 1;
            grayNum ^= num;

            return grayNum;
        }

        public static uint[,] getCords(uint[] mas, ref uint cordSize)
        {
            uint[,] cords = new uint[2, (int)(Math.Pow(2, MAX_MATRIX_HEIGHT)-1)];

            if (mas.Length != 0)
            {
                Array.Sort(mas);

                uint x = mas[0];
                uint y = 1;

                cordSize = 0;

                for (int i = 1; i < mas.Length; i++)
                {
                    if (x == mas[i]) { y++; }
                    else
                    {
                        cords[0, cordSize] = x;
                        cords[1, cordSize] = y;

                        x = mas[i];
                        y = 1;

                        cordSize++;
                    }
                }
                cords[0, cordSize] = x;
                cords[1, cordSize] = y;

                cordSize++;
            }

            return cords;
        }

        public static uint[] generateSeq(uint[] matrix, uint[] vIndex, uint A0, int L)
        {
            uint[] seq = new uint[L];

            for (int i = 0; i < L; i++)
            {          
                A0 ^= matrix[vIndex[i]];    
                seq[i] = A0;
            }
            return seq;
        }

        public static void saveSeq(string fName, uint[] seq)
        {
            // Проверка на наличие необходимых деректорий
            try
            {
                // Открываем поток на запись 
                using (StreamWriter wr = new StreamWriter(fName))
                {
                    for (int i = 0; i < seq.Length; i++)
                    {
                        wr.WriteLine(seq[i]);
                    }
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
    
        public static void saveGraph(string path, string fName, PlotModel ptM)
        {
            try
            {
                var exporterBuf = new PngExporter { Width = 1000, Height = 500 };
                using (var stream = File.Create(path + fName))
                {
                    exporterBuf.Export(ptM, stream);
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
    }
}
