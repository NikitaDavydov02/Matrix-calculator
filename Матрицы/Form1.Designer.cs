namespace Матрицы
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CountDeterminant = new System.Windows.Forms.Button();
            this.DeterminantIs = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(161, 35);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(75, 20);
            this.orderTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порядок матрицы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Построить матрицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountDeterminant
            // 
            this.CountDeterminant.Location = new System.Drawing.Point(381, 32);
            this.CountDeterminant.Name = "CountDeterminant";
            this.CountDeterminant.Size = new System.Drawing.Size(160, 23);
            this.CountDeterminant.TabIndex = 3;
            this.CountDeterminant.Text = "Вычислить определитель";
            this.CountDeterminant.UseVisualStyleBackColor = true;
            this.CountDeterminant.Click += new System.EventHandler(this.CountDeterminant_Click);
            // 
            // DeterminantIs
            // 
            this.DeterminantIs.AutoSize = true;
            this.DeterminantIs.Location = new System.Drawing.Point(547, 38);
            this.DeterminantIs.Name = "DeterminantIs";
            this.DeterminantIs.Size = new System.Drawing.Size(47, 13);
            this.DeterminantIs.TabIndex = 4;
            this.DeterminantIs.Text = "det(A) = ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обратная матрица";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeterminantIs);
            this.Controls.Add(this.CountDeterminant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CountDeterminant;
        private System.Windows.Forms.Label DeterminantIs;
        private System.Windows.Forms.Button button2;
    }
}

