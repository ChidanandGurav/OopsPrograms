using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class ObjectCount
    {
        private int id;
        private string name;
        private static int count = 0;

        public ObjectCount( string name)
        {
            count++;
            this.id = count;
            this.name = name;
        }

        public static string Objects()
        {
            return $" {count} objects";
        }
    }
}
