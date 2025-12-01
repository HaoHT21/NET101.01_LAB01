using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    using System;

    // 2. Tạo lớp Product thực thi interface DbAction
    public class Product : DbAction
    {
        public void insert()
        {
            // Ví dụ: Console.Write("Insert product")
            Console.WriteLine("Insert product");
        }

        public void update()
        {
            Console.WriteLine("Update product");
        }

        public void delete()
        {
            Console.WriteLine("Delete product");
        }

        public void select()
        {
            Console.WriteLine("Select product");
        }
    }

    // 2. Tạo lớp Order thực thi interface DbAction
    public class Order : DbAction
    {
        public void insert()
        {
            Console.WriteLine("Insert order");
        }

        public void update()
        {
            Console.WriteLine("Update order");
        }

        public void delete()
        {
            Console.WriteLine("Delete order");
        }

        public void select()
        {
            Console.WriteLine("Select order");
        }
    }
}
