using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainViewModel()
        {
            _subTotal = 100;
            _generosity = 100;

            Recalculate();
        }

        private double _tip;
        public double Tip
        {
            get { return _tip; }
            set
            {
                if (_tip != value)
                {
                    _tip = value;
                    OnPropertyChanged(nameof(Tip));
                    Recalculate();
                }
            }
        }

        private double _subTotal;
        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                if (_subTotal != value)
                {
                    _subTotal = value;
                    OnPropertyChanged(nameof(SubTotal));
                    Recalculate();
                }
            }
        }

        private double _generosity;
        public double Generosity
        {
            get { return _generosity; }
            set
            {
                if (_generosity != value)
                {
                    _generosity = value;
                    OnPropertyChanged(nameof(Generosity));
                    Recalculate();
                }
            }
        }

        private double _total;
        public double Total
        {
            get { return _total; }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged(nameof(Total));
                    Recalculate();
                }
            }
        }

       // public int TestProperty { get; set; }
       // IS EQUAL TO..

        public int _testProperty;
        public int TestProperty
        {
            get { return _testProperty; }
            set { _testProperty = value; }
        }

        private void Recalculate()
        {
            Tip = SubTotal * Generosity;
            Total = SubTotal + Tip;
        }

    }
}
