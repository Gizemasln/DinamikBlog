﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{

    
    public class WriterAboutOnDashboard: ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EfWriterRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = writermanager.GetWriterById(1);
            return View(values);


        }

    }
}
