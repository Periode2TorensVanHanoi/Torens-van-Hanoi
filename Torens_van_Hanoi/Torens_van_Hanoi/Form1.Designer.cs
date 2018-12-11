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
            this.grindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // 
            // grindGroupBox
            // 
            this.grindGroupBox.Controls.Add(this.button2);
            this.grindGroupBox.Controls.Add(this.button1);
            this.grindGroupBox.Controls.Add(this.label1);
            this.grindGroupBox.Controls.Add(this.grindTextBox);
            this.grindGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grindGroupBox.Location = new System.Drawing.Point(12, 163);
            this.grindGroupBox.Name = "grindGroupBox";
            this.grindGroupBox.Size = new System.Drawing.Size(198, 275);
            this.grindGroupBox.TabIndex = 2;
            this.grindGroupBox.TabStop = false;
            this.grindGroupBox.Text = "schijven";
            // 
            // grindTextBox
            // 
            this.grindTextBox.Location = new System.Drawing.Point(79, 53);
            this.grindTextBox.Multiline = true;
            this.grindTextBox.Name = "grindTextBox";
            this.grindTextBox.Size = new System.Drawing.Size(88, 75);
            this.grindTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal schijven";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "-1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(654, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "aantal zetten";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grindGroupBox);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.tipsButton);
            this.Name = "MainForm";
            this.Text = "Torens van Hanoi zettenberekening";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grindGroupBox.ResumeLayout(false);
            this.grindGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tipsButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.GroupBox grindGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grindTextBox;
        private System.Windows.Forms.Button button3;
    }
}

