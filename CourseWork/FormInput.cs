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
        private List<Node> _nodes;
        public event Action<Parameter>? parameterDelegate;

        public FormInput()
        {
            InitializeComponent();
            _nodes = new List<Node>();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Node node = new Node()
            {
                StartBid = Convert.ToInt32(numericUpDown1.Value), EndBid = Convert.ToInt32(numericUpDown.Value)
            };
            _nodes.Add(node);
            listView1.Items.Add(node.ToString());
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Parameter parameter = new Parameter(_nodes);
            parameterDelegate?.Invoke(parameter);
            Close();
            buttonAdd.Enabled = true;
        }
    }
}