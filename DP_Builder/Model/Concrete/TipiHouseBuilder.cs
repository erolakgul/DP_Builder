using DP_Builder.Model.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Model.Concrete
{
    public class TipiHouseBuilder : IHouseBuilder
    {
        private House house;
        public TipiHouseBuilder()
        {
            this.house = new House();
        }
        public void buildBasement()
        {
            house.setBasement("Wooden Poles");
        }

        public void buildStructure()
        {
            house.setStructure("Wood and Ice");
        }

        public void buildInterior()
        {
            house.setInterior("Fire Wood");
        }

        public void bulidRoof()
        {
            house.setRoof("Wood, caribou and seal skins");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
