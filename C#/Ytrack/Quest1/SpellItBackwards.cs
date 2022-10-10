namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            string reverse = "";
            str.ToCharArray();
            for (int i = 0; i < str.Length; i++) {
                reverse = reverse + str[str.Length-1-i];
            }
            return reverse;
        }
    }
}