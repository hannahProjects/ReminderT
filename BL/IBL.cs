using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {
        void AddTask(Task task);
      void RemoveTask(Task task);
        void UpdateTask(Task task);
        void AddList(ListOfTasks list);
       // void RemoveList(ListOfTasks list);
        void UpdateList(ListOfTasks list);
       void GetLists(List<ListOfTasks> l);
        List<Task> GetTasks();
        List<Task> searchByDate(DateTime date);
        List<Task> searchByName(string name);
        Task searchListByName(string name);
        Task searchTaskById(int id);
        //ListOfTasks searchListById(int id);

    }
}
