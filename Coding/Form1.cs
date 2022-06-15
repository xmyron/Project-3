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

namespace Coding
{
    public partial class Form1 : Form
    {
        string language = "English";

        public Form1()
        {
            InitializeComponent();
        }

        private void DecryptionToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void OffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < str.Length; i++)
            {
                textBox1.Text += Convert.ToChar(Convert.ToInt32(str[i]) + 2);
            }
            if(language == "Russian")
                label1.Text = "Выполнено шифрование со смещением...";
            else if (language == "Ukraine")
                label1.Text = "Виповнено шифрування зі зміщенням...";
            else if (language == "English")
                label1.Text = "Encryption with offset...";
        }

        private void OffsetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < str.Length; i++)
            {
                textBox1.Text += Convert.ToChar(Convert.ToInt32(str[i]) - 2);
            }
            if (language == "Russian")
                label1.Text = "Выполнено дешифрование со смещением...";
            else if (language == "Ukraine")
                label1.Text = "Виповнено дешифрування зі зміщенням...";
            else if (language == "English")
                label1.Text = "Decryption with offset...";
        }

        private void TableASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            foreach (var t in str)
            {
                if (Convert.ToInt32(t) > 255)
                {
                    textBox1.Text = str;
                    MessageBox.Show("Character not in a table!");
                    return;
                }
                textBox1.Text += (Convert.ToInt32(t) + 300).ToString();
            }
            switch (language)
            {
                case "Russian":
                    label1.Text = "Выполнено шифрование таблицей ASCII...";
                    break;
                case "Ukraine":
                    label1.Text = "Виповнено шифрування таблицею ASCII...";
                    break;
                case "English":
                    label1.Text = "Encryption with table ASCII...";
                    break;
            }
        }

        private void TableASCIIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            int k = 0;
            string number = "";
            for (int i = 0; i < str.Length; i++)
            {
                k++;
                number += str[i];
                if (k == 3)
                {
                    try
                    {
                        k = 0;
                        textBox1.Text += Convert.ToChar(Convert.ToInt32(number) - 300);
                        number = "";
                    }
                    catch (FormatException)
                    {
                        textBox1.Text = str;
                        MessageBox.Show("Invalid text");
                        return;
                    }
                }
            }
            if (language == "Russian")
                label1.Text = "Выполнено дешифрование таблицей ASCII...";
            else if (language == "Ukraine")
                label1.Text = "Виповнено дешифрування таблицею ASCII...";
            else if (language == "English")
                label1.Text = "Decryption with table ASCII...";
        }

        private void RussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "Russian";

            if (label1.Text == "Виповнено шифрування зі зміщенням..." || label1.Text == "Encryption with offset...")
                label1.Text = "Выполнено шифрование со смещением...";
            else if (label1.Text == "Виповнено дешифрування зі зміщенням..." || label1.Text == "Decryption with offset...")
                label1.Text = "Выполнено дешифрование со смещением...";
            else if (label1.Text == "Виповнено шифрування таблицею ASCII..." || label1.Text == "Encryption with table ASCII...")
                label1.Text = "Выполнено шифрование таблицей ASCII...";
            else if (label1.Text == "Виповнено дешифрування таблицею ASCII..." || label1.Text == "Decryption with table ASCII...")
                label1.Text = "Выполнено дешифрование таблицей ASCII...";

            toolStripMenuItem1.Text = "Файл";
            сохранитьToolStripMenuItem.Text = "Сохранить";

            шифрованиеToolStripMenuItem.Text = "Шифрование";
            соСмещениемToolStripMenuItem.Text = "Со смещением";
            таблицаASCIIToolStripMenuItem.Text = "Таблица ASCII";

            дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            соСмещениемToolStripMenuItem1.Text = "Со смещением";
            таблицаASCIIToolStripMenuItem1.Text = "Таблица ASCII";

            настройкиToolStripMenuItem.Text = "Настройки";
            языкToolStripMenuItem.Text = "Язык";
            выйтиToolStripMenuItem.Text = "Выход";
        }

        private void UkranianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "Ukraine";

            if (label1.Text == "Выполнено шифрование со смещением..." || label1.Text == "Encryption with offset...")
                label1.Text = "Виповнено шифрування зі зміщенням...";
            else if (label1.Text == "Выполнено дешифрование со смещением..." || label1.Text == "Decryption with offset...")
                label1.Text = "Виповнено дешифрування зі зміщенням...";
            else if (label1.Text == "Выполнено шифрование таблицей ASCII..." || label1.Text == "Encryption with table ASCII...")
                label1.Text = "Виповнено шифрування таблицею ASCII...";
            else if (label1.Text == "Выполнено дешифрование таблицей ASCII..." || label1.Text == "Decryption with table ASCII...")
                label1.Text = "Виповнено дешифрування таблицею ASCII...";

            toolStripMenuItem1.Text = "Файл";
            сохранитьToolStripMenuItem.Text = "Зберегти";

            шифрованиеToolStripMenuItem.Text = "Шифрування";
            соСмещениемToolStripMenuItem.Text = "Зі зміщенням";
            таблицаASCIIToolStripMenuItem.Text = "Таблиця ASCII";

            дешифрованиеToolStripMenuItem.Text = "Дешифрування";
            соСмещениемToolStripMenuItem1.Text = "Зі зміщенням";
            таблицаASCIIToolStripMenuItem1.Text = "Таблиця ASCII";

            настройкиToolStripMenuItem.Text = "Налаштування";
            языкToolStripMenuItem.Text = "Мова";
            выйтиToolStripMenuItem.Text = "Вихід";
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "English";

            if (label1.Text == "Выполнено шифрование со смещением..." || label1.Text == "Виповнено шифрування зі зміщенням...")
                label1.Text = "Encryption with offset...";
            else if (label1.Text == "Выполнено дешифрование со смещением..." || label1.Text == "Виповнено дешифрування зі зміщенням...")
                label1.Text = "Decryption with offset...";
            else if (label1.Text == "Выполнено шифрование таблицей ASCII..." || label1.Text == "Виповнено шифрування таблицею ASCII...")
                label1.Text = "Encryption with table ASCII...";
            else if (label1.Text == "Выполнено дешифрование таблицей ASCII..." || label1.Text == "Виповнено дешифрування таблицею ASCII...")
                label1.Text = "Decryption with table ASCII...";

            toolStripMenuItem1.Text = "File";
            сохранитьToolStripMenuItem.Text = "Save";

            шифрованиеToolStripMenuItem.Text = "Encryption";
            соСмещениемToolStripMenuItem.Text = "With offset";
            таблицаASCIIToolStripMenuItem.Text = "Table ASCII";

            дешифрованиеToolStripMenuItem.Text = "Decryption";
            соСмещениемToolStripMenuItem1.Text = "With offset";
            таблицаASCIIToolStripMenuItem1.Text = "Table ASCII";

            настройкиToolStripMenuItem.Text = "Settings";
            языкToolStripMenuItem.Text = "Language";
            выйтиToolStripMenuItem.Text = "Exit";
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Output.txt", textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
