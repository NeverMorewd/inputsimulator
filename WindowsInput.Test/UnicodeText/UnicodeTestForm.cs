using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsInput.Tests.UnicodeText
{
    public partial class UnicodeTestForm : Form
    {
        public UnicodeTestForm()
        {
            InitializeComponent();
        }

        public string Expected
        {
            get { return ExpectedTextBox.Text; }
            set { ExpectedTextBox.Text = value; }
        }

        public string Recieved { get { return RecievedTextBox.Text; } }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RecievedTextBox.Focus();
        }
    }
}
