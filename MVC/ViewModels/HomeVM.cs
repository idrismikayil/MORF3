﻿using Domain.Entities.Home;

namespace MVC.ViewModels
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
}