using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Finman.Source
{
    public class BaseManager
    {
        
    }

    public class FinmanManager : BaseManager
    {
        public ObservableCollection<FixcostItem> Fixcosts { get; set; } = new ObservableCollection<FixcostItem>();
        public ObservableCollection<ServiceItem> Services { get; set; } = new ObservableCollection<ServiceItem>();
        public decimal DailyAmount { get; set; } = 10;

        public void Remove(object item)
        {
            if (item is FixcostItem)
                Fixcosts.Remove(item as FixcostItem);

            if (item is ServiceItem)
                Services.Remove(item as ServiceItem);
        }
    }
}
