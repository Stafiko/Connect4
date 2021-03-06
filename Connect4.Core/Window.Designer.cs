﻿namespace Connect4.Core
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
            this.LabelField = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Panel();
            this.WinCount = new System.Windows.Forms.NumericUpDown();
            this.LabelWin = new System.Windows.Forms.Label();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.LabelAlgo = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.Field = new System.Windows.Forms.Panel();
            this.LabelX = new System.Windows.Forms.Label();
            this.FieldWidth = new System.Windows.Forms.NumericUpDown();
            this.FieldHeight = new System.Windows.Forms.NumericUpDown();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldHeight)).BeginInit();
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
            this.Radio1P.CheckedChanged += new System.EventHandler(this.Selected1P);
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
            this.ButtonStart.Location = new System.Drawing.Point(12, 364);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(593, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "MAY THE BATTLE BEGIN";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ClickedStart);
            // 
            // LabelField
            // 
            this.LabelField.AutoSize = true;
            this.LabelField.Location = new System.Drawing.Point(14, 127);
            this.LabelField.Name = "LabelField";
            this.LabelField.Size = new System.Drawing.Size(77, 13);
            this.LabelField.TabIndex = 7;
            this.LabelField.Text = "Игровое поле";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settings.Controls.Add(this.FieldHeight);
            this.Settings.Controls.Add(this.FieldWidth);
            this.Settings.Controls.Add(this.WinCount);
            this.Settings.Controls.Add(this.LabelWin);
            this.Settings.Controls.Add(this.Algorithm);
            this.Settings.Controls.Add(this.LabelAlgo);
            this.Settings.Controls.Add(this.Difficulty);
            this.Settings.Controls.Add(this.LabelDifficulty);
            this.Settings.Controls.Add(this.LabelSettings);
            this.Settings.Controls.Add(this.LabelX);
            this.Settings.Controls.Add(this.Radio1P);
            this.Settings.Controls.Add(this.Radio2P);
            this.Settings.Controls.Add(this.RadioAI);
            this.Settings.Controls.Add(this.LabelField);
            this.Settings.Controls.Add(this.CheckFirstMove);
            this.Settings.Location = new System.Drawing.Point(12, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(157, 346);
            this.Settings.TabIndex = 11;
            // 
            // WinCount
            // 
            this.WinCount.Location = new System.Drawing.Point(16, 195);
            this.WinCount.Name = "WinCount";
            this.WinCount.Size = new System.Drawing.Size(128, 20);
            this.WinCount.TabIndex = 18;
            this.WinCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // LabelWin
            // 
            this.LabelWin.AutoSize = true;
            this.LabelWin.Location = new System.Drawing.Point(14, 179);
            this.LabelWin.Name = "LabelWin";
            this.LabelWin.Size = new System.Drawing.Size(100, 13);
            this.LabelWin.TabIndex = 16;
            this.LabelWin.Text = "Фишек до победы";
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Items.AddRange(new object[] {
            "Случайный",
            "МиниМакс",
            "Альфа-Бета"});
            this.Algorithm.Location = new System.Drawing.Point(17, 302);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(127, 21);
            this.Algorithm.TabIndex = 14;
            // 
            // LabelAlgo
            // 
            this.LabelAlgo.AutoSize = true;
            this.LabelAlgo.Location = new System.Drawing.Point(14, 286);
            this.LabelAlgo.Name = "LabelAlgo";
            this.LabelAlgo.Size = new System.Drawing.Size(56, 13);
            this.LabelAlgo.TabIndex = 13;
            this.LabelAlgo.Text = "Алгоритм";
            // 
            // Difficulty
            // 
            this.Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Сложный"});
            this.Difficulty.Location = new System.Drawing.Point(16, 249);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(128, 21);
            this.Difficulty.TabIndex = 12;
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(15, 233);
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
            this.Field.Size = new System.Drawing.Size(429, 346);
            this.Field.TabIndex = 12;
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(71, 145);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(14, 13);
            this.LabelX.TabIndex = 10;
            this.LabelX.Text = "X";
            // 
            // FieldWidth
            // 
            this.FieldWidth.Location = new System.Drawing.Point(16, 143);
            this.FieldWidth.Name = "FieldWidth";
            this.FieldWidth.Size = new System.Drawing.Size(54, 20);
            this.FieldWidth.TabIndex = 19;
            this.FieldWidth.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // FieldHeight
            // 
            this.FieldHeight.Location = new System.Drawing.Point(88, 143);
            this.FieldHeight.Name = "FieldHeight";
            this.FieldHeight.Size = new System.Drawing.Size(56, 20);
            this.FieldHeight.TabIndex = 20;
            this.FieldHeight.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.ButtonStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Гравитрипс";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Radio1P;
        private System.Windows.Forms.RadioButton Radio2P;
        private System.Windows.Forms.CheckBox CheckFirstMove;
        private System.Windows.Forms.Label LabelSettings;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelField;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.RadioButton RadioAI;
        private System.Windows.Forms.ComboBox Difficulty;
        private System.Windows.Forms.Label LabelDifficulty;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Label LabelAlgo;
        private System.Windows.Forms.Label LabelWin;
        private System.Windows.Forms.NumericUpDown WinCount;
        private System.Windows.Forms.NumericUpDown FieldHeight;
        private System.Windows.Forms.NumericUpDown FieldWidth;
        private System.Windows.Forms.Label LabelX;
    }
}

