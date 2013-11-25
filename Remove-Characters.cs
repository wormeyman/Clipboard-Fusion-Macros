using System;

public static class ClipboardFusionHelper
{
	public static string ProcessText(string text)
	{
			 return text.Replace(" ", "-")			//space
						.Replace(":","-")			//colon
						.Replace(";","-")			//semi-colon
						.Replace("&","-")			//Ampersand
						.Replace("%","-")			//Percent
						.Replace("?","-")			//QuestionMark
						.Replace("�","-")			//Em dash
						.Replace("�","-")			//En dash (kindof redundant)
						.Replace("�","-")			//Smart Quote
						.Replace("�","-")			//Smart Quote
						.Replace("�","-")			//Typographic apostrophe
						.Replace("[","-")			//Left Bracket
						.Replace("]","-")			//Right Bracket
						.Replace("�","-")			//Registered TradeMark
						.Replace("*","-")			//star
						.Replace("#","-");			//number sign / pound / hash / Octothorp
	}
}
