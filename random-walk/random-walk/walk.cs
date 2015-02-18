using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;
using Rhino.Geometry;


namespace random_walk
{
    class walk : Rhino_Processing
    {

        public walker newObj;

        public override void Setup()
        {
            newObj = new walker();

        }

        public override void Draw()
        {
            newObj.step();
            newObj.display(doc);
            
        }
    }
}
