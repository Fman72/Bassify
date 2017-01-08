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
    public partial class TabViewingForm : Form
    {
        public TabViewingForm()
        {
            InitializeComponent();
        }


        //displays tab in the uneditable text field in the clean guitar text box in the tab viewing form.
        public void addTabToCleanGuitarForm(string tabToDisplay){
            cleanGuitarTabTextBox.Text += tabToDisplay;
        }

        public void addTabToBassForm(string tabToDisplay)
        {
            bassTabTextBox.Text += tabToDisplay;
        }


    }
}
