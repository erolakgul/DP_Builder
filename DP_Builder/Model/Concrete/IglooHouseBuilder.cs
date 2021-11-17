﻿using DP_Builder.Model.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Model.Concrete
{
    public class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }
        public void buildBasement()
        {
            house.setBasement("Ice Bars");
        }

        public void buildStructure()
        {
            house.setStructure("Ice Blocks");
        }

        public void buildInterior()
        {
            house.setInterior("Ice Carvings");
        }

        public void bulidRoof()
        {
            house.setRoof("Ice Dome");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
