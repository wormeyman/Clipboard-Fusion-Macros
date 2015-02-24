using System;

public static class ClipboardFusionHelper
{
    public static string ProcessText(string text)
    {
             return text.Replace("•","&bull;")            //Bullet
                        .Replace("“","\"")                //Smart Quote
                        .Replace("”","\"")                //Smart Quote
                        .Replace("’","'")                 //Smart Quote
                        .Replace("—","&mdash;")           //Em dash
                        .Replace("https://","http://")    //ssl remover
                        .Replace("…","...");              //elipses remover
    }
}
