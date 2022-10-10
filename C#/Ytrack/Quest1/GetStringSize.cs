namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            if(str == null){
                return 0;
            }
            int length = str.Length;
            return length;
        }
    }
}