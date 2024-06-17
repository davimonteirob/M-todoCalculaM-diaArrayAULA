using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoCalculaMédiaArrayAULA
{
    internal class Class
    {
   
        
        public double CalcularMédia(double[] array01) 
        { 
            Array.Sort(array01);
            double soma = 0;
            for (int posi = 0; posi < array01.Length; posi++) 
            {
                soma += array01[posi];
            
            }
            double media = soma/array01.Length;
            return media;

        
        }
    }
}
