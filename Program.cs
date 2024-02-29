using System.Reflection.PortableExecutable;

namespace as2324._3G.FucciRiccardo.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire la dimensione");
            int dim=Convert.ToInt32(Console.ReadLine());
            int[] array= new int[dim];
            double[] voti= new double[dim];
            int[] pesi = new int[dim];
            

            CaricaVettori(voti, pesi, nVoti);
        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("voto" + " pesi");
            for(int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine($"voto{i}     pesi{i}");
            }

        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
            for(int i = 0;i < nVoti; i++)
            {
                 voti[i]=random.Next(0,11);
                 pesi[i]=random.Next(0,101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for(int i = 0; i<nVoti; i++)
            {
                if(voti[i] > 4 &&  )
                {
                     
                }
            }
        }

    }
}
