﻿using PortfolioBackend.Configurations;
using PortfolioBackend.Core.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBackend.Core.BLL.Services
{
    public class PermissionService : SimpleBaseService<Permission>
    {
        public static PermissionService Instance
        {
            get
            {
                return AppDependencyResolver.Current.GetService<PermissionService>();
            }
        }
    }
}
