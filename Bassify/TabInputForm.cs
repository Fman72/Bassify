using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bassify
{
    public partial class TabInputForm : Form
    {
        public TabInputForm()
        {
            InitializeComponent();
        }

        private string tabGatheringRegex = "\\-([\\-pbxhs\\/\\^\\(\\)\\d\\|]*)(\\-|\\d)";

        //code executed when the text in the input textbox changes to show what text will be captures as bass tab.
        private void tabInputTextBox_TextChanged(object sender, EventArgs e)
        {
            //taking user tab from textbox
            string usersTab = tabInputTextBox.Text;
            //extracting valid tab from data user entered
            Regex outsidePipeCharacterRegex = new Regex(tabGatheringRegex);
            //declaring List to hold lines of tab
            MatchCollection matches = outsidePipeCharacterRegex.Matches(usersTab);


            //creating string that will contain the colored tab
            string coloredUsersTab = usersTab;
            //going through matches and highlighting text that will be turned into tab.
            for (int i = 0; i < matches.Count; i++)
            {
                this.tabInputTextBox.SelectionStart = matches[i].Index;
                this.tabInputTextBox.SelectionLength = matches[i].Length;
                if (i % 2 == 0)
                {
                    this.tabInputTextBox.SelectionBackColor = Color.Pink;
                }
                else
                {
                    this.tabInputTextBox.SelectionBackColor = Color.Yellow;
                }
            }
        }

        //code executed when the 'Bassify Button' is clicked. Takes the text in the textbox and attempts to create bass tab using it.
        private void bassifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //taking user tab from textbox
                string usersTab = tabInputTextBox.Text;
                //extracting valid tab from data user entered
                Regex outsidePipeCharacterRegex = new Regex(tabGatheringRegex);
                //declaring List to hold lines of tab
                MatchCollection matches = outsidePipeCharacterRegex.Matches(usersTab);

                //distributing lines amoungst bar classes.
                //initializing array of bars
                List<Bar> bars = new List<Bar>();
                //adding bar to array of bars to hold first set of guitar lines.
                bars.Add(new Bar());
                //initialzing counter to track what guitar line the line of tba will be assigned to.
                int guitarLineCounter = 0;
                //initializing counter to track what bar to add the line to.
                int barCounter = 0;
                for (int i = 0; i < matches.Count; i++)
                {
                    //if this is the 7th line of guitar tab - increment the bar counter by one to start assigning the guitar lines to a new bar.
                    if (((i % 6) == 0) && (i != 0))
                    {
                        barCounter++;
                        bars.Add(new Bar());
                    }
                    //if this is the 7th line of guitar tab reset the guitarlineCounter to 0;
                    if ((i % 6) == 0)
                    {
                        guitarLineCounter = 0;
                        bars[barCounter].setGuitarLine(matches[i].ToString(), guitarLineCounter);
                        guitarLineCounter++;

                    }
                    else
                    {
                        bars[barCounter].setGuitarLine(matches[i].ToString(), guitarLineCounter);
                        guitarLineCounter++;
                    }
                    //adding tab to the lines List for clean guitar tab and debugging.
                };

                //Initializing tabViewingForm to show users tab in.
                TabViewingForm tabViewingForm = new TabViewingForm();


                //adding guitarLines to the guitar lines tab of the tab viewing form
                for (int i = 0; i < bars.Count; i++)
                {
                    if (i != 0)
                    {
                        tabViewingForm.addTabToCleanGuitarForm(Environment.NewLine);
                    }
                    for (int x = 0; x < 6; x++)
                    {
                        tabViewingForm.addTabToCleanGuitarForm(bars[i].getGuitarLine(x) + Environment.NewLine);
                    }
                }

                //adding bassLines to the bass lines tab of the tab viewing form.
                for (int i = 0; i < bars.Count; i++)
                {
                    bars[i].translateGuitarToBassTab();
                    if (i != 0)
                    {
                        tabViewingForm.addTabToBassForm(Environment.NewLine);
                    }
                    for (int x = 0; x < 4; x++)
                    {
                        tabViewingForm.addTabToBassForm(bars[i].getBassLine(x) + Environment.NewLine);
                    }
                }

                //showing tabViewingform
                tabViewingForm.Show();
            }
            catch(Exception exception){
                System.Diagnostics.Debug.WriteLine(exception.Message);
                System.Diagnostics.Debug.WriteLine("Application or Object that caused error: " + exception.Source);
                System.Diagnostics.Debug.WriteLine("StackTrace: " + exception.StackTrace);
                ErrorMessageBox errorMessageBox = new ErrorMessageBox(exception);
                errorMessageBox.Show();
            }
        }
    }
}
