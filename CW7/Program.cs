using System;

namespace CW7
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 200;
            int height = 200;
            TextField tx = new TextField(width, height);
            tx.draw();

            BorderDecorator bd = new BorderDecorator(tx);
            ScrollDecorator sd = new ScrollDecorator(tx);
        }
    }
}
