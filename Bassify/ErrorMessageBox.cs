using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bassify
{
    public partial class ErrorMessageBox : Form
    {
        //creates and exception box using details about the exception.
        public ErrorMessageBox(Exception exception)
        {
            InitializeComponent();
            this.exceptionMessageLabel.Text = "Message: " + exception.Message;
            this.exceptionStackTraceLabel.Text = "StackTrace: " + Environment.NewLine + exception.StackTrace;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
