using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rhino;
using Rhino.Geometry;

namespace random_walk
{
    class walker
    {
        /////////////
        //properties
        /////////////

        public double x;
        public double y;
        public double z;
        public Point3d walker_origin;


        /////////////
        //constractors
        /////////////
        public walker()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;

        }

        /////////////
        //methods
        /////////////
        public void display(RhinoDoc _doc)
        {
            walker_origin = new Point3d(x, y, z);
            _doc.Objects.AddPoint(walker_origin);
        }

        public void step()
        {
            //create random object
            Random rnd = new Random();

            int choice = rnd.Next(4);

            if (choice == 0)
            {
                x+=10;
            }
            else if (choice == 1)
            {
                x-=10;
            }
            else if (choice == 2)
            {
                y+=10;
            }
            else if (choice == 3)
            {
                y-=10;
            }

        }
    }
}
