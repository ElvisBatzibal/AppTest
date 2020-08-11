using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.ViewModel
{
    /// <summary>
    /// MainViewModel
    /// </summary>
    public class MainViewModel
    {
        private static MainViewModel instance;

        public LoginViewModel Login { get; set; }
        public MainViewModel()
        {           
            instance = this;
            Login = new LoginViewModel();

        }
        /// <summary>
        /// Call Instance MainViewModel
        /// </summary>
        /// <returns></returns>
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
    }
}
