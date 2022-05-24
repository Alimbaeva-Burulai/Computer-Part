using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_2ndTry.Model
{
    public class Computer : ObservableObject
    {
        private IList<ComputerPart> computerParts;
        private int sumPrice;

        public IList<ComputerPart> ComputerParts { get => computerParts; set {
                SetProperty(ref computerParts, value);
            } }
        public int SumPrice { get => sumPrice; set {
                SetProperty(ref sumPrice, value);
            } }
    }
}
