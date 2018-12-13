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
            this.tipsButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.grindGroupBox = new System.Windows.Forms.GroupBox();
            this.amountOfGrindsLabel = new System.Windows.Forms.Label();
            this.plusGrindButton = new System.Windows.Forms.Button();
            this.minusGrindButton = new System.Windows.Forms.Button();
            this.playsButton = new System.Windows.Forms.Button();
            this.grindTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.grindGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipsButton
            // 
            this.tipsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsButton.Location = new System.Drawing.Point(12, 12);
            this.tipsButton.Name = "tipsButton";
            this.tipsButton.Size = new System.Drawing.Size(129, 54);
            this.tipsButton.TabIndex = 0;
            this.tipsButton.Text = "Tips";
            this.tipsButton.UseVisualStyleBackColor = true;
            // 
            // rulesButton
            // 
            this.rulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesButton.Location = new System.Drawing.Point(654, 12);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(134, 54);
            this.rulesButton.TabIndex = 1;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // grindGroupBox
            // 
            this.grindGroupBox.Controls.Add(this.grindTextBox);
            this.grindGroupBox.Controls.Add(this.minusGrindButton);
            this.grindGroupBox.Controls.Add(this.plusGrindButton);
            this.grindGroupBox.Controls.Add(this.amountOfGrindsLabel);
            this.grindGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindGroupBox.Location = new System.Drawing.Point(12, 181);
            this.grindGroupBox.Name = "grindGroupBox";
            this.grindGroupBox.Size = new System.Drawing.Size(196, 257);
            this.grindGroupBox.TabIndex = 2;
            this.grindGroupBox.TabStop = false;
            this.grindGroupBox.Text = "schijven";
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
            // plusGrindButton
            // 
            this.plusGrindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusGrindButton.Location = new System.Drawing.Point(6, 26);
            this.plusGrindButton.Name = "plusGrindButton";
            this.plusGrindButton.Size = new System.Drawing.Size(52, 50);
            this.plusGrindButton.TabIndex = 3;
            this.plusGrindButton.Text = "+1";
            this.plusGrindButton.UseVisualStyleBackColor = true;
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
            // 
            // playsButton
            // 
            this.playsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playsButton.Location = new System.Drawing.Point(654, 387);
            this.playsButton.Name = "playsButton";
            this.playsButton.Size = new System.Drawing.Size(134, 51);
            this.playsButton.TabIndex = 3;
            this.playsButton.Text = "aantal zetten";
            this.playsButton.UseVisualStyleBackColor = true;
            this.playsButton.Click += new System.EventHandler(this.playsButton_Click);
            // 
            // grindTextBox
            // 
            this.grindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindTextBox.Location = new System.Drawing.Point(86, 64);
            this.grindTextBox.Name = "grindTextBox";
            this.grindTextBox.Size = new System.Drawing.Size(61, 61);
            this.grindTextBox.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(41, 132);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(133, 36);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00:00";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(359, 377);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(93, 32);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.playsButton);
            this.Controls.Add(this.grindGroupBox);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.tipsButton);
            this.Name = "MainForm";
            this.Text = "Torens van Hanoi zettenberekening";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grindGroupBox.ResumeLayout(false);
            this.grindGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tipsButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.GroupBox grindGroupBox;
        private System.Windows.Forms.Button minusGrindButton;
        private System.Windows.Forms.Button plusGrindButton;
        private System.Windows.Forms.Label amountOfGrindsLabel;
        private System.Windows.Forms.Button playsButton;
        private System.Windows.Forms.TextBox grindTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

