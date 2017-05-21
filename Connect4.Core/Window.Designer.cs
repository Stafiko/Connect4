namespace Connect4.Core
{
    partial class Window
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
            this.Radio1P = new System.Windows.Forms.RadioButton();
            this.Radio2P = new System.Windows.Forms.RadioButton();
            this.RadioAI = new System.Windows.Forms.RadioButton();
            this.CheckFirstMove = new System.Windows.Forms.CheckBox();
            this.LabelSettings = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.FieldSizes = new System.Windows.Forms.ComboBox();
            this.LabelField = new System.Windows.Forms.Label();
            this.FieldHeight = new System.Windows.Forms.TextBox();
            this.FieldWidth = new System.Windows.Forms.TextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Panel();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.Field = new System.Windows.Forms.Panel();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.LabelAlgo = new System.Windows.Forms.Label();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Radio1P
            // 
            this.Radio1P.AutoSize = true;
            this.Radio1P.Checked = true;
            this.Radio1P.Location = new System.Drawing.Point(14, 29);
            this.Radio1P.Name = "Radio1P";
            this.Radio1P.Size = new System.Drawing.Size(65, 17);
            this.Radio1P.TabIndex = 0;
            this.Radio1P.TabStop = true;
            this.Radio1P.Text = "1 Игрок";
            this.Radio1P.UseVisualStyleBackColor = true;
            this.Radio1P.CheckedChanged += new System.EventHandler(this.Select1P);
            // 
            // Radio2P
            // 
            this.Radio2P.AutoSize = true;
            this.Radio2P.Location = new System.Drawing.Point(14, 53);
            this.Radio2P.Name = "Radio2P";
            this.Radio2P.Size = new System.Drawing.Size(71, 17);
            this.Radio2P.TabIndex = 1;
            this.Radio2P.Text = "2 Игрока";
            this.Radio2P.UseVisualStyleBackColor = true;
            // 
            // RadioAI
            // 
            this.RadioAI.AutoSize = true;
            this.RadioAI.Enabled = false;
            this.RadioAI.Location = new System.Drawing.Point(14, 77);
            this.RadioAI.Name = "RadioAI";
            this.RadioAI.Size = new System.Drawing.Size(122, 17);
            this.RadioAI.TabIndex = 2;
            this.RadioAI.Text = "Только компьютер";
            this.RadioAI.UseVisualStyleBackColor = true;
            // 
            // CheckFirstMove
            // 
            this.CheckFirstMove.AutoSize = true;
            this.CheckFirstMove.Location = new System.Drawing.Point(14, 101);
            this.CheckFirstMove.Name = "CheckFirstMove";
            this.CheckFirstMove.Size = new System.Drawing.Size(105, 17);
            this.CheckFirstMove.TabIndex = 3;
            this.CheckFirstMove.Text = "Ходить первым";
            this.CheckFirstMove.UseVisualStyleBackColor = true;
            // 
            // LabelSettings
            // 
            this.LabelSettings.AutoSize = true;
            this.LabelSettings.Location = new System.Drawing.Point(32, 10);
            this.LabelSettings.Name = "LabelSettings";
            this.LabelSettings.Size = new System.Drawing.Size(90, 13);
            this.LabelSettings.TabIndex = 4;
            this.LabelSettings.Text = "Настройки игры";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 362);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(593, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "MAY THE BATTLE BEGIN";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ClickStart);
            // 
            // FieldSizes
            // 
            this.FieldSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FieldSizes.FormattingEnabled = true;
            this.FieldSizes.Items.AddRange(new object[] {
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "Свое"});
            this.FieldSizes.Location = new System.Drawing.Point(14, 154);
            this.FieldSizes.Name = "FieldSizes";
            this.FieldSizes.Size = new System.Drawing.Size(121, 21);
            this.FieldSizes.TabIndex = 6;
            this.FieldSizes.SelectedIndexChanged += new System.EventHandler(this.SelectField);
            // 
            // LabelField
            // 
            this.LabelField.AutoSize = true;
            this.LabelField.Location = new System.Drawing.Point(14, 138);
            this.LabelField.Name = "LabelField";
            this.LabelField.Size = new System.Drawing.Size(77, 13);
            this.LabelField.TabIndex = 7;
            this.LabelField.Text = "Игровое поле";
            // 
            // FieldHeight
            // 
            this.FieldHeight.Enabled = false;
            this.FieldHeight.Location = new System.Drawing.Point(90, 181);
            this.FieldHeight.Name = "FieldHeight";
            this.FieldHeight.Size = new System.Drawing.Size(45, 20);
            this.FieldHeight.TabIndex = 8;
            // 
            // FieldWidth
            // 
            this.FieldWidth.Enabled = false;
            this.FieldWidth.Location = new System.Drawing.Point(14, 181);
            this.FieldWidth.Name = "FieldWidth";
            this.FieldWidth.Size = new System.Drawing.Size(48, 20);
            this.FieldWidth.TabIndex = 9;
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(68, 184);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(14, 13);
            this.LabelX.TabIndex = 10;
            this.LabelX.Text = "X";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settings.Controls.Add(this.Algorithm);
            this.Settings.Controls.Add(this.LabelAlgo);
            this.Settings.Controls.Add(this.Difficulty);
            this.Settings.Controls.Add(this.LabelDifficulty);
            this.Settings.Controls.Add(this.LabelSettings);
            this.Settings.Controls.Add(this.LabelX);
            this.Settings.Controls.Add(this.Radio1P);
            this.Settings.Controls.Add(this.FieldWidth);
            this.Settings.Controls.Add(this.Radio2P);
            this.Settings.Controls.Add(this.FieldHeight);
            this.Settings.Controls.Add(this.RadioAI);
            this.Settings.Controls.Add(this.LabelField);
            this.Settings.Controls.Add(this.CheckFirstMove);
            this.Settings.Controls.Add(this.FieldSizes);
            this.Settings.Location = new System.Drawing.Point(12, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(157, 344);
            this.Settings.TabIndex = 11;
            // 
            // Difficulty
            // 
            this.Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Сложный"});
            this.Difficulty.Location = new System.Drawing.Point(14, 241);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(121, 21);
            this.Difficulty.TabIndex = 12;
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(14, 225);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(129, 13);
            this.LabelDifficulty.TabIndex = 11;
            this.LabelDifficulty.Text = "Сложность компьютера";
            // 
            // Field
            // 
            this.Field.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Field.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Field.Location = new System.Drawing.Point(176, 12);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(429, 344);
            this.Field.TabIndex = 12;
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Items.AddRange(new object[] {
            "Случайный",
            "МиниМакс",
            "Альфа-Бета"});
            this.Algorithm.Location = new System.Drawing.Point(14, 297);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(121, 21);
            this.Algorithm.TabIndex = 14;
            // 
            // LabelAlgo
            // 
            this.LabelAlgo.AutoSize = true;
            this.LabelAlgo.Location = new System.Drawing.Point(14, 281);
            this.LabelAlgo.Name = "LabelAlgo";
            this.LabelAlgo.Size = new System.Drawing.Size(56, 13);
            this.LabelAlgo.TabIndex = 13;
            this.LabelAlgo.Text = "Алгоритм";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 389);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.ButtonStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Connect4";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Radio1P;
        private System.Windows.Forms.RadioButton Radio2P;
        private System.Windows.Forms.CheckBox CheckFirstMove;
        private System.Windows.Forms.Label LabelSettings;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ComboBox FieldSizes;
        private System.Windows.Forms.Label LabelField;
        private System.Windows.Forms.TextBox FieldHeight;
        private System.Windows.Forms.TextBox FieldWidth;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.RadioButton RadioAI;
        private System.Windows.Forms.ComboBox Difficulty;
        private System.Windows.Forms.Label LabelDifficulty;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Label LabelAlgo;
    }
}

