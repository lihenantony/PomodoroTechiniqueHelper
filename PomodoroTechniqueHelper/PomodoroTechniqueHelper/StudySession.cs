using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroTechniqueHelper
{
    public enum StudySessionStatus
    {
        LEARNING,
        RESTING,
    }

    public class StudySession
    {
        public DateTime startTime, endTime;
        public int completeTomato, incompleteTomato, unplannedTaskAdded, interruption,
            completeTask, inQueueTask, abandonedTask, skippedTask,
            tiringBeforeStudySession, happinessBeforeStudySession,
            tiringAfterStudySession, happinessAfterStudySession, loudness, disturbing;

        public StudySessionStatus sessionstatus;
        
        public List<Task> tasks = new List<Task>();

        public int currTaskIndex = 0;

        public StudySession(DateTime startime, int tiringbefore, int happinessbefore)
        {
            this.startTime = startime;
            this.tiringBeforeStudySession = tiringbefore;
            this.happinessBeforeStudySession = happinessbefore;
            this.sessionstatus = StudySessionStatus.LEARNING;
        }

        public void addNewTask(Task task)
        {
            if (task.taskType == TaskType.INTERRUPTION)
                interruption++;
            else if (task.taskType == TaskType.UNPLANNED)
                unplannedTaskAdded++;

            switch (task.taskStatus)
            {
                case TaskStatus.ABANDONED:
                    abandonedTask++;break;
                case TaskStatus.COMPLETED:
                    completeTask++;break;
                case TaskStatus.INQUEUE:
                    inQueueTask++;break;
                case TaskStatus.SKIPPED:
                    skippedTask++;break;
            }

            int index = getTaskAddIndex(task);
            tasks.Insert(index, task);
        }

        private int getTaskAddIndex(Task task)
        {
            for (int i=0;i<tasks.Count;++i)
            {
                if (tasks[i].taskStatus != TaskStatus.INQUEUE)
                {
                    continue;
                }
                if ((int)tasks[i].taskPriority>(int)task.taskPriority)
                {
                    continue;
                }
                return i;
            }
            return tasks.Count;
        }

        public void createTaskFinished()
        {
            //call frm grade
            frmGrading frmgrading = new frmGrading(GradeType.FINISH_TASK);
            frmgrading.ShowDialog();

            tasks[currTaskIndex].createTaskComplete(frmgrading.trackCompleteness.Value,
                frmgrading.trackDifficulties.Value, frmgrading.trackSatisfaction.Value,
                frmgrading.trackEfficiency.Value, frmgrading.trackImprovement.Value,
                frmgrading.trackAchivement.Value, frmgrading.trackFocuness.Value);

            currTaskIndex = getNextTaskIndex();
            tasks[currTaskIndex].taskStatus = TaskStatus.ONGOING;
        }

        public void createTaskSkipped(int i)
        {
            skippedTask++;
            tasks[i].taskStatus = TaskStatus.SKIPPED;
            addTomato(TomatoType.INNERBREAK);
        }

        

        public int getNextTaskIndex()
        {
            int dex = currTaskIndex;
            do
            {
                dex++;
            } while (tasks[dex].taskStatus != TaskStatus.INQUEUE);
            return dex;
        }

        public void addTomato(TomatoType type)
        {
            tasks[currTaskIndex].tomatoSequence.Add(type);
        }

        public void switchStatus()
        {

        }

    }
}
