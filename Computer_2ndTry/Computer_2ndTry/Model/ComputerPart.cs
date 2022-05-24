using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_2ndTry.Model
{
    public class ComputerPart : ObservableObject
    {
        private string id;
        private string brand;
        private int price;
        private string category;

        public string Id { get => id; set { SetProperty(ref id, value); } }
        public string Brand { get => brand; set { SetProperty(ref brand, value); } }
        public int Price { get => price; set {
                SetProperty(ref price, value);
            } }
        public string Category { get => category; set {
                SetProperty(ref category, value);
            } }
    }
}
