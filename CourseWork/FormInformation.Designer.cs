namespace CourseWork
{
    partial class FormInformation
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
            labelInfo = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.Location = new Point(88, 82);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(601, 25);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Визуализация задачи о выборе заявок используя жадный алгоритм";
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(318, 159);
            buttonOk.Margin = new Padding(4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(166, 95);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 267);
            Controls.Add(buttonOk);
            Controls.Add(labelInfo);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormInformation";
            Text = "FormInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Button buttonOk;
    }
}