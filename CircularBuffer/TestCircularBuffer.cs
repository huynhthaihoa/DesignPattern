using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularBuffer
{
    class TestCircularBuffer
    {
        public TestCircularBuffer()
        {
            CircularBuffer buffer = new CircularBuffer(8);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Storing:" + (i + 1).ToString());
                buffer.store(i + 1);
                if (i % 3 == 0)
                    Console.WriteLine("Reading:" + buffer.read());
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Reading:" + buffer.read());
            }
        }
        static void Main(string[] args)
        {
            TestCircularBuffer test = new TestCircularBuffer();
        }
    }
}
