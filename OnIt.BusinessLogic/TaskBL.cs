﻿using OnIt.Model;
using OnIt.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnIt.BusinessLogic
{
   public class TaskBL : BaseBL
   {
      public TaskBL(string connectionString) : base(connectionString)
      {
      }

      public List<TaskModel> GetAll()
      {
         var taskList = new List<TaskModel>();
         var repo = new RepositoryData<TaskModel>(context);

         taskList = repo.GetAll().ToList();
         return taskList;
      }

      public bool Create(TaskModel task)
      {
         var repo = new RepositoryData<TaskModel>(context);
         try
         {
            repo.Create(task);
            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }

      public bool Delete(int idTask)
      {
         var repo = new RepositoryData<TaskModel>(context);
         try
         {
            repo.Delete(idTask);
            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }
   }
}
