using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Model.Builder
{
    public interface IHouseBuilder
    {
        public void buildBasement();
        public void buildStructure();
        public void bulidRoof();
        public void buildInterior();
        public House getHouse();
    }
}
