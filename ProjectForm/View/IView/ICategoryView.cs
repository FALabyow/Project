﻿using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ICategoryView
    {
        void DisplayCategoryList (List<CategoryDto> categortList);
        void ShowMessage(string message);
    }
}
