using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IDE_X2S
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        /****** BUTTONS ******/

            //For opening an existing project or inported project
        private void BTN_openProj_Click(object sender, EventArgs e)
        {

        }
            
            //For generating a new project.
        private void BTN_newProj_Click(object sender, EventArgs e)
        {

        }


        /****** TEXT WINDOWS ******/

            //Where the user will write the X2S code and scripts
        private void codeWIndow_TextChanged(object sender, EventArgs e)
        {

        }

            //Where debugging text and errors are shown
        private void consoleWindow_TextChanged(object sender, EventArgs e)
        {

        }
        /****** BROWSERS ******/

        //For browsing throught the files of the current project
        private void fileBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        
    }
}
