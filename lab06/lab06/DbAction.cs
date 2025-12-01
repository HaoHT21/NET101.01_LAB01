using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public interface DbAction
    {
        void insert();
        void update();
        void delete();
        void select();
    }
}
