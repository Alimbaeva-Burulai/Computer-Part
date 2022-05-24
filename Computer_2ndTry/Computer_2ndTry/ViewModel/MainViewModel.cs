using Computer_2ndTry.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_2ndTry.ViewModel
{
    public class MainViewModel : ObservableRecipient
    {
        public ObservableCollection<ComputerPart> FirstList { get; set; }
        public ObservableCollection<ComputerPart> SecondList { get; set; }
        public ObservableCollection<Computer> ThirdList { get; set; }
        private ComputerPart selectedPart1;
        private ComputerPart selectedPart2;

        public ComputerPart SelectedPart1 { get => selectedPart1; set { SetProperty(ref selectedPart1, value); Add.NotifyCanExecuteChanged();Edit.NotifyCanExecuteChanged(); } }
        public ComputerPart SelectedPart2 { get => selectedPart2; set { SetProperty(ref selectedPart2, value);Delete.NotifyCanExecuteChanged(); } }

        public RelayCommand Add { get; set; }
        public RelayCommand Edit { get; set; }
        public RelayCommand Delete { get; set; }
        public RelayCommand Save { get; set; }
        public MainViewModel()
        {
            FirstList = new ObservableCollection<ComputerPart>();
            SecondList = new ObservableCollection<ComputerPart>();
            ThirdList = new ObservableCollection<Computer>();
            Read("parts.txt");

            Add = new RelayCommand(() =>
              {
                  SecondList.Add(SelectedPart1);
              },()=>SelectedPart1!=null);

            Edit = new RelayCommand(() =>
            {
                if (selectedPart1 == null)
                {
                    FirstList.Add(new ComputerPart());
                    EditWindow win = new EditWindow(FirstList[FirstList.Count-1]);
                    win.ShowDialog();
                }
                else
                {
                    EditWindow win = new EditWindow(SelectedPart1);
                    win.ShowDialog();
                }
            });

            Delete = new RelayCommand(() =>
            {
                SecondList.Remove(SelectedPart2);
            },()=>SelectedPart2!=null);

            Save = new RelayCommand(() =>
              {
                  ThirdList.Add(new Computer()
                  {
                      ComputerParts = SecondList,
                      SumPrice = SecondList.Sum(x => x.Price)
                  });
              });
        }

        public void Read(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string row = reader.ReadLine();
                string[] items = row.Split(',');
                FirstList.Add(new ComputerPart
                {
                    Id = items[0],
                    Brand = items[1],
                    Price = int.Parse(items[2]),
                    Category = items[3]
                });
            }
        }
    }
}
