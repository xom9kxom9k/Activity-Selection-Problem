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
            MessageBox.Show("Задача запущена");
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
    }
}