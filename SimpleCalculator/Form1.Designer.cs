namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOne = new Button();
            btnZero = new Button();
            btnComma = new Button();
            btnEquals = new Button();
            btnPlusMinus = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnPlus = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnMinus = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiply = new Button();
            btnPercent = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnEraseOne = new Button();
            btnDivision = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(48, 363);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(65, 45);
            btnOne.TabIndex = 0;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnNumbers_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(119, 414);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(65, 45);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnNumbers_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnComma.Location = new Point(190, 414);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(65, 45);
            btnComma.TabIndex = 2;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(48, 465);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(278, 45);
            btnEquals.TabIndex = 3;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.Control;
            btnPlusMinus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusMinus.Location = new Point(48, 414);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(65, 45);
            btnPlusMinus.TabIndex = 4;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnWarning_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(119, 363);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(65, 45);
            btnTwo.TabIndex = 5;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnNumbers_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(190, 363);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(65, 45);
            btnThree.TabIndex = 6;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnNumbers_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(261, 414);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(65, 45);
            btnPlus.TabIndex = 7;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperator_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(48, 312);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(65, 45);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnNumbers_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(119, 312);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(65, 45);
            btnFive.TabIndex = 9;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnNumbers_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(190, 312);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(65, 45);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnNumbers_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(261, 363);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 45);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(48, 261);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(65, 45);
            btnSeven.TabIndex = 12;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnNumbers_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(119, 261);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(65, 45);
            btnEight.TabIndex = 13;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnNumbers_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(190, 261);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(65, 45);
            btnNine.TabIndex = 14;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNumbers_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.Location = new Point(261, 312);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(65, 45);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.Control;
            btnPercent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPercent.Location = new Point(48, 210);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(65, 45);
            btnPercent.TabIndex = 16;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnWarning_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.Control;
            btnCE.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.Location = new Point(119, 210);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(65, 45);
            btnCE.TabIndex = 17;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnWarning_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.Location = new Point(190, 210);
            btnC.Name = "btnC";
            btnC.Size = new Size(65, 45);
            btnC.TabIndex = 18;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnEraseOne
            // 
            btnEraseOne.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEraseOne.Location = new Point(261, 210);
            btnEraseOne.Name = "btnEraseOne";
            btnEraseOne.Size = new Size(65, 45);
            btnEraseOne.TabIndex = 19;
            btnEraseOne.Text = "<-";
            btnEraseOne.UseVisualStyleBackColor = true;
            btnEraseOne.Click += btnEraseOne_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.Location = new Point(261, 261);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(65, 45);
            btnDivision.TabIndex = 20;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnOperator_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(48, 51);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(278, 95);
            txtResult.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(376, 556);
            Controls.Add(txtResult);
            Controls.Add(btnDivision);
            Controls.Add(btnEraseOne);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnPercent);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnMinus);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnPlus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnEquals);
            Controls.Add(btnComma);
            Controls.Add(btnZero);
            Controls.Add(btnOne);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOne;
        private Button btnZero;
        private Button btnComma;
        private Button btnEquals;
        private Button btnPlusMinus;
        private Button btnTwo;
        private Button btnThree;
        private Button btnPlus;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnMinus;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnPercent;
        private Button btnCE;
        private Button btnC;
        private Button btnEraseOne;
        private Button btnDivision;
        private TextBox txtResult;
    }
}