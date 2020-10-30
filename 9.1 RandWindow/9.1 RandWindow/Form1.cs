using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._1_RandWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Вывести сообщение с текстом "Вы усердны"
            MessageBox.Show("Вы усердны!! Нам такие нужны!");
            // Завершить приложение
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point tmp_location;
            Random rnd = new Random();
            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            // переводим координату X в строку и записывает в поля ввода
            // переводим координату Y в строку и записывает в поля ввода
            // если координата по оси X и по оси Y лежит в очерчиваемом вокруг
            //кнопки "да, конечно" квадрате
            if (e.X > 20 && e.X < 230 && e.Y > 100 && e.Y < 190)
            {

                // запоминаем текущее положение окна
                tmp_location = this.Location;
                // генерируем перемещения по осям X и Y и прибавляем их к хранимому
                //значению текущего положения окна
                // числа генерируются в диапазоне от -100 до 100
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);
                // если окно вылезло за пределы экрана по одной из осей
                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                { // новыми координатами станет центр окна
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }
                // обновляем положение окна, на новое сгенерированное
                this.Location = tmp_location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вывести сообщение, с текстом "Мы не сомневались в вешем безразличии"
            // второй параметр - заголовок окна сообщения "Внимание"
            // MessageBoxButtons.OK - тип размещаемой кнопки на форме сообщения
            // MessageBoxIcon.Information - тип сообщения - будет иметь иконку
            // "информация" и соответствующий звуковой сигнал
            MessageBox.Show("Мы не сомневались в вашем безразличии. Вас уже ожидают в военкомате на перевоспитание!", "Внимание",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
