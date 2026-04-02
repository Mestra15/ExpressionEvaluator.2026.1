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

        // 🔥 CORREGIDO: solo asigna a botones especiales
        private void AsignarEventosBotones()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button boton)
                {
                    if (boton.Text == "=" ||
                        boton.Text == "Clear" ||
                        boton.Text == "Delete")
                    {
                        boton.Click += EventoClickBoton;
                    }
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
                string expresion = txtDisplay.Text;

                Queue<string> postfijo = InfixToPostfix(expresion);

                double resultado = EvaluarPostfijo(postfijo);

                txtDisplay.Text = resultado.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }

        private Queue<string> InfixToPostfix(string expresion)
        {
            Queue<string> salida = new Queue<string>();
            Stack<string> operadores = new Stack<string>();

            string numero = "";

            foreach (char c in expresion)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    numero += c;
                }
                else
                {
                    if (numero != "")
                    {
                        salida.Enqueue(numero);
                        numero = "";
                    }

                    if (c == '(')
                    {
                        operadores.Push(c.ToString());
                    }
                    else if (c == ')')
                    {
                        while (operadores.Peek() != "(")
                            salida.Enqueue(operadores.Pop());

                        operadores.Pop();
                    }
                    else
                    {
                        while (operadores.Count > 0 &&
                               Prioridad(operadores.Peek()) >= Prioridad(c.ToString()))
                        {
                            salida.Enqueue(operadores.Pop());
                        }

                        operadores.Push(c.ToString());
                    }
                }
            }

            if (numero != "")
                salida.Enqueue(numero);

            while (operadores.Count > 0)
                salida.Enqueue(operadores.Pop());

            return salida;
        }

        private double EvaluarPostfijo(Queue<string> cola)
        {
            Stack<double> pila = new Stack<double>();

            while (cola.Count > 0)
            {
                string token = cola.Dequeue();

                if (double.TryParse(token, out double numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    double b = pila.Pop();
                    double a = pila.Pop();

                    switch (token)
                    {
                        case "+": pila.Push(a + b); break;
                        case "-": pila.Push(a - b); break;
                        case "*": pila.Push(a * b); break;
                        case "/": pila.Push(a / b); break;
                        case "^": pila.Push(Math.Pow(a, b)); break;
                    }
                }
            }

            return pila.Pop();
        }

        private int Prioridad(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            if (op == "^") return 3;
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btn7_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "9"; }
        private void btn4_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "6"; }
        private void btn1_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "3"; }
        private void btn0_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "0"; }
        private void btnDot_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "."; }

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
        private void btnOpenParenthesis_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "("; }
        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        { txtDisplay.Text += ")"; }
        private void btnMultiply_Click(object sender, EventArgs e)
        { txtDisplay.Text += "*"; }
        private void btnDivide_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "/"; }
        private void btnMinus_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "-"; }
        private void btnplus_Click(object sender, EventArgs e) 
        { txtDisplay.Text += "+"; }

        private void btnResult_Click(object sender, EventArgs e) { }
    }
}