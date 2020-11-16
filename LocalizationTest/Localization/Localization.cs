using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

namespace LocalizationTest
{
    public class Localization : BasePropertyChanged
    {
        public void NotifyResources()
        {
            NotifyPropertyChanged("Item[]");
        }
        public string this[string index]
        {
            get
            {
                return Properties.Resources.ResourceManager.GetString(index);
            }
        }

    }
}
