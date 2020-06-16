using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Input;
using ToDoList.viewModels;

namespace ToDoList.commands
{
    class saveTheTask : ICommand
    {
        static int num = 20;
        private AddTaskVM CurrentMV;
        public saveTheTask(AddTaskVM CurrentMV)
        {
            this.CurrentMV = CurrentMV;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            var result = false;
            if (parameter != null && parameter.ToString() != "")
            {
                result = true;
            }
            return result;
        }

        public void Execute(object parameter)
        {
            CurrentMV.TaskId = num;
            CurrentMV.CurrentModel.Save();
        }
    }
}
