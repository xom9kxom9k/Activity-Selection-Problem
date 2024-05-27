using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormMain : Form
    {
        private Visualizator? visualizator;
        private Storage? _storage;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            visualizator = new Visualizator();
        }

        private void Draw()
        {
            if (visualizator == null || _storage == null || _storage.GetCurrentState() == null)
            {
                return;
            }

            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            visualizator.Draw(gr, _storage.GetCurrentState(), pictureBox.Size);
            pictureBox.Image = bmp;
        }

        /// <summary>
        /// Запуск выполнения задачм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormInput formInput = new FormInput();
            formInput.parameterDelegate += AddData;
            formInput.Show();
        }

        private void AddData(Parameter paramter)
        {
            if (visualizator == null)
            {
                return;
            }

            _storage = new Manager(paramter).StartAlgo();
            MessageBox.Show("Задача запущена");
            Draw();
        }

        /// <summary>
        /// Запуск информации 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInformation_Click(object sender, EventArgs e)
        {
            FormInformation formInformation = new FormInformation();
            formInformation.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                MessageBox.Show("Задача не запущена");
                return;
            }

            if (_storage.IsCompleted)
            {
                MessageBox.Show("Задача завершена\nОтвет: " + _storage.GetCurrentState().Result + " заявок(ки).");
                return;
            }

            if (_storage.NextState())
            {
                Draw();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                MessageBox.Show("Задача не запущена");
                return;
            }

            if (_storage.CurrentStateIndex == 0)
            {
                MessageBox.Show("Назад нельзя");
                return;
            }

            if (_storage.PrevState())
            {
                Draw();
            }
        }
        /// <summary>
        /// Обработка сохранения 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(_storage.SaveState(saveFileDialog.FileName)
                    ? $"Список состояний успешно сохранён в {saveFileDialog.FileName}"
                    : $"Ошибка при сохранении файла {saveFileDialog.FileName}");
            }
            if (_storage == null)
            {
                MessageBox.Show("Сначала нужно ввести дааные о заявках");
                return;
            }
        }
        /// <summary>
        /// Обработка загрузки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _storage ??= new Storage();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (_storage.LoadState(filePath))
                {
                    UpdateVizualization();
                    MessageBox.Show("Файл загружен успешно");
                }
                else
                {
                    MessageBox.Show("Неверный формат файла или файл поврежден");
                }
            }
        }
        private void UpdateVizualization()
        {
            

            Draw();
        }
    }
}