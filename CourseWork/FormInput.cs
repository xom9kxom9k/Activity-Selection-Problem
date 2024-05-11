using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormInput : Form
    {
        private Parameter? _parameter;
        public event Action<Parameter>? parameterDelegate;

        public FormInput()
        {
            InitializeComponent();

            buttonCancel.Click += (sender, e) => Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_parameter != null)
            {
                parameterDelegate?.Invoke(_parameter);
                Close();
            }
        }


    }
}
