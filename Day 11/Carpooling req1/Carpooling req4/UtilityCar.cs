using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpooling_req4
{
    public class UtilityCar : Car
    {
        bool _rearCoolingVents;
        public bool RearCoolingVents
        {
            get { return _rearCoolingVents; }
            set { _rearCoolingVents = value; }
        }
        public UtilityCar() { }
        public UtilityCar(bool rearCoolingVents, long id, string name) : base(id, name)
        {
            RearCoolingVents = rearCoolingVents;

        }
        public override double CalculateDriveCost(double km)
        {
            return 18 * km;
        }
    }   }
