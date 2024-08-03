using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singeltone
{
    // Constructor Private
    // Static Method
    // Static Property For Singelton Obj OR Static Property
    internal class GCard
    {
        private static GCard SingeltonObj = new GCard(123);
        public int Data { get; set; }
        private GCard(int data)
        {
            Data = data;
        }
        public static GCard GetCard()
        {
            return SingeltonObj; 
        }

        public static GCard SingeltonCard { get; } = new GCard(123);

    }
}
