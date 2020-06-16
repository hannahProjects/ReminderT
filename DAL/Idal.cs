using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;



namespace DAL
{
   public  interface Idal
    {
        void AddTask(Task task);
        void RemoveTask(Task task);
        void UpdateTask(Task task);
        void AddList(ListOfTasks list);
        void RemoveList(ListOfTasks list);
        void UpdateList(ListOfTasks list);
       void GetLists(List<ListOfTasks> l);
        List<Task> GetTasks();
        List<Task> searchByDate(DateTime date);
        List<Task> searchByName(string name);

    }
}
