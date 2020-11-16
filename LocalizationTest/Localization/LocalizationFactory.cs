using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTest
{
   public static class LocalizationFactory
    {
        private static Localization _instance;
        public static Localization GetLocalization()
        {
            if (_instance == null) _instance = new Localization();
            return _instance;
        }
    }
}
