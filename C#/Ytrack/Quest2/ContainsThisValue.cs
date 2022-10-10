namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (tab == null)
            {
                return false;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}