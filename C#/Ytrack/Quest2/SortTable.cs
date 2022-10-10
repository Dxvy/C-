using System ;
using System.Linq;
namespace CSharpDiscovery.Quest02

{
    public class SortTable_Exercice
    {
        public static int[] SortTable(int[] tab)
        {
            Array.Sort<int>(tab, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
            return tab;
        }
    }
}