using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularBuffer
{
    class CircularBuffer
    {
        private int[] data;
        private int head;
        private int tail;
        public CircularBuffer(int number)
        {
            data = new int[number];
            head = 0;
            tail = 0;
        }
        public bool store(int value)
        {
            if (!bufferfull())
            {
                data[tail++] = value;
                if (tail == data.Length)
                    tail = 0;
                return true;
            }
            return false;
        }
        public bool bufferfull()
        {
            if ((tail + 1 == head) || (tail == data.Length - 1 && head == 0))
                return true;
            return false;
        }
        public int read()
        {
            if(head == tail)
            {
                int value = data[(head + 1) % data.Length];
                return value;
            }
            return 0;
        }
    }
}
