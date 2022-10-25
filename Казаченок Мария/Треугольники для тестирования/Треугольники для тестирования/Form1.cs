using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Треугольники_для_тестирования
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            switch (Start.Text)
            {
                case "Проверить":
                    if (SideA.BackColor == Color.DarkRed || SideB.BackColor == Color.DarkRed || SideC.BackColor == Color.DarkRed || SideA.Text == "" || SideB.Text == "" || SideC.Text == "")
                    {
                        Result.Text = "Повторите ввод";
                        SideA.Text = "";
                        SideB.Text = "";
                        SideC.Text = "";
                    }
                    else
                    {
                        int a, b, c;
                        Start.Text = "Повторить";
                        a = Convert.ToInt32(SideA.Text);
                        b = Convert.ToInt32(SideB.Text);
                        c = Convert.ToInt32(SideC.Text);
                        SideA.Visible = false;
                        SideB.Visible = false;
                        SideC.Visible = false;
                        if (!VerificationOfExistence(a, b, c))
                        {
                            Result.Text = "Треугольника не существеут";
                            break;
                        }
                        if (a == b)
                        {
                            if (b == c)
                            {
                                Result.Text = "Треугольник равносторонний";
                            }
                            else { Result.Text = "Треугольник равнобедренный"; }
                        }
                        else if (b == c)
                        {
                            Result.Text = "Треугольник равнобедренный";
                        }
                        else if (a == c)
                        {
                            Result.Text = "Треугольник равнобедренный";
                        }
                        else { Result.Text = "Треугольник разносторонний"; }
                    }
                    break;
                case "Повторить":
                    {
                        Start.Text = "Проверить";
                        Result.Text = "";
                        SideA.Text = "";
                        SideB.Text = "";
                        SideC.Text = "";
                        SideA.Visible = true;
                        SideB.Visible = true;
                        SideC.Visible = true;
                        break;
                    }
            }
        }
        private static bool VerificationOfExistence(int a,int b,int c)
        {
            bool result = false;
            if (a + b >= c && a + c >= b && b + c > a)
            {
                result = true;
            }
            return result;
        }
        private void SideA_TextChanged(object sender, EventArgs e)
        {
            string str="";
            switch ((sender as TextBox).Name)
            {
                case "SideA":
                    str = SideA.Text;
                    break;
                case "SideB":
                    str = SideB.Text;
                    break;
                case "SideC":
                    str = SideC.Text;
                    break;
            }
            bool verificator = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    verificator = false;
                    break;
                }
            }
            if(!BigInteger.TryParse(str,out _))
            { verificator = false; }
            if (!verificator)
            {
                switch ((sender as TextBox).Name)
                {
                    case "SideA":
                        SideA.BackColor = Color.DarkRed;
                        SideA.ForeColor = Color.White;
                        break;
                    case "SideB":
                        SideB.BackColor = Color.DarkRed;
                        SideB.ForeColor = Color.White;
                        break;
                    case "SideC":
                        SideC.BackColor = Color.DarkRed;
                        SideC.ForeColor = Color.White;
                        break;
                }
            }
            else
            {
                if (true)
                {

                }
                switch ((sender as TextBox).Name)
                {
                    case "SideA":
                        SideA.BackColor = Color.White;
                        SideA.ForeColor = Color.Black;
                        break;
                    case "SideB":
                        SideB.BackColor = Color.White;
                        SideB.ForeColor = Color.Black;
                        break;
                    case "SideC":
                        SideC.BackColor = Color.White;
                        SideC.ForeColor = Color.Black;
                        break;
                }
            }
            if (SideA.BackColor ==Color.DarkRed || SideB.BackColor == Color.DarkRed || SideC.BackColor == Color.DarkRed)
            {
                Verifications.Text = "Введено некоректное значение";
            }
            else Verifications.Text = ""; 
        }
    }
}
