namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private int CalcularCuadrado(int num)
        {
            return num * num;
        }

        private int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int CalcularMCM(int a, int b)
        {
            return (a * b) / CalcularMCD(a, b);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados
                int num1 = int.Parse(num1TextBox.Text);
                int num2 = int.Parse(num2TextBox.Text);
                int resultado = 0;

                // Realizar la operación según el RadioButton seleccionado
                if (cuadradoRadioButton.Checked)
                {
                    resultado = CalcularCuadrado(num1);
                    resultadoLabel.Text = $"Cuadrado de {num1}: {resultado}";
                }
                else if (mcmRadioButton.Checked)
                {
                    resultado = CalcularMCM(num1, num2);
                    resultadoLabel.Text = $"MCM de {num1} y {num2}: {resultado}";
                }

                // Limpiar los TextBox después de la operación
                num1TextBox.Clear();
                num2TextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números enteros válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
