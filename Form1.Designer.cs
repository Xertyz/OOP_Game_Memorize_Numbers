namespace GameMemorizeNumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMain = new TextBox();
            buttonStart = new Button();
            labelDifficulty = new Label();
            labelAccuracy = new Label();
            labelCountRN = new Label();
            comboBoxDiff = new ComboBox();
            comboBoxCountRN = new ComboBox();
            buttonInput = new Button();
            richTextBoxPlayerName = new RichTextBox();
            labelPlayerName = new Label();
            richTextBoxRandomNumbers = new RichTextBox();
            buttonStartTest = new Button();
            richTextBoxAccuracy = new RichTextBox();
            SuspendLayout();
            // 
            // textBoxMain
            // 
            textBoxMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMain.Location = new Point(316, 184);
            textBoxMain.Margin = new Padding(3, 2, 3, 2);
            textBoxMain.MaxLength = 35;
            textBoxMain.Multiline = true;
            textBoxMain.Name = "textBoxMain";
            textBoxMain.PlaceholderText = "0 0 0";
            textBoxMain.Size = new Size(556, 43);
            textBoxMain.TabIndex = 0;
            textBoxMain.TextAlign = HorizontalAlignment.Center;
            textBoxMain.KeyPress += textBoxMain_KeyPress;
            // 
            // buttonStart
            // 
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(471, 263);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(118, 36);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelDifficulty
            // 
            labelDifficulty.AutoSize = true;
            labelDifficulty.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDifficulty.Location = new Point(14, 19);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new Size(189, 25);
            labelDifficulty.TabIndex = 2;
            labelDifficulty.Text = "Уровень сложности:";
            // 
            // labelAccuracy
            // 
            labelAccuracy.AutoSize = true;
            labelAccuracy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccuracy.Location = new Point(14, 286);
            labelAccuracy.Name = "labelAccuracy";
            labelAccuracy.Size = new Size(97, 25);
            labelAccuracy.TabIndex = 3;
            labelAccuracy.Text = "Точность:";
            // 
            // labelCountRN
            // 
            labelCountRN.AutoSize = true;
            labelCountRN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountRN.Location = new Point(29, 59);
            labelCountRN.Name = "labelCountRN";
            labelCountRN.Size = new Size(174, 25);
            labelCountRN.TabIndex = 5;
            labelCountRN.Text = "Количество чисел:";
            // 
            // comboBoxDiff
            // 
            comboBoxDiff.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiff.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDiff.FormattingEnabled = true;
            comboBoxDiff.Items.AddRange(new object[] { "Легкий", "Средний", "Высокий" });
            comboBoxDiff.Location = new Point(206, 19);
            comboBoxDiff.Margin = new Padding(3, 2, 3, 2);
            comboBoxDiff.Name = "comboBoxDiff";
            comboBoxDiff.Size = new Size(133, 33);
            comboBoxDiff.TabIndex = 6;
            comboBoxDiff.SelectedIndexChanged += comboBoxDiff_SelectedIndexChanged;
            // 
            // comboBoxCountRN
            // 
            comboBoxCountRN.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountRN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCountRN.FormattingEnabled = true;
            comboBoxCountRN.Items.AddRange(new object[] { "5", "7", "9" });
            comboBoxCountRN.Location = new Point(206, 56);
            comboBoxCountRN.Margin = new Padding(3, 2, 3, 2);
            comboBoxCountRN.Name = "comboBoxCountRN";
            comboBoxCountRN.Size = new Size(133, 33);
            comboBoxCountRN.TabIndex = 7;
            comboBoxCountRN.SelectedIndexChanged += comboBoxCountRN_SelectedIndexChanged;
            // 
            // buttonInput
            // 
            buttonInput.FlatStyle = FlatStyle.Flat;
            buttonInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInput.Location = new Point(595, 263);
            buttonInput.Margin = new Padding(3, 2, 3, 2);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(118, 36);
            buttonInput.TabIndex = 8;
            buttonInput.Text = "Ввести";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonCheck_Click;
            // 
            // richTextBoxPlayerName
            // 
            richTextBoxPlayerName.BackColor = SystemColors.Control;
            richTextBoxPlayerName.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxPlayerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxPlayerName.Location = new Point(517, 70);
            richTextBoxPlayerName.Margin = new Padding(3, 2, 3, 2);
            richTextBoxPlayerName.Multiline = false;
            richTextBoxPlayerName.Name = "richTextBoxPlayerName";
            richTextBoxPlayerName.RightToLeft = RightToLeft.No;
            richTextBoxPlayerName.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxPlayerName.Size = new Size(149, 30);
            richTextBoxPlayerName.TabIndex = 9;
            richTextBoxPlayerName.Text = "Player1";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(398, 72);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(117, 25);
            labelPlayerName.TabIndex = 10;
            labelPlayerName.Text = "Имя игрока:";
            // 
            // richTextBoxRandomNumbers
            // 
            richTextBoxRandomNumbers.BackColor = SystemColors.Control;
            richTextBoxRandomNumbers.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxRandomNumbers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxRandomNumbers.Location = new Point(352, 123);
            richTextBoxRandomNumbers.Margin = new Padding(3, 2, 3, 2);
            richTextBoxRandomNumbers.Multiline = false;
            richTextBoxRandomNumbers.Name = "richTextBoxRandomNumbers";
            richTextBoxRandomNumbers.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxRandomNumbers.Size = new Size(453, 30);
            richTextBoxRandomNumbers.TabIndex = 11;
            richTextBoxRandomNumbers.Text = "-----";
            // 
            // buttonStartTest
            // 
            buttonStartTest.FlatStyle = FlatStyle.Flat;
            buttonStartTest.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartTest.Location = new Point(471, 303);
            buttonStartTest.Margin = new Padding(3, 2, 3, 2);
            buttonStartTest.Name = "buttonStartTest";
            buttonStartTest.Size = new Size(242, 36);
            buttonStartTest.TabIndex = 13;
            buttonStartTest.Text = "Начать тест";
            buttonStartTest.UseVisualStyleBackColor = true;
            buttonStartTest.Click += buttonStartTest_Click;
            // 
            // richTextBoxAccuracy
            // 
            richTextBoxAccuracy.BackColor = SystemColors.Control;
            richTextBoxAccuracy.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxAccuracy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxAccuracy.Location = new Point(117, 284);
            richTextBoxAccuracy.Margin = new Padding(3, 2, 3, 2);
            richTextBoxAccuracy.Multiline = false;
            richTextBoxAccuracy.Name = "richTextBoxAccuracy";
            richTextBoxAccuracy.RightToLeft = RightToLeft.No;
            richTextBoxAccuracy.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxAccuracy.Size = new Size(149, 30);
            richTextBoxAccuracy.TabIndex = 14;
            richTextBoxAccuracy.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 511);
            Controls.Add(richTextBoxAccuracy);
            Controls.Add(buttonStartTest);
            Controls.Add(richTextBoxRandomNumbers);
            Controls.Add(labelPlayerName);
            Controls.Add(richTextBoxPlayerName);
            Controls.Add(buttonInput);
            Controls.Add(comboBoxCountRN);
            Controls.Add(comboBoxDiff);
            Controls.Add(labelCountRN);
            Controls.Add(labelAccuracy);
            Controls.Add(labelDifficulty);
            Controls.Add(buttonStart);
            Controls.Add(textBoxMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMain;
        private Button buttonStart;
        private Label labelDifficulty;
        private Label labelAccuracy;
        private Label labelCountRN;
        private ComboBox comboBoxDiff;
        private ComboBox comboBoxCountRN;
        private Button buttonInput;
        private RichTextBox richTextBoxPlayerName;
        private Label labelPlayerName;
        private RichTextBox richTextBoxRandomNumbers;
        private Button buttonStartTest;
        private RichTextBox richTextBoxAccuracy;
    }
}