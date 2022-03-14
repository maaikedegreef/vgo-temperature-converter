using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cells
{
    public class Cell : INotifyPropertyChanged
    {
        private object contents;

        public Cell(object initialContents = null)
        {
            this.contents = initialContents;
        }

        public object Value
        {
            get
            {
                return contents;
            }
            set
            {
                this.contents = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
