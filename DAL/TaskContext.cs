using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BE;
namespace DAL
{

    public class TaskContext : DbContext
    {
        public DbSet<ListOfTasks> Lists { set; get; }
        public DbSet<Task> Tasks { set; get; }

        public TaskContext() : base("OurProject")
        {// Tasks = new DbSet<Task>;
        }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many 
            modelBuilder.Entity<Task>()
                        .HasRequired<ListOfTasks>(s => s.ListOfTasks) // Student entity requires Standard 
                        .WithMany(s => s.Tasks) // Standard entity includes many Students entities
                        .WillCascadeOnDelete(true);
            //.HasForeignKey<int>(s => s.TaskId);
            // 
        }



        //protected override void OnModelCreating(DbModelBuilder builder)
        //{
        //    builder.Entity<Task>().HasMany(c => c.TaskList).WithRequired(u => u.Tasks)
        //           .HasForeignKey(u => u.ListOfTasksId).WillCascadeOnDelete(value: false);

        //    // Add other non-cascading FK declarations here

        //    base.OnModelCreating(builder);
    

    }

}
