using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pr7_wpf_converts_Trembach.Models
{
    public class WarehouseItem : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _unitPrice;
        public float UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (_unitPrice != value)
                {
                    _unitPrice = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TotalValue));
                }
            }
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TotalValue));
                    OnPropertyChanged(nameof(IsLowStock));
                }
            }
        }

        private int _minimumStock;
        public int MinimumStock
        {
            get => _minimumStock;
            set
            {
                if (_minimumStock != value)
                {
                    _minimumStock = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsLowStock));
                }
            }
        }

        public float TotalValue => UnitPrice * Quantity;

        public bool IsLowStock => Quantity < MinimumStock;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
