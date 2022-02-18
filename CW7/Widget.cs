using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    public abstract class Widget
    {
        virtual public void draw()
        {
            Console.WriteLine("Something is drawn");        
        }
    }

    public class TextField : Widget
    {
        int width = 100;
        int height = 100;
        public TextField(int width, int height)
        {
            Console.WriteLine("A text field of width " + width + " and height " + height + " has been made.");
        }

        public override void draw()
        {
            base.draw();
        }
    }

    public abstract class Decorator : Widget
    {
        public Widget wid;

        public Decorator(Widget wid)
        {
            Console.WriteLine("The box is decorated");
        }

        public override void draw()
        {
            base.draw();
        }
    }

    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget wid) : base(wid)
        {
            Console.WriteLine("The box's border is decorated");
        }

        public override void draw()
        {
            base.draw();
        }
    }

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget wid) : base(wid)
        {
            Console.WriteLine("The box's scroll bar is decorated");
        }

        public override void draw()
        {
            base.draw();
        }
    }
}
