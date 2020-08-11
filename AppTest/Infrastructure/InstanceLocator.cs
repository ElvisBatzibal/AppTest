using AppTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
    