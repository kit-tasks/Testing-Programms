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
            switch (start.Text)
            {
                case "Проверить":
                    if (sideA.BackColor == Color.DarkRed || sideB.BackColor == Color.DarkRed || sideC.BackColor == Color.DarkRed || sideA.Text == "" || sideB.Text == "" || sideC.Text == "")
                    {
                        result.Text = "Повторите ввод";
                        sideA.Text = "";
                        sideB.Text = "";
                        sideC.Text = "";
                    }
                    else
                    {
                        int a, b, c;
                        start.Text = "Повторить";
                        a = Convert.ToInt32(sideA.Text);
                        b = Convert.ToInt32(sideB.Text);
                        c = Convert.ToInt32(sideC.Text);
                        sideA.Visible = false;
                        sideB.Visible = false;
                        sideC.Visible = false;
                        if (!VerificationOfExistence(a, b, c))
                        {
                            result.Text = "Треугольника не существеут";
                            break;
                        }
                        if (a == b)
                        {
                            if (b == c)
                            {
                                result.Text = "Треугольник равносторонний";
                            }
                            else { result.Text = "Треугольник равнобедренный"; }
                        }
                        else if (b == c)
                        {
                            result.Text = "Треугольник равнобедренный";
                        }
                        else if (a == c)
                        {
                            result.Text = "Треугольник равнобедренный";
                        }
                        else { result.Text = "Треугольник разносторонний"; }
                    }
                    break;
                case "Повторить":
                    {
                        start.Text = "Проверить";
                        result.Text = "";
                        sideA.Text = "";
                        sideB.Text = "";
                        sideC.Text = "";
                        sideA.Visible = true;
                        sideB.Visible = true;
                        sideC.Visible = true;
                        break;
                    }
            }
        }
        private static bool VerificationOfExistence(int a,int b,int c)
        {
            bool result = false;
            if (a + b > c && a + c > b && b + c > a)
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
                    str = sideA.Text;
                    break;
                case "SideB":
                    str = sideB.Text;
                    break;
                case "SideC":
                    str = sideC.Text;
                    break;
            }
            if (str == "")
            {
                return;
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
                        sideA.BackColor = Color.DarkRed;
                        sideA.ForeColor = Color.White;
                        break;
                    case "SideB":
                        sideB.BackColor = Color.DarkRed;
                        sideB.ForeColor = Color.White;
                        break;
                    case "SideC":
                        sideC.BackColor = Color.DarkRed;
                        sideC.ForeColor = Color.White;
                        break;
                }
            }
            else
            {
                switch ((sender as TextBox).Name)
                {
                    case "SideA":
                        sideA.BackColor = Color.White;
                        sideA.ForeColor = Color.Black;
                        break;
                    case "SideB":
                        sideB.BackColor = Color.White;
                        sideB.ForeColor = Color.Black;
                        break;
                    case "SideC":
                        sideC.BackColor = Color.White;
                        sideC.ForeColor = Color.Black;
                        break;
                }
            }
            if (sideA.BackColor ==Color.DarkRed || sideB.BackColor == Color.DarkRed || sideC.BackColor == Color.DarkRed)
            {
                verifications.Text = "Введено некоректное значение";
            }
            else verifications.Text = ""; 
        }
    }
}