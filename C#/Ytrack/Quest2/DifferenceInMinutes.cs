using System;

namespace CSharpDiscovery.Quest02
{
    public class DifferenceInMinutes_Exercice
    {
        public static double DifferenceInMinutes(DateTime start, DateTime end)
        {
            TimeSpan Ts = end - start;
            return(Ts.TotalMinutes);
        }
    }
}