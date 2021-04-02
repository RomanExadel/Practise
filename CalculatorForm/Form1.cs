using Calculator;
using System;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        private Context _context;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(nameof(ReversePolishNotationAlgorithm));
            comboBox1.Items.Add(nameof(SimpleAlgorithm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null)
            {
                MessageBox.Show("Select an algorithm");
                return;
            }

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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "ReversePolishNotationAlgorithm":
                    _context = new Context(new ReversePolishNotationAlgorithm());
                    break;
                case "SimpleAlgorithm":
                    _context = new Context(new SimpleAlgorithm());
                    break;
                default:
                    break;
            }
        }
    }
}
