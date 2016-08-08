using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App2
{
    public class TestViewModel
    {
        public ObservableCollection<int> Data { get; } = new ObservableCollection<int> { 1, 2, 3, 4 };

        public ICommand AddCommand { get; set; }

        public TestViewModel()
        {
            AddCommand = new DelegateCommand(() => Data.Add((new Random()).Next(10)));
        }

        
    }
}
