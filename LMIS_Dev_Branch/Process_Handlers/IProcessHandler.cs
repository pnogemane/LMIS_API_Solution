﻿using LMIS_Dev_Branch.Models;
namespace LMIS_Dev_Branch.Process_Handler

{
    public interface IProcessHandler
    {
        public void PerformTask();
        public List<IModel> GetModel();

    }
}
