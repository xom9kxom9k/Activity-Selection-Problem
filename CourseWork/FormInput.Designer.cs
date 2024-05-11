namespace CourseWork
{
    partial class FormInput
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
            numericUpDown = new NumericUpDown();
            labelTime = new Label();
            buttonAdd = new Button();
            labelStartBid = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(177, 27);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 23);
            numericUpDown.TabIndex = 0;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(192, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(81, 15);
            labelTime.TabIndex = 1;
            labelTime.Text = "Длина заявки";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(427, 9);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 43);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelStartBid
            // 
            labelStartBid.AutoSize = true;
            labelStartBid.Location = new Point(45, 9);
            labelStartBid.Name = "labelStartBid";
            labelStartBid.Size = new Size(88, 15);
            labelStartBid.TabIndex = 3;
            labelStartBid.Text = "Начало заявки";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(34, 27);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(311, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 43);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 62);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDown1);
            Controls.Add(labelStartBid);
            Controls.Add(buttonAdd);
            Controls.Add(labelTime);
            Controls.Add(numericUpDown);
            Name = "FormInput";
            Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown;
        private Label labelTime;
        private Button buttonAdd;
        private Label labelStartBid;
        private NumericUpDown numericUpDown1;
        private Button buttonCancel;
    }
}