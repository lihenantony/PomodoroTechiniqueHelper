using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTechniqueHelper
{
    public enum AddTaskType
    {
        NORMAL,
        UNPLANNED,
    }

    public partial class frmTaskList : Form
    {

        public List<Task> tasks = new List<Task>();


        public frmTaskList(AddTaskType type)
        {
            InitializeComponent();
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {

        }

        public void refreshTaskList()
        {

        }

        public void refreshTaskPool()
        {
 
        }
    }
}
