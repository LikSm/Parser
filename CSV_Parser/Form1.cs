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

namespace CSV_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
                              
        private void button_OpenFile_Click_1(object sender, EventArgs e)  // кнопка "Выбрать"
        {
            if (!radioBut_Separator_C.Checked && !radioBut_Separator_S.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Разделитель не выбран! Необходимо выбрать разделитель");
                return;
            }

            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = OPF.FileName.Substring(OPF.FileName.LastIndexOf('.'));

                    if (ext == ".csv")
                    {
                        ProcessingData(OPF.FileName);           // метод "Добавить данные в таблицу из файла"
                        
                    }
                    else
                    {
                        MessageBox.Show("Данные выбраны не верно");
                    }

                }
                catch (ArgumentOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }

            }

        }

        public char SelectionSeparator()                        // метод "Выбор разделителя"
        {
            char c = ';';

            if (radioBut_Separator_C.Checked)
            {
                c = ',';
            }
            if (radioBut_Separator_S.Checked)
            {
                c = ';';
            }
            if (radioButton3.Checked)
            {
                c = '|';
            }

            return c;
        }
        
        public void ProcessingData(string pathFile)        // метод "Добавить данные в таблицу из файла"
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            try
            {
                StreamReader sr = new StreamReader(@pathFile);
                string[] srFile = File.ReadAllLines(@pathFile);                

                char c = SelectionSeparator();               

                string[] headers = sr.ReadLine().Split(c);

                foreach (string header in headers)              // заполнение заголовка таблицы
                {
                    dt.Columns.Add(header);
                }                

                while (!sr.EndOfStream)                         // заполнение данных в таблицу
                {
                    string[] rows = sr.ReadLine().Split(c);
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);                    
                  
                }
                dataGridView1.Update();

                sr.Close();              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }        
            
        }

        private void button_SaveFile_Click(object sender, EventArgs e)      // метод "Сохранить данные"
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    throw new Exception("Для сохранения данных требуется заполнить таблицу!");
                }

                if (!radioBut_Separator_C.Checked && !radioBut_Separator_S.Checked && !radioButton3.Checked)
                {
                    MessageBox.Show("Разделитель не выбран! По умолчанию будет использоваться \";\"");
                }

                char c = SelectionSeparator();

                FileStream fs = new FileStream(Application.StartupPath + @"\output.csv", FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);

                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if ((k + 1) != dataGridView1.Columns.Count)
                    {
                        streamWriter.Write(dataGridView1.Columns[k].HeaderText + c);
                    }
                    else
                    {
                        streamWriter.Write(dataGridView1.Columns[k].HeaderText);
                    }
                }

                streamWriter.WriteLine();

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        if ((i + 1) != dataGridView1.Rows[j].Cells.Count)
                        {
                            streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + c.ToString());
                        }
                        else
                        {
                            streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value);
                        }

                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");


            }
            catch (Exception e2)
            {
                MessageBox.Show($"Ошибка при сохранении файла! {e2.Message}");
            }

        }

        private void button_AddRow_Click(object sender, EventArgs e)        // метод "Добавить строку в таблицу"
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Необходимо добавить столбцы!");
                return;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = true;
            }

        }

        private void button_AddColumn_Click(object sender, EventArgs e)     // метод "Добавить колонку в таблицу"
        {
            DataGridViewTextBoxColumn dgvAge;
            dgvAge = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "dgvAge", HeaderText = "A", Width = 100 });

        }

    }
}
