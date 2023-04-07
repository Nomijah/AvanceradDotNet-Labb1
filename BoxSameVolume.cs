using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNetLabb1
{
    internal class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            if (x.length * x.height * x.width == y.length * y.height * y.width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            return obj.length ^ obj.height ^ obj.width;
        }
    }
}
