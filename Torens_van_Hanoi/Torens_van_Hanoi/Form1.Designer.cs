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
            this.grindGroupBox = new System.Windows.Forms.GroupBox();
            this.grindTextBox = new System.Windows.Forms.TextBox();
            this.minusGrindButton = new System.Windows.Forms.Button();
            this.plusGrindButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.amountOfGrindsLabel = new System.Windows.Forms.Label();
            this.playsButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.powerGroupBox = new System.Windows.Forms.GroupBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grindPowerTextBox = new System.Windows.Forms.TextBox();
            this.minusPowerGrindButton = new System.Windows.Forms.Button();
            this.plusPowerGrindButton = new System.Windows.Forms.Button();
            this.recursionGroupBox = new System.Windows.Forms.GroupBox();
            this.recursionResultLabel = new System.Windows.Forms.Label();
            this.recursionButton = new System.Windows.Forms.Button();
            this.grindRecursionTextBox = new System.Windows.Forms.TextBox();
            this.minusRecursionGrindButton = new System.Windows.Forms.Button();
            this.plusRecursionGrindButton = new System.Windows.Forms.Button();
            this.grindGroupBox.SuspendLayout();
            this.powerGroupBox.SuspendLayout();
            this.recursionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grindGroupBox
            // 
            this.grindGroupBox.Controls.Add(this.grindTextBox);
            this.grindGroupBox.Controls.Add(this.minusGrindButton);
            this.grindGroupBox.Controls.Add(this.plusGrindButton);
            this.grindGroupBox.Controls.Add(this.resultLabel);
            this.grindGroupBox.Controls.Add(this.amountOfGrindsLabel);
            this.grindGroupBox.Controls.Add(this.playsButton);
            this.grindGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindGroupBox.Location = new System.Drawing.Point(12, 181);
            this.grindGroupBox.Name = "grindGroupBox";
            this.grindGroupBox.Size = new System.Drawing.Size(483, 257);
            this.grindGroupBox.TabIndex = 2;
            this.grindGroupBox.TabStop = false;
            this.grindGroupBox.Text = "For loop";
            // 
            // grindTextBox
            // 
            this.grindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindTextBox.Location = new System.Drawing.Point(86, 64);
            this.grindTextBox.Name = "grindTextBox";
            this.grindTextBox.Size = new System.Drawing.Size(61, 61);
            this.grindTextBox.TabIndex = 5;
            // 
            // minusGrindButton
            // 
            this.minusGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusGrindButton.Location = new System.Drawing.Point(6, 113);
            this.minusGrindButton.Name = "minusGrindButton";
            this.minusGrindButton.Size = new System.Drawing.Size(52, 50);
            this.minusGrindButton.TabIndex = 4;
            this.minusGrindButton.Text = "-1";
            this.minusGrindButton.UseVisualStyleBackColor = true;
            this.minusGrindButton.Click += new System.EventHandler(this.minusGrindButton_Click);
            // 
            // plusGrindButton
            // 
            this.plusGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusGrindButton.Location = new System.Drawing.Point(6, 26);
            this.plusGrindButton.Name = "plusGrindButton";
            this.plusGrindButton.Size = new System.Drawing.Size(52, 50);
            this.plusGrindButton.TabIndex = 3;
            this.plusGrindButton.Text = "+1";
            this.plusGrindButton.UseVisualStyleBackColor = true;
            this.plusGrindButton.Click += new System.EventHandler(this.plusGrindButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(146, 207);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(31, 32);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0";
            // 
            // amountOfGrindsLabel
            // 
            this.amountOfGrindsLabel.AutoSize = true;
            this.amountOfGrindsLabel.Location = new System.Drawing.Point(70, 143);
            this.amountOfGrindsLabel.Name = "amountOfGrindsLabel";
            this.amountOfGrindsLabel.Size = new System.Drawing.Size(122, 20);
            this.amountOfGrindsLabel.TabIndex = 3;
            this.amountOfGrindsLabel.Text = "Aantal schijven";
            // 
            // playsButton
            // 
            this.playsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playsButton.Location = new System.Drawing.Point(6, 200);
            this.playsButton.Name = "playsButton";
            this.playsButton.Size = new System.Drawing.Size(134, 51);
            this.playsButton.TabIndex = 3;
            this.playsButton.Text = "aantal zetten";
            this.playsButton.UseVisualStyleBackColor = true;
            this.playsButton.Click += new System.EventHandler(this.playsButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(18, 142);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(95, 36);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "label1";
            // 
            // powerGroupBox
            // 
            this.powerGroupBox.Controls.Add(this.powerLabel);
            this.powerGroupBox.Controls.Add(this.button1);
            this.powerGroupBox.Controls.Add(this.grindPowerTextBox);
            this.powerGroupBox.Controls.Add(this.minusPowerGrindButton);
            this.powerGroupBox.Controls.Add(this.plusPowerGrindButton);
            this.powerGroupBox.Location = new System.Drawing.Point(501, 181);
            this.powerGroupBox.Name = "powerGroupBox";
            this.powerGroupBox.Size = new System.Drawing.Size(566, 257);
            this.powerGroupBox.TabIndex = 6;
            this.powerGroupBox.TabStop = false;
            this.powerGroupBox.Text = "Machtsverheffende";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.Location = new System.Drawing.Point(163, 207);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(31, 32);
            this.powerLabel.TabIndex = 8;
            this.powerLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "aantal zetten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grindPowerTextBox
            // 
            this.grindPowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindPowerTextBox.Location = new System.Drawing.Point(63, 64);
            this.grindPowerTextBox.Name = "grindPowerTextBox";
            this.grindPowerTextBox.Size = new System.Drawing.Size(61, 61);
            this.grindPowerTextBox.TabIndex = 6;
            // 
            // minusPowerGrindButton
            // 
            this.minusPowerGrindButton.AutoSize = true;
            this.minusPowerGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPowerGrindButton.Location = new System.Drawing.Point(6, 113);
            this.minusPowerGrindButton.Name = "minusPowerGrindButton";
            this.minusPowerGrindButton.Size = new System.Drawing.Size(51, 50);
            this.minusPowerGrindButton.TabIndex = 1;
            this.minusPowerGrindButton.Text = "-1";
            this.minusPowerGrindButton.UseVisualStyleBackColor = true;
            this.minusPowerGrindButton.Click += new System.EventHandler(this.minusPowerGrindButton_Click);
            // 
            // plusPowerGrindButton
            // 
            this.plusPowerGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusPowerGrindButton.Location = new System.Drawing.Point(6, 26);
            this.plusPowerGrindButton.Name = "plusPowerGrindButton";
            this.plusPowerGrindButton.Size = new System.Drawing.Size(51, 50);
            this.plusPowerGrindButton.TabIndex = 0;
            this.plusPowerGrindButton.Text = "+1";
            this.plusPowerGrindButton.UseVisualStyleBackColor = true;
            this.plusPowerGrindButton.Click += new System.EventHandler(this.plusPowerGrindButton_Click);
            // 
            // recursionGroupBox
            // 
            this.recursionGroupBox.Controls.Add(this.recursionResultLabel);
            this.recursionGroupBox.Controls.Add(this.recursionButton);
            this.recursionGroupBox.Controls.Add(this.grindRecursionTextBox);
            this.recursionGroupBox.Controls.Add(this.minusRecursionGrindButton);
            this.recursionGroupBox.Controls.Add(this.plusRecursionGrindButton);
            this.recursionGroupBox.Location = new System.Drawing.Point(1073, 181);
            this.recursionGroupBox.Name = "recursionGroupBox";
            this.recursionGroupBox.Size = new System.Drawing.Size(578, 257);
            this.recursionGroupBox.TabIndex = 7;
            this.recursionGroupBox.TabStop = false;
            this.recursionGroupBox.Text = "Recursie";
            // 
            // recursionResultLabel
            // 
            this.recursionResultLabel.AutoSize = true;
            this.recursionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursionResultLabel.Location = new System.Drawing.Point(163, 207);
            this.recursionResultLabel.Name = "recursionResultLabel";
            this.recursionResultLabel.Size = new System.Drawing.Size(31, 32);
            this.recursionResultLabel.TabIndex = 9;
            this.recursionResultLabel.Text = "0";
            // 
            // recursionButton
            // 
            this.recursionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursionButton.Location = new System.Drawing.Point(6, 200);
            this.recursionButton.Name = "recursionButton";
            this.recursionButton.Size = new System.Drawing.Size(134, 51);
            this.recursionButton.TabIndex = 9;
            this.recursionButton.Text = "aantal zetten";
            this.recursionButton.UseVisualStyleBackColor = true;
            this.recursionButton.Click += new System.EventHandler(this.recursionButton_Click);
            // 
            // grindRecursionTextBox
            // 
            this.grindRecursionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindRecursionTextBox.Location = new System.Drawing.Point(64, 64);
            this.grindRecursionTextBox.Name = "grindRecursionTextBox";
            this.grindRecursionTextBox.Size = new System.Drawing.Size(61, 61);
            this.grindRecursionTextBox.TabIndex = 7;
            this.grindRecursionTextBox.TextChanged += new System.EventHandler(this.grindRecursionTextBox_TextChanged);
            // 
            // minusRecursionGrindButton
            // 
            this.minusRecursionGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRecursionGrindButton.Location = new System.Drawing.Point(6, 113);
            this.minusRecursionGrindButton.Name = "minusRecursionGrindButton";
            this.minusRecursionGrindButton.Size = new System.Drawing.Size(52, 50);
            this.minusRecursionGrindButton.TabIndex = 6;
            this.minusRecursionGrindButton.Text = "-1";
            this.minusRecursionGrindButton.UseVisualStyleBackColor = true;
            // 
            // plusRecursionGrindButton
            // 
            this.plusRecursionGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRecursionGrindButton.Location = new System.Drawing.Point(6, 26);
            this.plusRecursionGrindButton.Name = "plusRecursionGrindButton";
            this.plusRecursionGrindButton.Size = new System.Drawing.Size(52, 50);
            this.plusRecursionGrindButton.TabIndex = 7;
            this.plusRecursionGrindButton.Text = "+1";
            this.plusRecursionGrindButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 465);
            this.Controls.Add(this.recursionGroupBox);
            this.Controls.Add(this.powerGroupBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.grindGroupBox);
            this.Name = "MainForm";
            this.Text = "Torens van Hanoi zettenberekening";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grindGroupBox.ResumeLayout(false);
            this.grindGroupBox.PerformLayout();
            this.powerGroupBox.ResumeLayout(false);
            this.powerGroupBox.PerformLayout();
            this.recursionGroupBox.ResumeLayout(false);
            this.recursionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grindGroupBox;
        private System.Windows.Forms.Button minusGrindButton;
        private System.Windows.Forms.Button plusGrindButton;
        private System.Windows.Forms.Label amountOfGrindsLabel;
        private System.Windows.Forms.Button playsButton;
        private System.Windows.Forms.TextBox grindTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox powerGroupBox;
        private System.Windows.Forms.Button minusPowerGrindButton;
        private System.Windows.Forms.Button plusPowerGrindButton;
        private System.Windows.Forms.GroupBox recursionGroupBox;
        private System.Windows.Forms.TextBox grindPowerTextBox;
        private System.Windows.Forms.TextBox grindRecursionTextBox;
        private System.Windows.Forms.Button minusRecursionGrindButton;
        private System.Windows.Forms.Button plusRecursionGrindButton;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label recursionResultLabel;
        private System.Windows.Forms.Button recursionButton;
    }
}

