using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExample
{
    class EventModel
    {
        private string title;
        private DateTime date;

        public string Title
        {
            get => title;
            set
            {
                if (value != title)
                {
                    title = value;
                }
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                if (value != date)
                {
                    date = value;
                }
            }
        }
    }
}
