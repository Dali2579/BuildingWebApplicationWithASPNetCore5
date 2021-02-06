﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {

        IEnumerable<Category> ICategoryRepository.AllCategories
        { 
            get =>  new List<Category>
                {
                    new Category{CategoryId=1,CategoryName="Fruit pies",Description="All-Fruite pies"},
                    new Category{CategoryId=2,CategoryName="Chees cakes",Description="Cheesy"},
                    new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "Pie of the seaon" }

                };  
        }
    }
}
