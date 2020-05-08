using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullete_Jass
{
    public class SimpleClass
    {
        Random rd = new Random();
        //function for the generate the chances
        public int generators()
        {
            InitializeComponent();
            return rd.Next(1, 7);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public int generator2()
        {
            return rd.Next(3, 6);
        }
    }
}
