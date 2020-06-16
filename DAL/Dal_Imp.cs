using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BE;

namespace DAL
{
    public class Dal_Imp : Idal
    {
        TaskContext myDB;
        public int i = 1;
        public ListOfTasks lFamily;
        public ListOfTasks lWork;
        public ListOfTasks lStudies;


        public Dal_Imp()
        {
            myDB = DBFactory.getDB();
            ////אתחול רשימת לימודים
            //lStudies = new ListOfTasks { ListOfTasksId = 3, CategoryList = "Studies" };
            //myDB.Lists.Add(lStudies);
            //myDB.SaveChanges();



            //Task t = new Task
            //{
            //    ListOfTasksId = 3,
            //    TaskId = 1,
            //    NameTask = "s1",
            //    LocationTask = "Tel Aviv",
            //    TypeTask = type1.studies,
            //    DescriptionTask = "complete all three layers in the project",
            //    DateTask = new DateTime(2017, 03, 26),
            //    WhenToRemember = new DateTime(2017, 03, 25),
            //    PriorityTask = priority.HIGH,

            //};
            //myDB.Tasks.Add(t);
            //myDB.SaveChanges();
            ////אתחול רשימת עבודה
            //lWork = new ListOfTasks { ListOfTasksId = 2, CategoryList = "Work" };
            //myDB.Lists.Add(lWork);
            //myDB.SaveChanges();



            //Task t1 = new Task
            //{
            //    ListOfTasksId = 2,
            //    TaskId = 1,
            //    NameTask = "w1",
            //    LocationTask = "Tel Aviv",
            //    TypeTask = type1.work,
            //    DescriptionTask = "complete all three layers in the project",
            //    DateTask = new DateTime(2017, 03, 26),
            //    WhenToRemember = new DateTime(2017, 03, 25),
            //    PriorityTask = priority.HIGH,

            //};
            //myDB.Tasks.Add(t1);
            //myDB.SaveChanges();

            //אתחול רשימת משפחה
          
            //lFamily = new ListOfTasks { ListOfTasksId = 1, CategoryList = "Family" };
            //myDB.Lists.Add(lFamily);
            //myDB.SaveChanges();



            //Task t = new Task
            //{
            //    ListOfTasksId = 1,
            //    TaskId = 1,
            //    NameTask = "finish project 2",
            //    LocationTask = "ramat gan",
            //    TypeTask = type1.family,
            //    DescriptionTask = "complete all three layers in the project",
            //    DateTask = new DateTime(2017, 03, 26),
            //    WhenToRemember = new DateTime(2017, 03, 25),
            //    PriorityTask = priority.HIGH,

            //};
            //myDB.Tasks.Add(t);
            //myDB.SaveChanges();






            //
        }
        //public void initiliaze()
        //{ 
        //    myDB = DBFactory.getDB();
        //    lFamily = new ListOfTasks { ListOfTasksId=1,CategoryList="Family"};
        //    myDB.Lists.Add(lFamily);
        //    myDB.SaveChanges();



        //     Task t = new Task
        //     {
        //         ListOfTasksId =1,
        //         TaskId = 1,
        //         NameTask = "finish project",
        //         LocationTask = "ramat gan",
        //         TypeTask = type1.family,
        //          DescriptionTask = "complete all three layers in the project",
        //         DateTask = new DateTime(2017, 03, 26),
        //         WhenToRemember = new DateTime(2017, 03, 25),
        //         PriorityTask=priority.HIGH,

        //     };
        //    myDB.Tasks.Add(t);
        //    myDB.SaveChanges();






        //    //lWork = new ListOfTasks();
        //    //lStudies = new ListOfTasks();
        //    //lFamily.ListOfTasksId = 1;
        //    //lWork.ListOfTasksId = 2;
        //    //lStudies.ListOfTasksId = 3;
        //    //lFamily.Tasks = new List<BE.Task>();
        //    //lWork.Tasks = new List<BE.Task>();

        //    //lStudies.Tasks = new List<BE.Task>();

        //    //myDB.Lists.Add(lWork);
        //    //myDB.SaveChanges();
        //    //myDB.Lists.Add(lStudies);
        //    //myDB.SaveChanges();
        //}
        public void AddTask(BE.Task task)
        {

           // lFamily.Tasks.Add(task);
                myDB.Tasks.Add(task);
                myDB.SaveChanges();
            
           

        }

        public void RemoveTask(BE.Task task)
        {
            Task original = myDB.Tasks.SingleOrDefault(x => x.TaskId == task.TaskId);
            if (original != null)
            {
                myDB.Tasks.Remove(original);
                myDB.SaveChanges();
            }
            else
                throw new Exception("Can not find this mission");
     
        }
        public void UpdateTask(BE.Task task)
        {
            Task temp = myDB.Tasks.Find(task.TaskId);
            myDB.Tasks.Remove(temp);
            myDB.Tasks.Add(task);
            myDB.SaveChanges();
        }
        public List<BE.Task> searchByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<BE.Task> searchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void AddList(ListOfTasks list)
        {
            myDB.Lists.Add(list);
            myDB.SaveChanges();

        }

        public void RemoveList(ListOfTasks list)
        {
            myDB.Lists.Remove(list);
            myDB.SaveChanges();
        }

        public void UpdateList(ListOfTasks list)
        {
            ListOfTasks temp=myDB.Lists.Find(list.ListOfTasksId);           
            myDB.Lists.Remove(temp);
            myDB.Lists.Add(list);
            int ret =myDB.SaveChanges();
        }

        public void GetLists(List<ListOfTasks> l)
        {
            //return myDB.Lists.ToList();
            //using (var myDB = new DB())
            //{
                foreach (ListOfTasks l_ in myDB.Lists)
                {
                    ListOfTasks ls = new ListOfTasks();
                    foreach (Task m in myDB.Tasks)
                        if (m.ListOfTasksId == l_.ListOfTasksId)
                            ls.Tasks.Add(m);
                    ls.ListOfTasksId = l_.ListOfTasksId;
                    ls.CategoryList = l_.CategoryList;
                    l.Add(ls);
                }


           // }



            //foreach (ListOfTasks l_ in myDB.Lists)
            //    {
            //    ListOfTasks ls = new ListOfTasks();
            //        foreach (Task m in myDB.Tasks)
            //        if (m.ListOfTasksId == l_.ListOfTasksId)
            //                ls.Tasks.Add(m);
            //        ls.ListOfTasksId = l_.ListOfTasksId;
            //        ls.CategoryList = l_.CategoryList;
            //        l.Add(ls);
            //        i = 1;
            //    }

        }

        public List<Task> GetTasks()
        {
            return myDB.Tasks.ToList();
        }
    }
    
}
