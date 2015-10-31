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
    public partial class frmStudySession : Form
    {

        public StudySession studysession;
        int tiring, happiness;
        List<Task> tasks;
        int remainingTime = 25 * 60;
        int tomatoinroll = 1;

        public frmStudySession()
        {
            InitializeComponent();
        }

        private void frmStudySession_Load(object sender, EventArgs e)
        {
            frmGrading grade = new frmGrading(GradeType.BEFORE_STUDYSESSION);
            grade.ShowDialog();

            tiring = grade.trackTiringBeforeStudySession.Value;
            happiness = grade.trackHappinessBeforeStudySession.Value;

            frmTaskList frmtasklist = new frmTaskList(AddTaskType.NORMAL);
            frmtasklist.ShowDialog();
            tasks = frmtasklist.tasks;
        }

        public static string getTimeFormat(int secs)
        {
            int totalsec = secs;

            string one = "" + totalsec % 10;
            string ten = "" + totalsec % 60 / 10;

            totalsec /= 60;

            string onemin = "" + totalsec % 10;
            string tenmin = "" + totalsec % 60 / 10;


            return tenmin + onemin + ":" + ten + one;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            refreshStat();
        }


        private void frmStudySession_Shown(object sender, EventArgs e)
        {
            
            studysession = new StudySession(DateTime.Now, tiring, happiness);
            foreach(Task task in tasks)
            {
                studysession.addNewTask(task);
            }
            MessageBox.Show("click OK to start study session");
            timer.Enabled = true;
        }

        public void refreshLabel()
        {
            lblAbandonedTask.Text = "" + studysession.abandonedTask;
            lblCompleteTask.Text = "" + studysession.completeTask;
            lblCompleteTomato.Text = "" + studysession.completeTomato;
            lblCurrentStatus.Text = "" + studysession.sessionstatus;
            lblCurrentTaskName.Text = "" + studysession.tasks[studysession.currTaskIndex].name;
            lblInQueueTask.Text = "" + studysession.inQueueTask;
            lblInterruption.Text = "" + studysession.interruption;
            lblSkippedTask.Text = "" + studysession.skippedTask;
            lblUnplannedTaskAdded.Text = "" + studysession.unplannedTaskAdded;
            lblNextTask.Text = "" + studysession.tasks[studysession.getNextTaskIndex()].name;
            lblIncompleteTomato.Text = "" + studysession.incompleteTomato;
        }

        public void refreshStat()
        {
            remainingTime--;

            if (remainingTime <= 0)
            {
                studysession.switchStatus();
                if (studysession.sessionstatus == StudySessionStatus.LEARNING)
                {
                    remainingTime = 25 * 60;
                    tomatoinroll++;
                }
                else
                {
                    if (MessageBox.Show("Did you finish the current task?","asking",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        studysession.createTaskFinished();
                    }
                    if (tomatoinroll >= 4)
                    {
                        remainingTime = 20 * 60;
                        tomatoinroll = 0;
                    }
                    else
                    {
                        remainingTime = 5 * 60;
                    }
                    
                }
            }

            refreshLabel();
        }


    }
}
