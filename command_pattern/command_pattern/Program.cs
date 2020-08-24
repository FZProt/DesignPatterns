using System;
using System.Collections.Generic;

namespace command_pattern
{
    class Program
    {
        static Stack<Icommand> stack = new Stack<Icommand>();
        static void Main(string[] args)
        {
            var circle = CreateCircle(50, 50, 20);
            changeColor(circle, "red");
            changeSize(circle, 50);
            UndoAction();
            UndoAction();
        }

        private static void UndoAction()
        {
        }

        private static void changeSize(CircleObject circle, int size)
        {
            var funcObj = new sizeSetter(circle, size);
            funcObj.execute();
            stack.Push(funcObj);
        }

        private static void changeColor(CircleObject circle, string color)
        {
            var funcObj = new colorSetter(circle, color);
            funcObj.execute();
            stack.Push(funcObj);
        }

        private static CircleObject CreateCircle(int x, int y, int r)
        {
            var circle = new CircleObject(x,y,r);
            circle.draw();
            return circle;
        }

        

    }
    class sizeSetter :Icommand
    {
        private CircleObject circle;
        private int size;

        public sizeSetter(CircleObject circle, int size)
        {
            this.circle = circle;
            this.size = size;
        }

        public void execute()
        {
            circle.setSize(size);
        }
    }
    class colorSetter :Icommand
    {
        private CircleObject circle;
        private string color;

        public colorSetter(CircleObject circle, string color)
        {
            this.circle = circle;
            this.color = color;
        }

        public void execute()
        {
            circle.setColor(color);
        }
    }
    interface Icommand
    {
        void execute();
    }

}