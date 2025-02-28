using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public class MainForm : Form
    {
        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private ComboBox comboBoxOperator;
        private Button buttonCalculate;
        private Label labelResult;

        public MainForm()
        {
            // 设置窗体属性
            this.Text = "SimpleCalculator";
            this.Width = 300;
            this.Height = 200;

            // 初始化控件
            InitializeControls();
        }

        private void InitializeControls()
        {
            // TextBox 1
            textBoxNumber1 = new TextBox
            {
                Location = new System.Drawing.Point(10, 10),
                Width = 100
            };
            this.Controls.Add(textBoxNumber1);

            // TextBox 2
            textBoxNumber2 = new TextBox
            {
                Location = new System.Drawing.Point(10, 40),
                Width = 100
            };
            this.Controls.Add(textBoxNumber2);

            // ComboBox
            comboBoxOperator = new ComboBox
            {
                Location = new System.Drawing.Point(120, 10),
                Width = 50
            };
            comboBoxOperator.Items.AddRange(new string[] { "+", "-", "*", "/" });
            this.Controls.Add(comboBoxOperator);

            // Button
            buttonCalculate = new Button
            {
                Text = "计算",
                Location = new System.Drawing.Point(120, 40),
                Width = 70
            };
            buttonCalculate.Click += new EventHandler(ButtonCalculate_Click);
            this.Controls.Add(buttonCalculate);

            // Label
            labelResult = new Label
            {
                Location = new System.Drawing.Point(10, 80),
                Width = 200,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Text = "结果："
            };
            this.Controls.Add(labelResult);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(textBoxNumber1.Text);
                double number2 = double.Parse(textBoxNumber2.Text);
                string operatorSelected = comboBoxOperator.SelectedItem.ToString();

                double result = 0;
                switch (operatorSelected)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            MessageBox.Show("除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = number1 / number2;
                        break;
                    default:
                        MessageBox.Show("请选择一个有效的运算符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                labelResult.Text = $"结果：{result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}