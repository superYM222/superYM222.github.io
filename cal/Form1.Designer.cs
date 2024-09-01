namespace cal
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
            txtBox = new TextBox();
            tabCalculator = new TabControl();
            tabPage1 = new TabPage();
            btnCosine = new Button();
            btnPI = new Button();
            btnFactorial = new Button();
            btnSine = new Button();
            btnEqual = new Button();
            btnRoot = new Button();
            btnRecip = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnSub = new Button();
            btnPlus = new Button();
            btnClear = new Button();
            chkDarkMode = new CheckBox();
            btnPlusMinus = new Button();
            btnDot = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            rdbScientific = new RadioButton();
            rdbStandard = new RadioButton();
            btn9 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            tabCalculator.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.Info;
            txtBox.Font = new Font("Imprint MT Shadow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtBox.Location = new Point(19, 27);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(620, 77);
            txtBox.TabIndex = 0;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // tabCalculator
            // 
            tabCalculator.Controls.Add(tabPage1);
            tabCalculator.Controls.Add(tabPage2);
            tabCalculator.Location = new Point(0, 3);
            tabCalculator.Name = "tabCalculator";
            tabCalculator.SelectedIndex = 0;
            tabCalculator.Size = new Size(669, 526);
            tabCalculator.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnCosine);
            tabPage1.Controls.Add(btnPI);
            tabPage1.Controls.Add(btnFactorial);
            tabPage1.Controls.Add(btnSine);
            tabPage1.Controls.Add(btnEqual);
            tabPage1.Controls.Add(btnRoot);
            tabPage1.Controls.Add(btnRecip);
            tabPage1.Controls.Add(btnDiv);
            tabPage1.Controls.Add(btnMulti);
            tabPage1.Controls.Add(btnSub);
            tabPage1.Controls.Add(btnPlus);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(chkDarkMode);
            tabPage1.Controls.Add(btnPlusMinus);
            tabPage1.Controls.Add(btnDot);
            tabPage1.Controls.Add(btn8);
            tabPage1.Controls.Add(btn3);
            tabPage1.Controls.Add(btn7);
            tabPage1.Controls.Add(btn0);
            tabPage1.Controls.Add(btn6);
            tabPage1.Controls.Add(btn5);
            tabPage1.Controls.Add(btn4);
            tabPage1.Controls.Add(rdbScientific);
            tabPage1.Controls.Add(rdbStandard);
            tabPage1.Controls.Add(btn9);
            tabPage1.Controls.Add(btn2);
            tabPage1.Controls.Add(btn1);
            tabPage1.Controls.Add(txtBox);
            tabPage1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(661, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculator";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnCosine
            // 
            btnCosine.BackColor = Color.LightGreen;
            btnCosine.FlatAppearance.BorderColor = Color.Gainsboro;
            btnCosine.FlatAppearance.BorderSize = 2;
            btnCosine.FlatStyle = FlatStyle.Flat;
            btnCosine.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCosine.Location = new Point(559, 236);
            btnCosine.Name = "btnCosine";
            btnCosine.Size = new Size(80, 80);
            btnCosine.TabIndex = 27;
            btnCosine.Text = "Cosine";
            btnCosine.UseVisualStyleBackColor = false;
            btnCosine.Click += btnCosine_Click;
            // 
            // btnPI
            // 
            btnPI.BackColor = Color.LightGreen;
            btnPI.FlatAppearance.BorderColor = Color.Gainsboro;
            btnPI.FlatAppearance.BorderSize = 2;
            btnPI.FlatStyle = FlatStyle.Flat;
            btnPI.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPI.Location = new Point(559, 322);
            btnPI.Name = "btnPI";
            btnPI.Size = new Size(80, 80);
            btnPI.TabIndex = 26;
            btnPI.Text = "π";
            btnPI.UseVisualStyleBackColor = false;
            btnPI.Click += btnPI_Click;
            // 
            // btnFactorial
            // 
            btnFactorial.BackColor = Color.LightGreen;
            btnFactorial.FlatAppearance.BorderColor = Color.Gainsboro;
            btnFactorial.FlatAppearance.BorderSize = 2;
            btnFactorial.FlatStyle = FlatStyle.Flat;
            btnFactorial.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnFactorial.Location = new Point(473, 322);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(80, 80);
            btnFactorial.TabIndex = 25;
            btnFactorial.Text = "X!";
            btnFactorial.UseVisualStyleBackColor = false;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // btnSine
            // 
            btnSine.BackColor = Color.LightGreen;
            btnSine.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSine.FlatAppearance.BorderSize = 2;
            btnSine.FlatStyle = FlatStyle.Flat;
            btnSine.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSine.Location = new Point(473, 236);
            btnSine.Name = "btnSine";
            btnSine.Size = new Size(80, 80);
            btnSine.TabIndex = 24;
            btnSine.Text = "Sine";
            btnSine.UseVisualStyleBackColor = false;
            btnSine.Click += btnSine_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LightSkyBlue;
            btnEqual.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnEqual.FlatAppearance.BorderSize = 2;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(473, 406);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(166, 78);
            btnEqual.TabIndex = 23;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.LightSkyBlue;
            btnRoot.FlatAppearance.BorderColor = Color.Gainsboro;
            btnRoot.FlatAppearance.BorderSize = 2;
            btnRoot.FlatStyle = FlatStyle.Flat;
            btnRoot.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRoot.Location = new Point(387, 406);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(80, 80);
            btnRoot.TabIndex = 22;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnRecip
            // 
            btnRecip.BackColor = Color.LightSkyBlue;
            btnRecip.FlatAppearance.BorderColor = Color.Gainsboro;
            btnRecip.FlatAppearance.BorderSize = 2;
            btnRecip.FlatStyle = FlatStyle.Flat;
            btnRecip.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRecip.Location = new Point(301, 406);
            btnRecip.Name = "btnRecip";
            btnRecip.Size = new Size(80, 80);
            btnRecip.TabIndex = 21;
            btnRecip.Text = "1/x";
            btnRecip.UseVisualStyleBackColor = false;
            btnRecip.Click += btnRecip_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.SandyBrown;
            btnDiv.FlatAppearance.BorderColor = Color.Gainsboro;
            btnDiv.FlatAppearance.BorderSize = 2;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDiv.Location = new Point(387, 322);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 80);
            btnDiv.TabIndex = 20;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.SandyBrown;
            btnMulti.FlatAppearance.BorderColor = Color.Gainsboro;
            btnMulti.FlatAppearance.BorderSize = 2;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMulti.Location = new Point(301, 322);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(80, 80);
            btnMulti.TabIndex = 19;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.SandyBrown;
            btnSub.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSub.FlatAppearance.BorderSize = 2;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSub.Location = new Point(387, 236);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 80);
            btnSub.TabIndex = 18;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.SandyBrown;
            btnPlus.FlatAppearance.BorderColor = Color.Gainsboro;
            btnPlus.FlatAppearance.BorderSize = 2;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPlus.Location = new Point(301, 236);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 80);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PowderBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(301, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(338, 80);
            btnClear.TabIndex = 16;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            chkDarkMode.Location = new Point(301, 111);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(123, 29);
            chkDarkMode.TabIndex = 15;
            chkDarkMode.Text = "&Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.LightCyan;
            btnPlusMinus.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnPlusMinus.FlatAppearance.BorderSize = 2;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlusMinus.Location = new Point(191, 408);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(80, 80);
            btnPlusMinus.TabIndex = 14;
            btnPlusMinus.Text = "+\r\n-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.LightCyan;
            btnDot.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnDot.FlatAppearance.BorderSize = 2;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(105, 408);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(80, 80);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightCyan;
            btn8.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn8.FlatAppearance.BorderSize = 2;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(105, 150);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightCyan;
            btn3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn3.FlatAppearance.BorderSize = 2;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(191, 322);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightCyan;
            btn7.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn7.FlatAppearance.BorderSize = 2;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(19, 150);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightCyan;
            btn0.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn0.FlatAppearance.BorderSize = 2;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(19, 408);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 80);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightCyan;
            btn6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn6.FlatAppearance.BorderSize = 2;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(191, 236);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightCyan;
            btn5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn5.FlatAppearance.BorderSize = 2;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(105, 236);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightCyan;
            btn4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn4.FlatAppearance.BorderSize = 2;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(19, 236);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // rdbScientific
            // 
            rdbScientific.AutoSize = true;
            rdbScientific.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbScientific.Location = new Point(169, 109);
            rdbScientific.Name = "rdbScientific";
            rdbScientific.Size = new Size(102, 29);
            rdbScientific.TabIndex = 5;
            rdbScientific.TabStop = true;
            rdbScientific.Text = "Scie&ntific";
            rdbScientific.UseVisualStyleBackColor = true;
            rdbScientific.CheckedChanged += rdbScientific_CheckedChanged;
            // 
            // rdbStandard
            // 
            rdbStandard.AutoSize = true;
            rdbStandard.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbStandard.Location = new Point(29, 110);
            rdbStandard.Name = "rdbStandard";
            rdbStandard.Size = new Size(104, 29);
            rdbStandard.TabIndex = 4;
            rdbStandard.TabStop = true;
            rdbStandard.Text = "&Standard";
            rdbStandard.UseVisualStyleBackColor = true;
            rdbStandard.CheckedChanged += rdbStandard_CheckedChanged;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightCyan;
            btn9.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn9.FlatAppearance.BorderSize = 2;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(191, 150);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightCyan;
            btn2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn2.FlatAppearance.BorderSize = 2;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(105, 322);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightCyan;
            btn1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn1.FlatAppearance.BorderSize = 2;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(19, 322);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(661, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About me";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 528);
            Controls.Add(tabCalculator);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            tabCalculator.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBox;
        private TabControl tabCalculator;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn1;
        private RadioButton rdbStandard;
        private Button btn9;
        private Button btn2;
        private Button btn8;
        private Button btn3;
        private Button btn7;
        private Button btn0;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private RadioButton rdbScientific;
        private Button btnPlusMinus;
        private Button btnDot;
        private Button btnPlus;
        private Button btnClear;
        private CheckBox chkDarkMode;
        private Button btnRoot;
        private Button btnRecip;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnSub;
        private Button btnEqual;
        private Button btnCosine;
        private Button btnPI;
        private Button btnFactorial;
        private Button btnSine;
        private PictureBox pictureBox1;
    }
}