using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateToMonth
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime moveToDate = new DateTime(2050, 11, 25);

        public DateTime MoveToDate
        {
            get
            {
                return this.moveToDate;
            }
            set
            {
                this.moveToDate = value;
                this.OnPropertyChanged(nameof(MoveToDate));
            }
        }

        public ViewModel()
        {
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
