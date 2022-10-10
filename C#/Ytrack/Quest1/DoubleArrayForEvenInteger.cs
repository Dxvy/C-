namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
        public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        {
            for (int i = 0; i <= inputTab.Length -1; i++) {
                if (inputTab[i] % 2 == 0)
                {
                    
                }
                else
                {            
                    inputTab[i] = inputTab[i]*2;
                }
            }
            return inputTab;
        }
    }
}