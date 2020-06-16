using BL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ToDoList.viewModels
{
    class ViewModel
    {
        private BL_Imp bl;

        public ViewModel()
        {
            bl = BLFactory.getBL();
        }
        public void setFlag()
        {
            bl.flag = false;
        }
        public ViewModel(Action<object, EventArgs> d)
        {
            bl = BLFactory.getBL(d);
        }

        public void getAll(List<ListOfTasks> l)
        {
            bl.GetLists(l);
        }

        public void addList(ListOfTasks l)
        {
            bl.AddList(l);
        }

        public void updateList(ListOfTasks l)
        {
            bl.UpdateList(l);
        }

        //public void deleteList(ListOfTasks l)
        //{
        //    bl.RemoveList(l);
        //}

        public void addTask(BE.Task m)
        {
            bl.AddTask(m);
        }

        public void deleteTask(Task m)
        {
            bl.RemoveTask(m);
        }

        public void updateTask(Task m)
        {
            bl.UpdateTask(m);
        }

        public List<Task> searchByName(string sub)
        {
            return bl.searchByName(sub);
        }

        //public List<Task> searchByDate(DateTime date, int listID)
        //{
        //    return bl.searchByDate(date, listID);
        //}

        public List<Task> searchByDate(DateTime date)
        {
            return bl.searchByDate(date);
        }

        internal void setFlag(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
