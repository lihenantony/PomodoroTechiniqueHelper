using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroTechniqueHelper
{
    public enum TaskStatus
    {
        COMPLETED,
        SKIPPED,
        ABANDONED,
        INQUEUE,
        ONGOING,
    }

    public enum TaskType
    {
        NORMAL,
        UNPLANNED,
        TASKPOOL,
        INTERRUPTION,
    }

    public enum TaskPriority
    {
        HIGHEST=5,
        VERYHIGH=4,
        HIGH=3,
        NORMAL=2,
        LOW = 1,
        LOWEST = 0,
    }

    public enum TomatoType
    {
        COMPLETE,
        INCOMPLETE,
        INNERBREAK,
        OUTTERBREAK,
        
    }

    public class Task
    {
        public string name, isImportant, isHard;
        public int estimateToamto, completeTomato, incompleteTomato, innerBreak, outterBreak,
            completeness, difficulties, satisfaction, efficiency, improvement, achivement, focusness;
        public TaskStatus taskStatus;
        public TaskType taskType;
        public TaskPriority taskPriority;
        public DateTime reminder;
        public List<TomatoType> tomatoSequence = new List<TomatoType>();

        public static const DateTime DEFAULT_DATETIME_REMINDER = new DateTime(1997, 11, 10);

        public Task(string name, bool isimportant, bool ishard, int estimatetomato, 
            TaskType  tasktype, TaskPriority taskpri,
            TaskStatus taskstatus = TaskStatus.INQUEUE, DateTime? reminder = null)
        {
            this.name = name;
            this.isImportant = isimportant ? "important" : "not important";
            this.isHard = ishard ? "hard" : "easy";
            this.estimateToamto = estimatetomato;

            this.completeTomato = 0;
            this.incompleteTomato = 0;
            this.innerBreak = 0;
            this.outterBreak = 0;
            this.completeness = 0;
            this.difficulties = 0;
            this.satisfaction = 0;
            this.efficiency = 0;
            this.improvement = 0;
            this.achivement = 0;
            this.focusness = 0;

            this.taskStatus = taskstatus;
            this.taskType = tasktype;
            this.taskPriority = taskpri;

            
        }

        public void createTaskComplete(int compl, int diff, int satis, int effi, int impro, int achi, int focus)
        {
            this.taskStatus = TaskStatus.COMPLETED;
            this.completeness = compl;
            this.difficulties = diff;
            this.satisfaction = satis;
            this.efficiency = effi;
            this.improvement = impro;
            this.achivement = achi;
            this.focusness = focus;
        }

        public override bool Equals(object obj)
        {
            return this.name== ((Task)obj).name;
        }

    }

    
}
