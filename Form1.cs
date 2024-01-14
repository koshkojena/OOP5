using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Привязываем обработчик события MouseClick к форме
            this.MouseClick += Form1_MouseClick;

            // Привязываем обработчик события Load к форме
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button(); // Создание новой кнопки
            button.Size = new System.Drawing.Size(75, 50); // Установка размера кнопки
            button.Location = e.Location; // Установка позиции кнопки в соответствии с местоположением щелчка мыши
            button.Text = $"({button.Location.X}, {button.Location.Y})"; // Установка текста на кнопке с координатами левого верхнего угла
            this.Controls.Add(button); // Добавление кнопки на форму
        }
    }
}
