using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_05_Counter_1
{
    class Counter
    {
        private int _counter;

        public  Counter()
        {
            _counter = 1;
        }

        public int GetCounter()
        {
            return _counter;
        }

    }
}

namespace Hw_05_Counter_2
{
    class Counter
    {
        private static int _counter;
        static Counter()
        {
            _counter = 0;
        }

        public Counter()
        {
            _counter++;
        }
        public int GetCounter()
        {
            return _counter;
        }



    }
}

namespace Hw_05_Counter_3
{
    public class Counter
    {
        private static int _counter;
        static Counter()
        {
            _counter = 0;
        
        }

        public Counter()
        {
            _counter++;
        
        }

        public static int GetCounter()
        {
            return _counter;
        
        }
    }



}