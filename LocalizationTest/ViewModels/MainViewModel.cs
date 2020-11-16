using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LocalizationTest
{
    public class MainViewModel : BasePropertyChanged
    {
        private Localization _localization = LocalizationFactory.GetLocalization();
        public Localization Localization
        {
            get { return _localization; }
            set
            {
                _localization = value;
                NotifyPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Cultures = new ObservableCollection<CultureInfo>();
            foreach (var culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures).Where(c => c.Name == "de-DE" || c.Name == "en-GB" || c.Name == "fr-FR"))
            {
                Cultures.Add(culture);
            }
        }

        private ObservableCollection<CultureInfo> _cultures;
        public ObservableCollection<CultureInfo> Cultures
        {
            get { return _cultures; }
            set { _cultures = value; }
        }

        private CultureInfo _selectedCulture = CultureInfo.CurrentUICulture;

        public CultureInfo SelectedCulture
        {
            get { return _selectedCulture; }
            set { 
                _selectedCulture = value;
                CultureInfo.CurrentUICulture = value;
                NotifyPropertyChanged();
                Localization.NotifyResources();
            }
        }



    }


}
