using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Navigation
{
    public interface INavigationService
    {
        void Navigate(Type NewPage);
        void Return();
    }
}
