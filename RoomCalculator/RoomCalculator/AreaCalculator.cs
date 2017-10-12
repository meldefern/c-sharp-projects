using System;
using System.Collections.Generic;
namespace RoomCalculator
{
    public class AreaCalculator
    {

        IList<IArea> shapes;

        public AreaCalculator(IList<IArea> shp)
        {
            this.shapes = shp;
        }

        virtual public void AddShape(IArea shp)
        {
            this.shapes.Add(shp);
        }

        virtual public double GetTotalArea(){
			double total = 0;

			foreach (IArea s in this.shapes)
			{
				total += s.CalculateArea();
			}

            return total;
        }
    }
}
