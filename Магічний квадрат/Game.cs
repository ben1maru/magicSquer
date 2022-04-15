using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магічний_квадрат
{
    public partial class FrmMain : Form
    {
        private const string SAVED_FILE = "data.txt";
        public int magicNumber;
        public int click, buf, indStb, indStr;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnAccept_Click(object sender, EventArgs e)  ///створювання і задання значень квадрату
        {
            int sizeSquer;
            if (int.TryParse(txtSizeSquer.Text, out sizeSquer))
            {
                dgvMagicSquer.ColumnCount = sizeSquer;
                dgvMagicSquer.RowCount = sizeSquer;
                dgvMagicSquer.RowHeadersWidth = 5;
            }
            else
            {
                MessageBox.Show("Введіть число!");
            }

            Random rnd = new Random();  /// перевірка на повторюваність чисел в DataGridView 
            List<int> listNumbers = new List<int>();
            int number, index = 0;
            for (int i = 0; i < sizeSquer * sizeSquer; i++)
            {
                do
                {
                    number = rnd.Next(1, sizeSquer * sizeSquer + 1);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }

            for (int i = 0; i < sizeSquer; i++)
            {
                RowsFillByDataGridViewSize(i, sizeSquer);

                for (int j = 0; j < sizeSquer; j++)
                {

                    dgvMagicSquer.Rows[i].Cells[j].Value = listNumbers.ElementAt(index);
                    index++;
                }
            }
            magicNumber = sizeSquer * (sizeSquer * sizeSquer + 1) / 2; ///розрахунок магічного числа
            lblMagicNumber.Text = "Магічне число : " + magicNumber; 
            AmountForALLRefresh();
     
        }

        /// <summary> 
        /// скорегування розмірів DataGridView 
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private int RowsFillByDataGridViewSize(int currentIndex, int size) ///Розширення розмірів DataGridView
        {
            return dgvMagicSquer.Rows[currentIndex].Height = (dgvMagicSquer.Height - dgvMagicSquer.ColumnHeadersHeight) / size - 1;
        }

        private void AmountForALLRefresh() ///перелік всіх винесених функцій в одній 
        {
            CountSum(); 
            if (AmounForRows() && AmounForColums() && AmountForDiagonal())
                CheckWin();

        }

        private void CountSum() /// сума по рядка і стовпцях
        {
            int sum = 0;

            for (int i = 0; i < dgvMagicSquer.RowCount; i++)

            {
                sum = 0;
                for (int j = 0; j < dgvMagicSquer.ColumnCount; j++)
                {
                    sum += Convert.ToInt32(dgvMagicSquer.Rows[i].Cells[j].Value);
                }


                dgvMagicSquer.Rows[i].HeaderCell.Value = sum.ToString();
            }

            for (int i = 0; i < dgvMagicSquer.RowCount; i++)

            {
                sum = 0;
                for (int j = 0; j < dgvMagicSquer.ColumnCount; j++)
                {
                    sum += Convert.ToInt32(dgvMagicSquer.Rows[j].Cells[i].Value);
                }

                dgvMagicSquer.Columns[i].HeaderText = sum.ToString();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)  /// збереження гри в текстовий файл  
        {
            FileStream fs = new FileStream(SAVED_FILE, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);

            try
            {
                for (int i = 0; i < dgvMagicSquer.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvMagicSquer.Rows[i].Cells.Count; j++)
                        streamWriter.Write($"{dgvMagicSquer.Rows[i].Cells[j].Value}|");

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Гра збережена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException eIO)
            {
                Console.WriteLine($"Файл не знайдено: '{eIO}'");
            }
            catch (DirectoryNotFoundException eIO)
            {
                Console.WriteLine($"Каталог не знайдено: '{eIO}'");
            }
            catch (IOException eIO)
            {
                Console.WriteLine($"Не вдалося відкрити файл: '{eIO}'");
            }
        }

        private void btnColor_Click(object sender, EventArgs e) ///кнопка для зміни кольору форми
        {
            grpColor.Visible = true;
            grpGame.Visible = false;
        }

        private void btnOrange_Click(object sender, EventArgs e) ///зміна кольору на оранжевий
        {
            this.BackColor = Color.Coral;
        }

        private void btnGreen_Click(object sender, EventArgs e) ///зміна кольору на зелений 
        {
            this.BackColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e) ///зміна кольору на жовтий
        {
            this.BackColor = Color.Yellow;
        }

        private void btnRed_Click(object sender, EventArgs e) ///зміна кольору на червоний
        {
            this.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e) ///зміна кольору на синій
        {
            this.BackColor = Color.Blue;
        }

        private void btnAzure_Click(object sender, EventArgs e) ///зміна кольору на голубий
        {
            this.BackColor = Color.Aquamarine;
        }

        private void btnVoilet_Click(object sender, EventArgs e) ///зміна кольора на фіолетовий
        {
            this.BackColor = Color.Indigo;
        }

        private void btnBack_Click(object sender, EventArgs e) ///повертає до до гри
        {
            grpColor.Visible = false;
            grpGame.Visible = true;
        }

        private void dgvMagicSquer_CellClick(object sender, DataGridViewCellEventArgs e) ///зміна цифри в комірці за допомогою кліка
        {
            click++;
            if (click == 1)
            {
                buf = Convert.ToInt32(dgvMagicSquer.CurrentCell.Value);
                indStr = dgvMagicSquer.CurrentCell.RowIndex;
                indStb = dgvMagicSquer.CurrentCell.ColumnIndex;
            }
            else
            {
                dgvMagicSquer.Rows[indStr].Cells[indStb].Value = dgvMagicSquer.CurrentCell.Value;
                dgvMagicSquer.CurrentCell.Value = buf;
                click = 0;
            }
            AmountForALLRefresh();
        }
        


        private bool AmounForRows() /// вивід суми рядка в заголовок рядка
        {
            bool flagRows = true;


            for (int i = 0; i < dgvMagicSquer.RowCount; i++)

            {
                if (dgvMagicSquer.Rows[i].HeaderCell.Value.ToString() != magicNumber.ToString()) flagRows = false;
            }
            return
                flagRows;
        }

        private void btnContinuos_Click(object sender, EventArgs e) ///продовження збереженої гри
        {
            string currentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string[] lines = File.ReadAllLines($"{currentDirectory}/{SAVED_FILE}");
            string[] values;

            int sizeSquer = lines.Length;
            dgvMagicSquer.ColumnCount = sizeSquer;

            for (int i = 0; i < sizeSquer; ++i)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; ++j)
                    row[j] = values[j];

                dgvMagicSquer.Rows.Add(row);
            }

            for (int i = 0; i < sizeSquer; ++i)
                RowsFillByDataGridViewSize(i, sizeSquer);

            txtSizeSquer.Text = sizeSquer.ToString();
            magicNumber = sizeSquer * (sizeSquer * sizeSquer + 1) / 2;
            lblMagicNumber.Text = "Магічне число : " + magicNumber;


            AmountForALLRefresh();
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e) ///розтягування DataGridView разом з формою
        {
            int sizeSquer = Convert.ToInt32(dgvMagicSquer.Rows.Count);
            for (int i = 0; i < sizeSquer; ++i)
                RowsFillByDataGridViewSize(i, sizeSquer);
        }

        private bool AmounForColums() /// вивід суми рядка в заголовок стовбця
        {
            bool flagColumns = true;
            for (int i = 0; i < dgvMagicSquer.RowCount; i++)

            {
                if (dgvMagicSquer.Columns[i].HeaderText.ToString() != magicNumber.ToString()) flagColumns = false;
            }
            return flagColumns;
        }



        private bool AmountForDiagonal() /// обрахунок суми по діагоналях
        {
            int sum = 0;
            for (int j = 0; j < dgvMagicSquer.ColumnCount; j++)
            {
                sum += Convert.ToInt32(dgvMagicSquer.Rows[j].Cells[j].Value);
            }
            if (sum != magicNumber)
            {
                return false;
            }
            else

                return true;


        }


        private void CheckWin() /// перревірка на перемогу

        {
            if (AmounForRows() && AmounForColums() && AmountForDiagonal())
                MessageBox.Show("Перемога!");

        }
   
    }
}