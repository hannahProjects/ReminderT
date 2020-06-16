using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace ToDoList.models
{
    public class TaskModel
    {
        BL_Imp bl;
        public Task CurrentTask { get; private set; }
        public TaskModel(Task CurrentTask)
        {
            bl = BLFactory.getBL();
            this.CurrentTask = CurrentTask; // fake
        }

        public void Save()
        {
            bl.AddTask(CurrentTask);
        }
        public void Update()
        {
            bl.UpdateTask(CurrentTask);
        }
        public void Delete()
        {
            bl.RemoveTask(CurrentTask);
        }
    }
}
