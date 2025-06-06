namespace Calculator
{
    partial class Base
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button comaButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.Button leftBracketButton;
        private System.Windows.Forms.Button rightBracketButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.comaButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.leftBracketButton = new System.Windows.Forms.Button();
            this.rightBracketButton = new System.Windows.Forms.Button();

            // textTextBox
            this.textTextBox.Location = new System.Drawing.Point(10, 12);
            this.textTextBox.Enabled = false; 
            this.textTextBox.Name = "number1TextBox";
            this.textTextBox.Size = new System.Drawing.Size(140, 90);
            this.textTextBox.Text = "0";
            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(210, 40);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(40, 40);
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // cleanButton
            this.cleanButton.Location = new System.Drawing.Point(210, 10);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(40, 30);
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            //backspadeButton
            this.backspaceButton = new System.Windows.Forms.Button();
            this.backspaceButton.Location = new System.Drawing.Point(160, 10);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(40, 30);
            this.backspaceButton.Text = "<-";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += (sender, e) =>
            {
                if (textTextBox.Text.Length > 0 && textTextBox.Text != "0")
                {
                    textTextBox.Text = textTextBox.Text.Substring(0, textTextBox.Text.Length - 1);
                    if (textTextBox.Text.Length == 0)
                    {
                        textTextBox.Text = "0";
                    }
                }
            };
            // oneButton
            this.oneButton = new System.Windows.Forms.Button();
            this.oneButton.Location = new System.Drawing.Point(10, 40);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(40, 40);
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += (sender, e) => AddTextToTextBox("1");
            // twoButton
            this.twoButton = new System.Windows.Forms.Button();
            this.twoButton.Location = new System.Drawing.Point(60, 40);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(40, 40);
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += (sender, e) => AddTextToTextBox("2");
            // threeButton
            this.threeButton = new System.Windows.Forms.Button();
            this.threeButton.Location = new System.Drawing.Point(110, 40);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(40, 40);
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += (sender, e) => AddTextToTextBox("3");
            // fourButton
            this.fourButton = new System.Windows.Forms.Button();
            this.fourButton.Location = new System.Drawing.Point(10, 90);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(40, 40);
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += (sender, e) => AddTextToTextBox("4");
            // fiveButton
            this.fiveButton = new System.Windows.Forms.Button();
            this.fiveButton.Location = new System.Drawing.Point(60, 90);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(40, 40);
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += (sender, e) => AddTextToTextBox("5");
            // sixButton
            this.sixButton = new System.Windows.Forms.Button();
            this.sixButton.Location = new System.Drawing.Point(110, 90);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(40, 40);
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += (sender, e) => AddTextToTextBox("6");
            // sevenButton
            this.sevenButton = new System.Windows.Forms.Button();
            this.sevenButton.Location = new System.Drawing.Point(10, 140);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(40, 40);
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += (sender, e) => AddTextToTextBox("7");
            // eightButton
            this.eightButton = new System.Windows.Forms.Button();
            this.eightButton.Location = new System.Drawing.Point(60, 140);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(40, 40);
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += (sender, e) => AddTextToTextBox("8");
            // nineButton
            this.nineButton = new System.Windows.Forms.Button();
            this.nineButton.Location = new System.Drawing.Point(110, 140);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(40, 40);
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += (sender, e) => AddTextToTextBox("9");
            // zeroButton
            this.zeroButton = new System.Windows.Forms.Button();
            this.zeroButton.Location = new System.Drawing.Point(60, 190);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(40, 40);
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += (sender, e) => AddTextToTextBox("0");
            // comaButton
            this.comaButton = new System.Windows.Forms.Button();
            this.comaButton.Location = new System.Drawing.Point(110, 190);
            this.comaButton.Name = "comaButton";
            this.comaButton.Size = new System.Drawing.Size(40, 40);
            this.comaButton.Text = ",";
            this.comaButton.UseVisualStyleBackColor = true;
            this.comaButton.Click += (sender, e) => AddTextToTextBox(",");
            // plusButton
            this.plusButton = new System.Windows.Forms.Button();
            this.plusButton.Location = new System.Drawing.Point(160, 40);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(40, 40);
            this.plusButton.Text = " + ";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += (sender, e) => AddTextToTextBox("+");
            // minusButton
            this.minusButton = new System.Windows.Forms.Button();
            this.minusButton.Location = new System.Drawing.Point(160, 90);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(40, 40);
            this.minusButton.Text = " - ";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += (sender, e) => AddTextToTextBox("-");
            // multiplyButton
            this.multiplyButton = new System.Windows.Forms.Button();
            this.multiplyButton.Location = new System.Drawing.Point(160, 140);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(40, 40);
            this.multiplyButton.Text = " * ";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += (sender, e) => AddTextToTextBox("*");
            // divideButton
            this.divideButton = new System.Windows.Forms.Button();
            this.divideButton.Location = new System.Drawing.Point(160, 190);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(40, 40);
            this.divideButton.Text = " / ";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += (sender, e) => AddTextToTextBox("/");
            // sqrtButton
            this.sqrtButton = new System.Windows.Forms.Button();
            this.sqrtButton.Location = new System.Drawing.Point(210, 90);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(40, 40);
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += (sender, e) => AddTextToTextBox("√");
            // powerButton
            this.powerButton = new System.Windows.Forms.Button();
            this.powerButton.Location = new System.Drawing.Point(210, 140);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(40, 40);
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += (sender, e) => AddTextToTextBox("^");
            // piButton
            this.piButton = new System.Windows.Forms.Button();
            this.piButton.Location = new System.Drawing.Point(210, 190);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(40, 40);
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = true;
            this.piButton.Click += (sender, e) => AddTextToTextBox("π");
            // leftBracketButton
            this.leftBracketButton = new System.Windows.Forms.Button();
            this.leftBracketButton.Location = new System.Drawing.Point(10, 190);
            this.leftBracketButton.Name = "leftBracketButton";
            this.leftBracketButton.Size = new System.Drawing.Size(20, 40);
            this.leftBracketButton.Text = "(";
            this.leftBracketButton.UseVisualStyleBackColor = true;
            this.leftBracketButton.Click += (sender, e) => AddTextToTextBox("(");
            // rightBracketButton
            this.rightBracketButton = new System.Windows.Forms.Button();
            this.rightBracketButton.Location = new System.Drawing.Point(30, 190);
            this.rightBracketButton.Name = "rightBracketButton";
            this.rightBracketButton.Size = new System.Drawing.Size(20, 40);
            this.rightBracketButton.Text = ")";
            this.rightBracketButton.UseVisualStyleBackColor = true;
            this.rightBracketButton.Click += (sender, e) => AddTextToTextBox(")");


            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.comaButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.piButton);
            this.Controls.Add(this.leftBracketButton);
            this.Controls.Add(this.rightBracketButton);

            // Base
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 240);
            this.Text = "Form1";
        }

        #endregion
    }
}
