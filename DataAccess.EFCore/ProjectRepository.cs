﻿using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
   public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository( ApplicationContext context):base(context)
        {

        }
    }
}
