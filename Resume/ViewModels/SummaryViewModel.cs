using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Resume.Models;

namespace Resume.ViewModels
{
    public class SummaryViewModel:ViewModel_Base
    {
        private static readonly DependencyProperty SummaryInfoProperty;

        static SummaryViewModel()
        {
            SummaryInfoProperty = DependencyProperty.Register("SummaryInfo", typeof(string), typeof(MainViewModel));
        }

        public SummaryViewModel(SummaryModel model)
        {
            SummaryInfo = Info_G(model);
        }
     
        public string SummaryInfo
        {
            get { return (string)GetValue(SummaryInfoProperty); }
            set { SetValue(SummaryInfoProperty, value); }
        }
        private string Info_G(SummaryModel model)
        {
            return $"Name:{model.Name}\nAge:{model.Age}\nEmail:{model.Email}\nPhone:{model.Phone}\nEducation:{model.Education}\nExperience:{model.Experience}\nSkills:{model.Skills}\t";
        }
    }
}
