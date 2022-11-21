namespace Discretka_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonExe = new System.Windows.Forms.Button();
            this.labelExe = new System.Windows.Forms.Label();
            this.buttonError = new System.Windows.Forms.Button();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textStart = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxAnswer);
            this.panel1.Controls.Add(this.labelAnswer);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.labelClear);
            this.panel1.Controls.Add(this.buttonExe);
            this.panel1.Controls.Add(this.labelExe);
            this.panel1.Controls.Add(this.buttonError);
            this.panel1.Controls.Add(this.labelError2);
            this.panel1.Controls.Add(this.labelError1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.textStart);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(85, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 157);
            this.panel1.TabIndex = 0;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.DarkOrange;
            this.textBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnswer.Location = new System.Drawing.Point(25, 55);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(1234, 21);
            this.textBoxAnswer.TabIndex = 11;
            this.textBoxAnswer.Visible = false;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(21, 32);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(367, 20);
            this.labelAnswer.TabIndex = 10;
            this.labelAnswer.Text = "Эйлеров цикл для заданного графа:";
            this.labelAnswer.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(1111, 99);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(148, 38);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Location = new System.Drawing.Point(21, 102);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(858, 20);
            this.labelClear.TabIndex = 8;
            this.labelClear.Text = "Нажмите кнопку \"Очистить\", если хотите построить Эйлеров цикл для другого графа.";
            this.labelClear.Visible = false;
            // 
            // buttonExe
            // 
            this.buttonExe.BackColor = System.Drawing.Color.Orange;
            this.buttonExe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExe.ForeColor = System.Drawing.Color.Black;
            this.buttonExe.Location = new System.Drawing.Point(1111, 61);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(148, 38);
            this.buttonExe.TabIndex = 7;
            this.buttonExe.Text = "Построить";
            this.buttonExe.UseVisualStyleBackColor = false;
            this.buttonExe.Visible = false;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // labelExe
            // 
            this.labelExe.AutoSize = true;
            this.labelExe.Location = new System.Drawing.Point(21, 61);
            this.labelExe.Name = "labelExe";
            this.labelExe.Size = new System.Drawing.Size(957, 20);
            this.labelExe.TabIndex = 6;
            this.labelExe.Text = "Заполните матрицу смежности и нажмите кнопку \"Построить\" для построения Эйлерова " +
    "цикла.";
            this.labelExe.Visible = false;
            // 
            // buttonError
            // 
            this.buttonError.BackColor = System.Drawing.Color.Orange;
            this.buttonError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonError.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonError.ForeColor = System.Drawing.Color.Black;
            this.buttonError.Location = new System.Drawing.Point(744, 65);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(75, 30);
            this.buttonError.TabIndex = 5;
            this.buttonError.Text = "OK";
            this.buttonError.UseVisualStyleBackColor = false;
            this.buttonError.Visible = false;
            this.buttonError.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Location = new System.Drawing.Point(21, 73);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(592, 20);
            this.labelError2.TabIndex = 4;
            this.labelError2.Text = "Попробуйте задать матрицу смежности для другого графа.";
            this.labelError2.Visible = false;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Location = new System.Drawing.Point(21, 32);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(392, 20);
            this.labelError1.TabIndex = 3;
            this.labelError1.Text = "Данный граф не является Эйлеровым!";
            this.labelError1.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Orange;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(556, 65);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 30);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "OK";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textStart
            // 
            this.textStart.BackColor = System.Drawing.Color.Orange;
            this.textStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStart.ForeColor = System.Drawing.Color.Black;
            this.textStart.Location = new System.Drawing.Point(439, 65);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(60, 28);
            this.textStart.TabIndex = 1;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStart.Location = new System.Drawing.Point(21, 69);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(362, 20);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Введите количество вершин графа:";
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AllowUserToResizeColumns = false;
            this.matrix.AllowUserToResizeRows = false;
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.matrix.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.matrix.Location = new System.Drawing.Point(500, 362);
            this.matrix.Name = "matrix";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.matrix.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.matrix.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.Size = new System.Drawing.Size(450, 400);
            this.matrix.TabIndex = 1;
            this.matrix.Visible = false;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.BackColor = System.Drawing.Color.Transparent;
            this.labelMatrix.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrix.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMatrix.Location = new System.Drawing.Point(406, 318);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Padding = new System.Windows.Forms.Padding(199, 5, 199, 5);
            this.labelMatrix.Size = new System.Drawing.Size(632, 30);
            this.labelMatrix.TabIndex = 3;
            this.labelMatrix.Text = "МАТРИЦА СМЕЖНОСТИ";
            this.labelMatrix.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Введите количество вершин графа";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.Label labelExe;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
    }
}

