namespace Torens_van_Hanoi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.amoutButton = new System.Windows.Forms.Button();
            this.grindPowerTextBox = new System.Windows.Forms.TextBox();
            this.minusPowerGrindButton = new System.Windows.Forms.Button();
            this.plusPowerGrindButton = new System.Windows.Forms.Button();
            this.buttonRecursie = new System.Windows.Forms.Button();
            this.forLoopButton = new System.Windows.Forms.Button();
            this.labelJaren = new System.Windows.Forms.Label();
            this.labelEeuwen = new System.Windows.Forms.Label();
            this.labelMaanden = new System.Windows.Forms.Label();
            this.labelWeken = new System.Windows.Forms.Label();
            this.labelDagen = new System.Windows.Forms.Label();
            this.labelUren = new System.Windows.Forms.Label();
            this.labelMinuten = new System.Windows.Forms.Label();
            this.labelSeconden = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDecenia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(357, 170);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 36);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(16, 213);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLabel.Size = new System.Drawing.Size(330, 32);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Aantal te zetten stappen:";
            // 
            // amoutButton
            // 
            this.amoutButton.Location = new System.Drawing.Point(393, 84);
            this.amoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amoutButton.Name = "amoutButton";
            this.amoutButton.Size = new System.Drawing.Size(167, 50);
            this.amoutButton.TabIndex = 7;
            this.amoutButton.Text = "machtsverheffende";
            this.amoutButton.UseVisualStyleBackColor = true;
            this.amoutButton.Click += new System.EventHandler(this.amoutButton_Click);
            // 
            // grindPowerTextBox
            // 
            this.grindPowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindPowerTextBox.Location = new System.Drawing.Point(285, 28);
            this.grindPowerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grindPowerTextBox.Name = "grindPowerTextBox";
            this.grindPowerTextBox.Size = new System.Drawing.Size(380, 32);
            this.grindPowerTextBox.TabIndex = 6;
            this.grindPowerTextBox.Text = "Vul het aantal schijven in...";
            this.grindPowerTextBox.TextChanged += new System.EventHandler(this.grindPowerTextBox_TextChanged);
            // 
            // minusPowerGrindButton
            // 
            this.minusPowerGrindButton.AutoSize = true;
            this.minusPowerGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPowerGrindButton.Location = new System.Drawing.Point(688, 15);
            this.minusPowerGrindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minusPowerGrindButton.Name = "minusPowerGrindButton";
            this.minusPowerGrindButton.Size = new System.Drawing.Size(68, 62);
            this.minusPowerGrindButton.TabIndex = 1;
            this.minusPowerGrindButton.Text = "-1";
            this.minusPowerGrindButton.UseVisualStyleBackColor = true;
            this.minusPowerGrindButton.Click += new System.EventHandler(this.minusPowerGrindButton_Click);
            // 
            // plusPowerGrindButton
            // 
            this.plusPowerGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusPowerGrindButton.Location = new System.Drawing.Point(195, 15);
            this.plusPowerGrindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plusPowerGrindButton.Name = "plusPowerGrindButton";
            this.plusPowerGrindButton.Size = new System.Drawing.Size(68, 62);
            this.plusPowerGrindButton.TabIndex = 0;
            this.plusPowerGrindButton.Text = "+1";
            this.plusPowerGrindButton.UseVisualStyleBackColor = true;
            this.plusPowerGrindButton.Click += new System.EventHandler(this.plusPowerGrindButton_Click);
            // 
            // buttonRecursie
            // 
            this.buttonRecursie.Location = new System.Drawing.Point(568, 84);
            this.buttonRecursie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRecursie.Name = "buttonRecursie";
            this.buttonRecursie.Size = new System.Drawing.Size(99, 50);
            this.buttonRecursie.TabIndex = 8;
            this.buttonRecursie.Text = "Recursief";
            this.buttonRecursie.UseVisualStyleBackColor = true;
            this.buttonRecursie.Click += new System.EventHandler(this.buttonRecursie_Click);
            // 
            // forLoopButton
            // 
            this.forLoopButton.Location = new System.Drawing.Point(285, 84);
            this.forLoopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forLoopButton.Name = "forLoopButton";
            this.forLoopButton.Size = new System.Drawing.Size(92, 50);
            this.forLoopButton.TabIndex = 9;
            this.forLoopButton.Text = "For Loop";
            this.forLoopButton.UseVisualStyleBackColor = true;
            this.forLoopButton.Click += new System.EventHandler(this.forLoopButton_Click);
            // 
            // labelJaren
            // 
            this.labelJaren.AutoSize = true;
            this.labelJaren.Location = new System.Drawing.Point(8, 59);
            this.labelJaren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJaren.Name = "labelJaren";
            this.labelJaren.Size = new System.Drawing.Size(48, 17);
            this.labelJaren.TabIndex = 10;
            this.labelJaren.Text = "Jaren:";
            // 
            // labelEeuwen
            // 
            this.labelEeuwen.AutoSize = true;
            this.labelEeuwen.Location = new System.Drawing.Point(8, 26);
            this.labelEeuwen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEeuwen.Name = "labelEeuwen";
            this.labelEeuwen.Size = new System.Drawing.Size(62, 17);
            this.labelEeuwen.TabIndex = 11;
            this.labelEeuwen.Text = "Eeuwen:";
            // 
            // labelMaanden
            // 
            this.labelMaanden.AutoSize = true;
            this.labelMaanden.Location = new System.Drawing.Point(8, 75);
            this.labelMaanden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaanden.Name = "labelMaanden";
            this.labelMaanden.Size = new System.Drawing.Size(71, 17);
            this.labelMaanden.TabIndex = 12;
            this.labelMaanden.Text = "Maanden:";
            // 
            // labelWeken
            // 
            this.labelWeken.AutoSize = true;
            this.labelWeken.Location = new System.Drawing.Point(8, 91);
            this.labelWeken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeken.Name = "labelWeken";
            this.labelWeken.Size = new System.Drawing.Size(56, 17);
            this.labelWeken.TabIndex = 13;
            this.labelWeken.Text = "Weken:";
            // 
            // labelDagen
            // 
            this.labelDagen.AutoSize = true;
            this.labelDagen.Location = new System.Drawing.Point(8, 107);
            this.labelDagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDagen.Name = "labelDagen";
            this.labelDagen.Size = new System.Drawing.Size(54, 17);
            this.labelDagen.TabIndex = 14;
            this.labelDagen.Text = "Dagen:";
            // 
            // labelUren
            // 
            this.labelUren.AutoSize = true;
            this.labelUren.Location = new System.Drawing.Point(8, 123);
            this.labelUren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUren.Name = "labelUren";
            this.labelUren.Size = new System.Drawing.Size(43, 17);
            this.labelUren.TabIndex = 15;
            this.labelUren.Text = "Uren:";
            // 
            // labelMinuten
            // 
            this.labelMinuten.AutoSize = true;
            this.labelMinuten.Location = new System.Drawing.Point(8, 139);
            this.labelMinuten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinuten.Name = "labelMinuten";
            this.labelMinuten.Size = new System.Drawing.Size(62, 17);
            this.labelMinuten.TabIndex = 16;
            this.labelMinuten.Text = "Minuten:";
            // 
            // labelSeconden
            // 
            this.labelSeconden.AutoSize = true;
            this.labelSeconden.Location = new System.Drawing.Point(8, 155);
            this.labelSeconden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeconden.Name = "labelSeconden";
            this.labelSeconden.Size = new System.Drawing.Size(76, 17);
            this.labelSeconden.TabIndex = 17;
            this.labelSeconden.Text = "Seconden:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDecenia);
            this.groupBox1.Controls.Add(this.labelEeuwen);
            this.groupBox1.Controls.Add(this.labelSeconden);
            this.groupBox1.Controls.Add(this.labelJaren);
            this.groupBox1.Controls.Add(this.labelMinuten);
            this.groupBox1.Controls.Add(this.labelMaanden);
            this.groupBox1.Controls.Add(this.labelUren);
            this.groupBox1.Controls.Add(this.labelWeken);
            this.groupBox1.Controls.Add(this.labelDagen);
            this.groupBox1.Location = new System.Drawing.Point(764, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(245, 175);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benodigde Tijd";
            // 
            // labelDecenia
            // 
            this.labelDecenia.AutoSize = true;
            this.labelDecenia.Location = new System.Drawing.Point(8, 42);
            this.labelDecenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecenia.Name = "labelDecenia";
            this.labelDecenia.Size = new System.Drawing.Size(64, 17);
            this.labelDecenia.TabIndex = 18;
            this.labelDecenia.Text = "Decenia:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.forLoopButton);
            this.Controls.Add(this.buttonRecursie);
            this.Controls.Add(this.amoutButton);
            this.Controls.Add(this.minusPowerGrindButton);
            this.Controls.Add(this.grindPowerTextBox);
            this.Controls.Add(this.plusPowerGrindButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Torens van Hanoi zettenberekening";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button minusPowerGrindButton;
        private System.Windows.Forms.Button plusPowerGrindButton;
        private System.Windows.Forms.TextBox grindPowerTextBox;
        private System.Windows.Forms.Button amoutButton;
        private System.Windows.Forms.Button buttonRecursie;
        private System.Windows.Forms.Button forLoopButton;
        private System.Windows.Forms.Label labelJaren;
        private System.Windows.Forms.Label labelEeuwen;
        private System.Windows.Forms.Label labelMaanden;
        private System.Windows.Forms.Label labelWeken;
        private System.Windows.Forms.Label labelDagen;
        private System.Windows.Forms.Label labelUren;
        private System.Windows.Forms.Label labelMinuten;
        private System.Windows.Forms.Label labelSeconden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDecenia;
    }
}

