using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CAROGAME
{
    public class Player
    {
        private string name;
        private Image mark;
        public string Name { get => name; set => name = value; }
        public Image Mark { get => mark; set => mark = value; }

        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;
        }

        /*private Color mark;
        public Color Mark { get => mark; set => mark = value; }*/


        /* public Player(string name, Color mark)
         {
             this.Name = name;
             this.Mark = mark;
         }*/
    }
}
