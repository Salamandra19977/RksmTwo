namespace RksmTwo
{
    partial class Form1
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
            this.resultBtn = new System.Windows.Forms.Button();
            this.numberOneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTwoTextBox = new System.Windows.Forms.TextBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(264, 47);
            this.resultBtn.Margin = new System.Windows.Forms.Padding(6);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(477, 46);
            this.resultBtn.TabIndex = 0;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // numberOneTextBox
            // 
            this.numberOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOneTextBox.Location = new System.Drawing.Point(109, 6);
            this.numberOneTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.numberOneTextBox.Name = "numberOneTextBox";
            this.numberOneTextBox.Size = new System.Drawing.Size(246, 29);
            this.numberOneTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "число 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "оператор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "число 2:";
            // 
            // numberTwoTextBox
            // 
            this.numberTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwoTextBox.Location = new System.Drawing.Point(627, 6);
            this.numberTwoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.numberTwoTextBox.Name = "numberTwoTextBox";
            this.numberTwoTextBox.Size = new System.Drawing.Size(246, 29);
            this.numberTwoTextBox.TabIndex = 5;
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "/",
            "*"});
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.operatorComboBox.Location = new System.Drawing.Point(472, 8);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(61, 32);
            this.operatorComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 111);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberTwoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOneTextBox);
            this.Controls.Add(this.resultBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.TextBox numberOneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTwoTextBox;
        private System.Windows.Forms.ComboBox operatorComboBox;
    }
}

