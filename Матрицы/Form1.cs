using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрицы
{
    public partial class Form1 : Form
    {
        private int order;
        private List<List<TextBox>> matrixOfTextBoxes = new List<List<TextBox>>();
        private List<List<TextBox>> matrixOfLabels = new List<List<TextBox>>();
        private List<List<float>> matrix = new List<List<float>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Изменился порядок определителя
            if (String.IsNullOrEmpty(orderTextBox.Text))
                return;
            order = Convert.ToInt32(orderTextBox.Text);
            foreach (List<TextBox> listOfTextBoxes in matrixOfTextBoxes)
            {
                foreach (TextBox textBox in listOfTextBoxes)
                {
                    this.Controls.Remove(textBox);
                }
                //PerformLayout();
            }
            matrixOfTextBoxes.Clear();
            matrix.Clear();
            for (int i = 0; i < order; i++)
            {
                List<TextBox> listOfTextboxes = new List<TextBox>();
                List<float> listOfFloats = new List<float>();
                for (int j = 0; j < order; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(33 + (j * 85), 100 + (i * 30));
                    textBox.Name = i.ToString() + j.ToString();
                    textBox.Size = new Size(75, 40);
                    textBox.TabIndex = 0;
                    textBox.Text = "0";
                    Controls.Add(textBox);
                    listOfTextboxes.Add(textBox);

                    float a;
                    float.TryParse(textBox.Text, out a);
                    listOfFloats.Add(a);
                }
                matrixOfTextBoxes.Add(listOfTextboxes);
                matrix.Add(listOfFloats);

            }
        }
        private void OutputMatrix(List<List<float>> matrix)
        {
            order = matrix.Count;
            foreach (List<TextBox> listOfLabels in matrixOfLabels)
            {
                foreach (TextBox label in listOfLabels)
                {
                    this.Controls.Remove(label);
                }
                //PerformLayout();
            }
            matrixOfLabels.Clear();
            for (int i = 0; i < order; i++)
            {
                List<TextBox> listOfLabels = new List<TextBox>();
                //List<float> listOfFloats = new List<float>();
                for (int j = 0; j < order; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(450 + (j * 85), 400 + (i * 30));
                    textBox.Name = i.ToString() + j.ToString();
                    textBox.Size = new Size(75, 40);
                    textBox.TabIndex = 0;
                    textBox.Text = matrix[i][j].ToString();
                    Controls.Add(textBox);
                    listOfLabels.Add(textBox);
                }
                matrixOfLabels.Add(listOfLabels);
            }
        }
        private void UpdateMatrix()
        {
            for (int i = 0; i < order; i++)
                for (int j = 0; j < order; j++)
                {
                    float a;
                    float.TryParse(matrixOfTextBoxes[i][j].Text, out a);
                    matrix[i][j] = a;
                }
        }
        private void CountDeterminant_Click(object sender, EventArgs e)
        {
            UpdateMatrix();
            DeterminantIs.Text = "det(A) = " + ReturnDeterminant(matrix).ToString();
        }
        private float ReturnDeterminant(List<List<float>> matrix)
        {
            int matrixOder = matrix.Count;
            //Раскладываем по строке:
            float determinant = 0;
            for(int s = 0; s < matrixOder; s++)
            {
                //List<List<float>> minor = new List<List<float>>();
                //for (int i = 1; i < matrixOder; i++)
                //{
                //    List<float> listOfFloats = new List<float>();
                //    for (int j = 0; j < matrixOder; j++)
                //        if (j != s)
                //            listOfFloats.Add(matrix[i][j]);
                //    minor.Add(listOfFloats);
                //}
                //float algebricAddition;
                //if (minor.Count != 0)
                //    algebricAddition = (float)Math.Pow(-1, s) * ReturnDeterminant(minor);
                //else
                //    algebricAddition = 1;
                float algebricAddition = AlgebricAddition(matrix, 1, s+1);
                determinant += matrix[0][s] * algebricAddition;
            }
            return determinant;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Обратная матрица
            UpdateMatrix();
            List<List<float>> inversedMatrix = InverseMatrix(matrix);
            OutputMatrix(inversedMatrix);
        }

        private List<List<float>> InverseMatrix (List<List<float>> matrix)
        {
            List<List<float>> inversedMatrix = new List<List<float>>();
            float matrixOder = matrix.Count;
            for (int i = 0; i < matrixOder; i++)
            {
                List<float> listOfFloats = new List<float>();
                for (int j = 0; j < matrixOder; j++)
                {
                    listOfFloats.Add(0);
                }
                inversedMatrix.Add(listOfFloats);
            }
            
            float determinant = ReturnDeterminant(matrix);
            if (determinant == 0)
                return inversedMatrix;
            for (int i = 1; i <= matrixOder; i++)
                for(int j = 1; j <= matrixOder; j++)
                {
                    float algebricAddition = AlgebricAddition(matrix, j, i);
                    inversedMatrix[i - 1][j - 1] = algebricAddition / determinant;
                }
            return inversedMatrix;
        }
        private float AlgebricAddition(List<List<float>> matrix, float rowFromOne, float columnFromOne)
        {
            float matrixOder = matrix.Count;
            List<List<float>> minor = new List<List<float>>();
            for (int i = 0; i < matrixOder; i++)
            {
                List<float> listOfFloats = new List<float>();
                bool addRowToMinor = false;
                for (int j = 0; j < matrixOder; j++)
                    if (j != columnFromOne - 1 && i != rowFromOne - 1)
                    {
                        listOfFloats.Add(matrix[i][j]);
                        addRowToMinor = true;
                    }
                if(addRowToMinor)
                    minor.Add(listOfFloats);
            }
            float algebricAddition;
            if (minor.Count != 0)
                algebricAddition = (float)Math.Pow(-1, rowFromOne + columnFromOne) * ReturnDeterminant(minor);
            else
                algebricAddition = 1;
            return algebricAddition;
        }
    }
}
