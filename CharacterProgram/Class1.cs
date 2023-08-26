using System;

namespace CharacterProgram
{
  public class CharacterLogic
  {
    public string SortString(string str)
    {
      char[] chars = str.ToCharArray();
      for (int i = 0; i < str.Length; i++)
      {
        for (int j = i + 1; j < str.Length; j++)
        {
          if ((int)chars[i] > (int)chars[j])
          {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
          }
        }
      }
      return string.Join("",chars);
    }
  }
}