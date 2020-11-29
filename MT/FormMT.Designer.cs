namespace MT
{
    partial class FormMT
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
            this.tableOfInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LongOfTape = new System.Windows.Forms.ComboBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.Alphabet = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableOfInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOfInfo
            // 
            this.tableOfInfo.AllowUserToAddRows = false;
            this.tableOfInfo.AllowUserToResizeColumns = false;
            this.tableOfInfo.AllowUserToResizeRows = false;
            this.tableOfInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOfInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.tableOfInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableOfInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOfInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tableOfInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(99)))));
            this.tableOfInfo.Location = new System.Drawing.Point(95, 148);
            this.tableOfInfo.MultiSelect = false;
            this.tableOfInfo.Name = "tableOfInfo";
            this.tableOfInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableOfInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableOfInfo.RowHeadersVisible = false;
            this.tableOfInfo.Size = new System.Drawing.Size(636, 253);
            this.tableOfInfo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "+";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "_";
            this.Column2.Name = "Column2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(99)))));
            this.dataGridView2.Location = new System.Drawing.Point(1, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView2.Size = new System.Drawing.Size(740, 77);
            this.dataGridView2.TabIndex = 1;
            // 
            // LongOfTape
            // 
            this.LongOfTape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(199)))), ((int)(((byte)(193)))));
            this.LongOfTape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongOfTape.FormattingEnabled = true;
            this.LongOfTape.Items.AddRange(new object[] {
            "128",
            "512",
            "1024"});
            this.LongOfTape.Location = new System.Drawing.Point(95, 9);
            this.LongOfTape.Name = "LongOfTape";
            this.LongOfTape.Size = new System.Drawing.Size(90, 21);
            this.LongOfTape.TabIndex = 2;
            this.LongOfTape.SelectedIndexChanged += new System.EventHandler(this.LongOfTape_SelectedIndexChanged);
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(12, 12);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(77, 13);
            this.labelLong.TabIndex = 3;
            this.labelLong.Text = "Длина ленты:";
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(198, 12);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(54, 13);
            this.labelAlpha.TabIndex = 4;
            this.labelAlpha.Text = "Алфавит:";
            // 
            // Alphabet
            // 
            this.Alphabet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(199)))), ((int)(((byte)(193)))));
            this.Alphabet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alphabet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(99)))));
            this.Alphabet.Location = new System.Drawing.Point(258, 9);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(155, 20);
            this.Alphabet.TabIndex = 5;
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(199)))), ((int)(((byte)(193)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(99)))));
            this.InputBox.Location = new System.Drawing.Point(515, 9);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(137, 20);
            this.InputBox.TabIndex = 6;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(419, 12);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(90, 13);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Входная строка:";
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Location = new System.Drawing.Point(658, 7);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 8;
            this.getButton.Text = "Принять";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(496, 118);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(577, 119);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Сброс";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(13, 171);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить состояние";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(13, 200);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // FormMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(743, 404);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Alphabet);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.LongOfTape);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tableOfInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(140)))), ((int)(((byte)(99)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableOfInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableOfInfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox LongOfTape;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.TextBox Alphabet;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

