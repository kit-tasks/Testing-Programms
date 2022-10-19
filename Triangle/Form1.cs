using System.Numerics;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int validateInt(string text)
        {
            if (text.IndexOf(',') != -1 || text.IndexOf('.') != -1) throw new Exception("Дробное число");
            else if (!int.TryParse(text, out _))
            {
                if (BigInteger.TryParse(text, out _))
                    throw new Exception("Число слишком большое");
                else 
                    throw new Exception("Не число");
            }
            return Convert.ToInt32(text);
        }
        private void validateTriangle(int a, int b, int c)
        {
            if (!((a + b) > c && (a + c) > b && (b + c) > a)) throw new Exception("Не существует");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string aStr = aBox.Text;
            string bStr = bBox.Text;
            string cStr = cBox.Text;

            int aInt, bInt, cInt;

            try
            {
                aInt = validateInt(aStr);
                bInt = validateInt(bStr);
                cInt = validateInt(cStr);

                validateTriangle(aInt, bInt, cInt);

                string type = "";

                if (aInt == bInt && bInt == cInt)
                {
                    type = "Равносторонний";
                } else if (aInt == bInt || bInt == cInt || aInt == cInt)
                {
                    type = "Равнобедренный";
                } else
                {
                    type = "Произвольный";
                }
                MessageBox.Show($"Треугольник {type}", "Результат");
            } catch (Exception error) {
                MessageBox.Show(error.Message, "Ошибка");
            }

            aBox.Text = "";
            bBox.Text = "";
            cBox.Text = "";
        }
    }
}