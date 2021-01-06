using System;

namespace FriendAssemblies.Lib
{
    public static class ArrayHelper
    {

        public static int[] ParseList(string listOfNumbers)
        {
            if (string.IsNullOrWhiteSpace(listOfNumbers))
            {
                return new int[0];
            }

            string[] parts = listOfNumbers.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int[] result = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                result[i] = Helpers.ConvertFromString(parts[i]);
            }

            return result;
        }
    }
}
