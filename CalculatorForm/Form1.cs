using Calculator;
using System;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        private readonly Context _context;

        public Form1()
        {
            InitializeComponent();
            _context = new Context(new ReversePolishNotationAlgorithm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var answer = _context.ExecuteAlgorithm(textBox1.Text);
                label3.Text = $"Answer: {answer}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
