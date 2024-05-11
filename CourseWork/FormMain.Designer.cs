namespace CourseWork
{
    partial class FormMain
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
            pictureBox = new PictureBox();
            buttonStart = new Button();
            buttonStep = new Button();
            buttonInformation = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(800, 401);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(681, 407);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(107, 34);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Запустить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(551, 407);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(107, 34);
            buttonStep.TabIndex = 2;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            // 
            // buttonInformation
            // 
            buttonInformation.Location = new Point(12, 407);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(107, 34);
            buttonInformation.TabIndex = 3;
            buttonInformation.Text = "Информация";
            buttonInformation.UseVisualStyleBackColor = true;
            buttonInformation.Click += buttonInformation_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInformation);
            Controls.Add(buttonStep);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox);
            Name = "FormMain";
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonStart;
        private Button buttonStep;
        private Button buttonInformation;
    }
}