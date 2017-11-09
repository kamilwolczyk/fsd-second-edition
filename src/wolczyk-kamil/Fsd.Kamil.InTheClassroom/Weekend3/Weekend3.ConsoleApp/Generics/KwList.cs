using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend3.ConsoleApp.Generics
{
    class KwList<TListItem>
    {
        private TListItem[] _items;

        private int _selectedIndex;

        public KwList(int maxItemCount)
        {
            _items = new TListItem[maxItemCount];
            _selectedIndex = 0;
        }

        public void Add(TListItem item)
        {
            _items[_selectedIndex] = item;
            _selectedIndex++;
        }
    }
}
