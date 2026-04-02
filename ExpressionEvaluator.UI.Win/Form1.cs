using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AsignarEventosBotones();
        }

        private void AsignarEventosBotones()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button boton)
                {
                    boton.Click += EventoClickBoton;
                }
            }
        }

        private void EventoClickBoton(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton == null) return;

            string textoBoton = boton.Text;

            switch (textoBoton)
            {
                case "=":
                    EjecutarCalculo();
                    break;

                case "Clear":
                    LimpiarPantalla();
                    break;

                case "Delete":
                    BorrarUltimoCaracter();
                    break;

                default:
                    AgregarTextoPantalla(textoBoton);
                    break;
            }
        }

        private void AgregarTextoPantalla(string texto)
        {
            txtDisplay.Text += texto;
        }

        private void LimpiarPantalla()
        {
            txtDisplay.Clear();
        }

        private void BorrarUltimoCaracter()
        {
            if (txtDisplay.TextLength > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
            }
        }

        private void EjecutarCalculo()
        {
            try
            {
                string expresionOriginal = txtDisplay.Text;

                string expresionProcesada = ProcesarPotencias(expresionOriginal);

                double resultado = EvaluarExpresion(expresionProcesada);

                txtDisplay.Text = resultado.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }

        private string ProcesarPotencias(string expresion)
        {
            Regex patron = new Regex(@"(\d+(\.\d+)?)\^(\d+(\.\d+)?)");

            while (patron.IsMatch(expresion))
            {
                expresion = patron.Replace(expresion, match =>
                {
                    double baseNum = double.Parse(match.Groups[1].Value);
                    double expNum = double.Parse(match.Groups[3].Value);

                    double resultado = Math.Pow(baseNum, expNum);

                    return resultado.ToString();
                });
            }

            return expresion;
        }

        private double EvaluarExpresion(string expresion)
        {
            var valores = new Stack<double>();
            var operadores = new Stack<char>();

            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];

                if (char.IsDigit(c) || c == '.')
                {
                    string numero = "";

                    while (i < expresion.Length && (char.IsDigit(expresion[i]) || expresion[i] == '.'))
                    {
                        numero += expresion[i];
                        i++;
                    }

                    valores.Push(double.Parse(numero));
                    i--;
                }
                else if (c == '(')
                {
                    operadores.Push(c);
                }
                else if (c == ')')
                {
                    while (operadores.Peek() != '(')
                    {
                        double val2 = valores.Pop();
                        double val1 = valores.Pop();
                        char op = operadores.Pop();

                        valores.Push(AplicarOperacion(val1, val2, op));
                    }
                    operadores.Pop();
                }
                else if ("+-*/".Contains(c))
                {
                    while (operadores.Count > 0 && Prioridad(operadores.Peek()) >= Prioridad(c))
                    {
                        double val2 = valores.Pop();
                        double val1 = valores.Pop();
                        char op = operadores.Pop();

                        valores.Push(AplicarOperacion(val1, val2, op));
                    }
                    operadores.Push(c);
                }
            }

            while (operadores.Count > 0)
            {
                double val2 = valores.Pop();
                double val1 = valores.Pop();
                char op = operadores.Pop();

                valores.Push(AplicarOperacion(val1, val2, op));
            }

            return valores.Pop();
        }

        private int Prioridad(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        private double AplicarOperacion(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btn7_Click(object sender, EventArgs e) { txtDisplay.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { txtDisplay.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { txtDisplay.Text += "9"; }
        private void btn4_Click(object sender, EventArgs e) { txtDisplay.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { txtDisplay.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { txtDisplay.Text += "6"; }
        private void btn1_Click(object sender, EventArgs e) { txtDisplay.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { txtDisplay.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { txtDisplay.Text += "3"; }
        private void btn0_Click(object sender, EventArgs e) { txtDisplay.Text += "0"; }
        private void btnDot_Click(object sender, EventArgs e) { txtDisplay.Text += "."; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = String.Empty;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength > 0)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
        }

        private void btnPow_Click(object sender, EventArgs e) { txtDisplay.Text += "^"; }
        private void btnOpenParenthesis_Click(object sender, EventArgs e) { txtDisplay.Text += "("; }
        private void btnCloseParenthesis_Click(object sender, EventArgs e) { txtDisplay.Text += ")"; }
        private void btnMultiply_Click(object sender, EventArgs e) { txtDisplay.Text += "*"; }
        private void btnDivide_Click(object sender, EventArgs e) { txtDisplay.Text += "/"; }
        private void btnMinus_Click(object sender, EventArgs e) { txtDisplay.Text += "-"; }
        private void btnplus_Click(object sender, EventArgs e) { txtDisplay.Text += "+"; }

        private void btnResult_Click(object sender, EventArgs e) { }
    }
}