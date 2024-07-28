using System.Collections;
using System.Drawing.Drawing2D;
using System.Formats.Asn1;
using MathNet.Numerics.LinearAlgebra;

namespace EncriptarV1
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

        private void EncriptarBtn_Click(object sender, EventArgs e)
        {
            Dictionary<char, float> dict = new()
            {
                {'a', 1}, {'b',2}, {'c',3}, {'d',4}, {'e',5}, {'f', 6}, {'g', 7}, {'h', 8}, {'i', 9},
                {'j', 10}, {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14}, {'o', 15}, {'p', 16},
                {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20}, {'u', 21}, {'v', 22}, {'w', 23},
                {'x', 24}, {'y', 25}, {'z', 26}, {' ', 27}
            };

            try
            {
                String msg = textBox1.Text;
                if (msg == "")
                {
                    throw new ArgumentException("Debes incluir un mensaje");
                }
                // Complete whith spaces
                if (msg.Length % 3 == 1)
                {
                    msg += "  ";
                }
                else if (msg.Length % 3 == 1)
                {
                    msg += " ";
                }

                // Get the number of columns in the matrix
                int col = (msg.Length / 3);
                if (msg.Length % 3 == 1 || msg.Length % 3 == 2)
                {
                    col++;
                }

                // Save code in a matrix
                float[,] postB = new float[3, col];

                int y = 0;
                int x = 0;
                foreach (char letter in msg.ToLower())
                {
                    postB[y, x] = dict[letter];
                    y++;
                    if (y == 3)
                    {
                        y = 0;
                        x++;
                    }
                }
                var B = Matrix<float>.Build.Dense(3, col, (i, j) => postB[i, j]);

                // Get encode matrix
                var A = Matrix<float>.Build.DenseOfArray(new float[,] {
                { float.Parse(mat1.Text), float.Parse(mat2.Text), float.Parse(mat3.Text) },
                { float.Parse(mat4.Text), float.Parse(mat5.Text), float.Parse(mat6.Text) },
                { float.Parse(mat7.Text), float.Parse(mat8.Text), float.Parse(mat9.Text) } });

                // Multiply matrix A and matrix B
                var ans = A * B;
                String code = "";
                int n = 0;
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        code += ans[j, i] + " ";
                        n++;
                        if (n > 14)
                        {
                            code += "\n";
                            n = 0;
                        }
                    }
                }

                label1.Text = "Respuesta";
                label1.Text += ":\n" + ans.ToString() + "\nCódigo: " + code;

                // Find the inverse of A
                if (A.Determinant() == 0)
                {
                    throw new InvalidOperationException("No hay matriz inversa");
                }
                var A_inv = A.Inverse();

                // Get the original msg
            }
            catch (Exception ex)
            {
                if (ex is KeyNotFoundException)
                {
                    MessageBox.Show($"Has ingresado un caracter no válido como mensaje\nSolo se permiten letras, la ñ no es un caracter válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show($"Debes llenar la matriz principal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is ArgumentException)
                {
                    MessageBox.Show($"Debes incluir un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show($"Matriz inversa inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error inesperado.\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<double, char> dict = new()
            {
                {1, 'a'}, {2, 'b'}, {3, 'c'}, {4, 'd'}, {5, 'e'}, {6, 'f'}, {7, 'g'}, {8, 'h'}, {9, 'i'},
                {10, 'j'}, {11, 'k'}, {12, 'l'}, {13, 'm'}, {14, 'n'}, {15, 'o'}, {16, 'p'},
                {17, 'q'}, {18, 'r'}, {19, 's'}, {20, 't'}, {21, 'u'}, {22, 'v'}, {23, 'w'},
                {24, 'x'}, {25, 'y'}, {26, 'z'}, {27, ' '}
            };

            try
            {
                if (textBox1.Text == "")
                {
                    throw new ArgumentException("Debes incluir un mensaje");
                }
                String[] msg = textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int col = (int)Math.Ceiling(msg.Length / 3.0);
                double[,] postB = new double[3, col];

                int index = 0;
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (double.TryParse(msg[index], out double numero))
                        {
                            postB[j, i] = numero;
                        }
                        else
                        {
                            throw new KeyNotFoundException("Error");
                        }
                        index++;
                    }
                }
                var B = Matrix<double>.Build.Dense(3, col, (i, j) => postB[i, j]);
                // Get encode matrix
                var A = Matrix<double>.Build.DenseOfArray(new double[,] {
                { double.Parse(mat1.Text), double.Parse(mat2.Text), double.Parse(mat3.Text) },
                { double.Parse(mat4.Text), double.Parse(mat5.Text), double.Parse(mat6.Text) },
                { double.Parse(mat7.Text), double.Parse(mat8.Text), double.Parse(mat9.Text) } });
                if (A.Determinant() == 0)
                {
                    throw new InvalidOperationException("No hay matriz inversa");
                } else
                {
                    var invA = A.Inverse();
                    var ans = invA * B;

                    String code = "";
                    int n = 0;
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            code += dict[Math.Round(ans[j, i])];
                            n++;
                            if (n > 45)
                            {
                                code += "\n";
                                n = 0;
                            }
                        }
                    }

                    label1.Text = "Respuesta";
                    label1.Text = ":\n" + ans.ToString() + "\nCódigo: " + code;
                }
            }
            catch (Exception ex)
            {
                if (ex is KeyNotFoundException)
                {
                    MessageBox.Show($"Es posible que has ingresado un caracter no válido como mensaje\nSolo se permiten números separados por espacios\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show($"Debes llenar la matriz principal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is ArgumentException)
                {
                    MessageBox.Show($"Debes incluir un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show($"Matriz inversa inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error inesperado.\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            mat1.Text = "";
            mat2.Text = "";
            mat3.Text = "";
            mat4.Text = "";
            mat5.Text = "";
            mat6.Text = "";
            mat7.Text = "";
            mat8.Text = "";
            mat9.Text = "";
        }
    }
}
