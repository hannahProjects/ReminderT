using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using ToDoList.models;

namespace ToDoList.viewModels
{
    public class AddTaskVM : INotifyPropertyChanged
    {
        public TaskModel CurrentModel { get; set; }
        //  public saveTheMission Save { get; set; }
        public string  NameTask
        {
            get { return CurrentModel.CurrentTask.NameTask; }
            set
            {
                CurrentModel.CurrentTask.NameTask= value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("NameTask"));
            }

        }
        public priority PriorityTask
        {
            get { return CurrentModel.CurrentTask.PriorityTask; }
            set
            {
                CurrentModel.CurrentTask.PriorityTask = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PriorityTask"));
            }
        }
        public type1 TypeTask
        {
            get { return CurrentModel.CurrentTask.TypeTask; }
            set
            {
                 CurrentModel.CurrentTask.TypeTask = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("TypeTask"));
            }
        }
        public DateTime DateTask
        {
            get { return CurrentModel.CurrentTask.DateTask; }
            set
            {
                CurrentModel.CurrentTask.DateTask = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("DateTask"));
            }
        }
        public string DescriptionTask
        {
            get { return CurrentModel.CurrentTask.DescriptionTask; }
            set
            {
                CurrentModel.CurrentTask.DescriptionTask = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("DescriptionTask"));
            }
        }
        public DateTime WhenToRemember
        {
            get { return CurrentModel.CurrentTask.WhenToRemember; }
            set
            {
                CurrentModel.CurrentTask.WhenToRemember = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WhenToRemember"));
            }
        }
        public string LocationTask
        {
            get { return CurrentModel.CurrentTask.LocationTask; }
            set
            {
                CurrentModel.CurrentTask.LocationTask = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LocationTask"));
            }
        }
        public int TaskId
        {
            get { return CurrentModel.CurrentTask.TaskId; }
            set
            {
                CurrentModel.CurrentTask.TaskId = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("TaskId"));
            }
        }
        public int ListOfTasksId
        {
            get { return CurrentModel.CurrentTask.ListOfTasksId; }
            set
            {
                CurrentModel.CurrentTask.ListOfTasksId = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ListOfTasksId"));
            }
        }
        public AddTaskVM()
        {
            CurrentModel = new TaskModel(new BE.Task()); //fake
            //Save = new saveTheMission(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
