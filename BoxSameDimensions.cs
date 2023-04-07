using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNetLabb1
{
    internal class BoxSameDimensions : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            if (x.length == y.length && x.height == y.height && x.width == y.width)
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
