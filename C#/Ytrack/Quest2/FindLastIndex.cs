namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab != null){
                int marxou = 0;
                int intidou = 0;
                foreach(int i in tab){
                    if (i == a){
                        marxou = intidou;
                    }
                    intidou++;
                }
                if (marxou != 0) {
                    return marxou;
                }
            }
            return null;
        }
    }
}