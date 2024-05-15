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
            labelStartBid = new Label();
            numericUpDown1 = new NumericUpDown();
            listView1 = new ListView();
            buttonStart = new Button();
            buttonCansel = new Button();
            buttonAdd = new Button();
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
            labelTime.Size = new Size(80, 15);
            labelTime.TabIndex = 1;
            labelTime.Text = "Конец заявки";
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
            // listView1
            // 
            listView1.Location = new Point(34, 66);
            listView1.Name = "listView1";
            listView1.Size = new Size(263, 386);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Left;
            buttonStart.Location = new Point(316, 189);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(120, 43);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCansel
            // 
            buttonCansel.Anchor = AnchorStyles.Left;
            buttonCansel.Location = new Point(316, 127);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(120, 43);
            buttonCansel.TabIndex = 5;
            buttonCansel.Text = "Отмена";
            buttonCansel.UseVisualStyleBackColor = true;
            buttonCansel.Click += buttonCansel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Left;
            buttonAdd.Location = new Point(316, 66);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 43);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 462);
            Controls.Add(listView1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCansel);
            Controls.Add(numericUpDown1);
            Controls.Add(labelStartBid);
            Controls.Add(buttonStart);
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
        private Label labelStartBid;
        private NumericUpDown numericUpDown1;
        private ListView listView1;
        private Button buttonStart;
        private Button buttonCansel;
        private Button buttonAdd;
    }
}