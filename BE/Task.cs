using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;


namespace BE
{
    public enum priority { LOW, MEDIUM, HIGH };
    public enum type1 { family, work, studies };
    [Table("Task")]
    public class Task
    {
        static int currentId = 0;
        [Key]
        public int TaskId { set; get; }
        [Display(Name = "ListOfTasks ID")]
        public int ListOfTasksId { set; get; }
      // [InverseProperty("TaskId")]
       // [ForeignKey("ListOfTasksId")]
        public string NameTask { set; get; }
        public string LocationTask { set; get; }
        public DateTime DateTask { set; get; }
        public DateTime WhenToRemember { set; get; }
        public priority PriorityTask { set; get; }
        public type1 TypeTask { set; get; }
        public string DescriptionTask { set; get; }

        public virtual ListOfTasks ListOfTasks { set; get; }
        //public Task()
        //{
        //    TaskId = currentId;
        //    ListOfTasksId = -1;
        //    nameTask = "";
        //    locationTask = "";
        //    dateTask = new DateTime(0,0,0,0,0,0);
        //    priorityTask = priority.MEDIUM;
        //    descriptionTask = "";
        //    currentId++;
        //}
        //public Task(int _ListOfTasksId ,string _nameTask, string _locationTask, DateTime _dateTask,priority _priorityTask, string _descriptionTask)
        //{
        //    TaskId = currentId;
        //    ListOfTasksId = _ListOfTasksId;
        //    nameTask = _nameTask;
        //    locationTask = _locationTask;
        //    dateTask = _dateTask;
        //    priorityTask = _priorityTask;
        //    descriptionTask = _descriptionTask;
        //    currentId++;
        //}
        
    }
    
}
