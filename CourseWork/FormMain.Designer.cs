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
            buttonNext = new Button();
            buttonInformation = new Button();
            buttonPrev = new Button();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(800, 377);
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
            // buttonNext
            // 
            buttonNext.Location = new Point(551, 407);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(107, 34);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Вперед";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
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
            // buttonPrev
            // 
            buttonPrev.Location = new Point(438, 407);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(107, 34);
            buttonPrev.TabIndex = 4;
            buttonPrev.Text = "Назад";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(181, 22);
            SaveToolStripMenuItem.Text = "Сохранение";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            LoadToolStripMenuItem.Size = new Size(181, 22);
            LoadToolStripMenuItem.Text = "Загрузка";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "file txt | *.txt";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "file txt | *.txt";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPrev);
            Controls.Add(buttonInformation);
            Controls.Add(buttonNext);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonStart;
        private Button buttonNext;
        private Button buttonInformation;
        private Button buttonPrev;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}