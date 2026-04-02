using System.Drawing;
using System.Windows.Forms;

namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
    {
        private TextBox txtDisplay;

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btnResult = new Button();
            btn0 = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btnOpenParenthesis = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPow = new Button();
            btnplus = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(485, 47);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 128, 0);
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(27, 97);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 49);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 128, 0);
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(159, 97);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 49);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 128, 0);
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(93, 97);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 49);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 128, 0);
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(93, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 49);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 128, 0);
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(159, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 49);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 128, 0);
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(27, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 49);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 128, 0);
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(93, 207);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 49);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 128, 0);
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(159, 207);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 49);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 128, 0);
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(27, 207);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 49);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(255, 128, 0);
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(159, 262);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 49);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(242, 264);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(263, 49);
            btnResult.TabIndex = 11;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 128, 0);
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(27, 262);
            btn0.Name = "btn0";
            btn0.Size = new Size(126, 49);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(308, 97);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(60, 49);
            btnCloseParenthesis.TabIndex = 15;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(374, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 49);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(242, 97);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(60, 49);
            btnOpenParenthesis.TabIndex = 13;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Microsoft Sans Serif", 18F);
            btnDivide.Location = new Point(308, 152);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 49);
            btnDivide.TabIndex = 18;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Microsoft Sans Serif", 18F);
            btnClear.Location = new Point(374, 152);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 49);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Microsoft Sans Serif", 18F);
            btnMultiply.Location = new Point(242, 152);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 49);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Microsoft Sans Serif", 18F);
            btnMinus.Location = new Point(308, 209);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 49);
            btnMinus.TabIndex = 21;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Microsoft Sans Serif", 18F);
            btnPow.Location = new Point(374, 209);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(131, 49);
            btnPow.TabIndex = 20;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.FromArgb(255, 128, 0);
            btnplus.Font = new Font("Microsoft Sans Serif", 18F);
            btnplus.Location = new Point(242, 209);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(60, 49);
            btnplus.TabIndex = 19;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackColor = Color.Black;
            ClientSize = new Size(530, 400);
            Controls.Add(btnMinus);
            Controls.Add(btnPow);
            Controls.Add(btnplus);
            Controls.Add(btnDivide);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnDelete);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnDot);
            Controls.Add(btnResult);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void CrearBotones()
        {
            string[,] layout = {
                { "7","8","9","("," )","Delete"},
                { "4","5","6","*","/","Clear"},
                { "1","2","3","+","-","^"},
                { "0",".","=","","",""}
            };

            int startX = 20;
            int startY = 90;
            int btnW = 60;
            int btnH = 60;
            int espacio = 10;

            for (int i = 0; i < 4; i++)
            {
                int x = startX;

                for (int j = 0; j < 6; j++)
                {
                    if (layout[i, j] == "") continue;

                    Button btn = new Button();
                    btn.Text = layout[i, j];
                    btn.Font = new Font("Segoe UI", 14F);
                    btn.Size = new Size(btnW, btnH);
                    btn.Location = new Point(x, startY + i * (btnH + espacio));

                    if ("+-*/^()=".Contains(btn.Text) || btn.Text == "Clear" || btn.Text == "Delete")
                        btn.BackColor = Color.Orange;
                    else
                        btn.BackColor = Color.White;

                    Controls.Add(btn);

                    x += btnW + espacio;
                }
            }
        }

        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btnDot;
        private Button btnResult;
        private Button btn0;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btnOpenParenthesis;
        private Button btnDivide;
        private Button btnClear;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPow;
        private Button btnplus;
    }
}