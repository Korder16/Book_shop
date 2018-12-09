using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Book_shop2.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_shop2.Helpers.IRepositories
{
    public interface IRepository
    {
        void Save();
    }
}