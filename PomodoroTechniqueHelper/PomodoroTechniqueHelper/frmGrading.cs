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
    public enum GradeType
    {
        BEFORE_STUDYSESSION,
        AFTER_STUDYSESSION,
        FINISH_TASK
    }

    public partial class frmGrading : Form
    {
        public frmGrading(GradeType type)
        {
            InitializeComponent();
        }

        private void frmGrading_Load(object sender, EventArgs e)
        {

        }
    }
}
