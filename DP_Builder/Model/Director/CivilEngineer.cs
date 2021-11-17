using DP_Builder.Model.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Model.Director
{
    public class CivilEngineer
    {
        private IHouseBuilder houseBuilder;

        public CivilEngineer(IHouseBuilder _houseBuilder)
        {
            houseBuilder = _houseBuilder;
        }

        public House getHouse()
        {
            return this.houseBuilder.getHouse();
        }

        public void constructHouse()
        {
            houseBuilder.buildBasement();
            houseBuilder.buildStructure();
            houseBuilder.bulidRoof();
            houseBuilder.buildInterior();
        }
    }
}
