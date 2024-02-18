using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public static class ProductCalculator
    {
        public static int CalculateMaterial(double width, double length, int amount, int product_id, int material_id)
        {
            double[] product_type = new double[] { 1.1, 2.5, 8.43 },
                material_type = new double[] { 0.3, 0.12 };
            if (product_id < 1 || product_id > product_type.Length || material_id < 1 || material_id > material_type.Length)
                return -1;
            return (int)Math.Ceiling(width * length * product_type[product_id - 1] * amount * (1 + material_type[material_id - 1]));
        }
    }
}
