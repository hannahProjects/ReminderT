using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;
using System.Threading;

namespace BL
{
    public class BL_Imp : IBL
    {
        Idal myDal;
        public bool flag;
        public event EventHandler reminder;
        public BL_Imp(Action<object, EventArgs> d)
        {
            myDal = DalFactory.getDal();
            flag = true;
            this.reminder += new EventHandler(d);
            Thread c = new Thread(memoMission);
            c.Start();
        }
        public void AddList(ListOfTasks list)
        {
            Task temp = searchListByName(list.CategoryList);
            if (temp == null)
                throw new Exception("BL :list with the same name already exists");
            myDal.AddList(list);
        }

        public void AddTask(Task task)
        {
            //if(task.DateTask< DateTime.Today)
            //    throw new Exception("BL :the date have passed already");
            myDal.AddTask(task);

        }

        public void GetLists(List<ListOfTasks> l)
        {
             myDal.GetLists(l);
        }

        public List<BE.Task> GetTasks()
        {
            return myDal.GetTasks();
        }

        //public void RemoveList(ListOfTasks list)
        //{
        //    if (searchListById(list.ListOfTasksId) == null)
        //        throw new Exception("BL :the list doesn't exist");
        //    foreach ( Task item in GetTasks())
        //    {
        //        if (item.ListOfTasksId == list.ListOfTasksId)
        //            RemoveTask(item);
        //    }
        //    myDal.RemoveList(list);
        //}

        public void RemoveTask(BE.Task task)
        {

            //if(searchTaskById(task.TaskId)==null)
            //    throw new Exception("BL :the task doesn't exist");
           myDal.RemoveTask(task);
        }

        public List<BE.Task> searchByDate(DateTime date)
        {
            List<Task> retList = new List<Task>();
            foreach(Task item in GetTasks())
            {
                if (item.DateTask == date)
                    retList.Add(item);
            }
            return retList;
        }

        public List<BE.Task> searchByName(string name)
        {
            List<Task> retList = new List<Task>();
            foreach (Task item in GetTasks())
            {
                if (item.NameTask == name)
                    retList.Add(item);
            }
            return retList;
        }

        public Task searchListByName(string sub)
        {
            List<ListOfTasks> list = new List<ListOfTasks>();
            myDal.GetLists(list);
            foreach (ListOfTasks item in list)
            {
                foreach (Task m in item.Tasks)
                    if (m.DescriptionTask.Contains(sub) || m.NameTask.Contains(sub))
                        return m;
            }
            throw new Exception("MISSION NOT FOUND!");
        }



        //public ListOfTasks searchListById(int id)
        //{
        //    foreach (ListOfTasks item in GetLists())
        //        if (item.ListOfTasksId == id)
        //            return item;
        //    return null;
        //}

        //public ListOfTasks searchListByName(string name)
        //{
        //    foreach (ListOfTasks item in GetLists())
        //        if (item.CategoryList == name)
        //            return item;
        //    return null;
        //}

        public Task searchTaskById(int id)
        {
            foreach (Task item in GetTasks())
            {
                if (item.TaskId == id)
                    return item;
            }
            return null;
        }

        public void UpdateList(ListOfTasks list)
        {
            if (searchTaskById(list.ListOfTasksId) == null)
                throw new Exception("BL :the list doesn't exist");
            myDal.UpdateList(list);
        }
        public void memoMission()
        {
            while (flag)
            {
                List<ListOfTasks> list = new List<ListOfTasks>();
                myDal.GetLists(list);
                DateTime d = DateTime.Now;
                int day = d.Month;
                foreach (ListOfTasks item in list)
                    foreach (Task m in item.Tasks)
                    {
                        int dd = m.DateTask.Month;
                        if (day == dd)
                            dd = 1;
                        if (m.DateTask.Day == d.Day && m.DateTask.Month == d.Month && m.DateTask.Year == d.Year)
                            if(m.WhenToRemember.Hour==d.Hour && m.WhenToRemember.Minute == d.Minute)
                               reminder(m, new EventArgs());
                    }
                Thread.Sleep(6000);
            }
        }

        public void UpdateTask(BE.Task task)
        {
            if (searchTaskById(task.TaskId) == null)
                throw new Exception("BL :the task doesn't exist");
            //if (task.DateTask < DateTime.Now)
            //    throw new Exception("BL :the date have passed already");
            myDal.UpdateTask(task);
        }
    }
}
