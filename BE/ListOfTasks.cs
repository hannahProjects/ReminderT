using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ListOfTasks
    {
       
       
        /// <summary>
        /// 
        /// </summary>
        static int currentId=0;
        [Key]
        public int ListOfTasksId { set; get; }

        public string CategoryList { set; get; }
        public virtual ICollection<Task> Tasks { set; get; }
        public ListOfTasks()
        {
            Tasks = new List<Task>();
        }
        //public ListOfTasks(string _categoryList)
        //{
        //    Tasks = new List<Task>();
        //    ListOfTasksId = currentId;
        //    categoryList = _categoryList;
        //    currentId++;
        //}
        //public ListOfTasks()
        //{
        //    Tasks = new List<Task>();
        //    ListOfTasksId =currentId;
        //    categoryList = "";
        //    currentId++;
        //}
        
       

    }
}
