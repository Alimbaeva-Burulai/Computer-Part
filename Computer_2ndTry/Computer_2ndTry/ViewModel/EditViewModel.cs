using Computer_2ndTry.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_2ndTry.ViewModel
{
    public class EditViewModel
    {
        public ComputerPart MyPart { get; set; }
        public ObservableCollection<string> Categories { get; set; }
        public void Setup( ComputerPart part)
        {
            MyPart = part;
            Categories.Add("Mouse");
            Categories.Add("harddisk");
            Categories.Add("keyboard");
        }
        public EditViewModel()
        {
            Categories = new ObservableCollection<string>();
        }
    }
}
