using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_Ques1
{
    public class Trading
    {      
    }
    public class Stocks : Trading
    {
        public string Volatility = "Low";     
    }
    public class Crypto : Trading
    {
        public string Volatility = "High";     
    }
    public class BinaryOptions : Trading
    {
       public string Volality = "Risk";
    }

     public class Program
    {
     public static void GetVolatility(Trading trading)
        {
            if(trading is Stocks stks)
            {
                Console.WriteLine($"stks.Volatility");
            }
            if(trading is Crypto crypto)
            {
                Console.WriteLine($"crypto.Volatility");
            }
            if(trading is BinaryOptions boption){
                Console.WriteLine($"boption.Volatility");
            }
            static void Main(string[] args)
            {
                Stocks stk = new Stocks();
                Crypto c = new Crypto();
                BinaryOptions bo =  new BinaryOptions();

                GetVolatility(stk);
                GetVolatility(c);
                GetVolatility(bo);
            }
        }
    }
}
