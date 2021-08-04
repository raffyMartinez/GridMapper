using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMapper.entities
{
    public class CategoryEventArgs : EventArgs
    {
        public int NumberOfCategories { get; set; }
        public bool ProccedWithCategory { get; set; }
    }
}
