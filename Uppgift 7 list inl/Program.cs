using System;

namespace Uppgift_7_list_inl
{
    class program
    {
        static void Main(string[] args)
        {
            string[] arr1 = {"a",  "b", "b", "c", "hej"};
            string[] arr2 = { "hej", "a", "a", "b", "programmering" };

            string[] resultat = Finnsibåda(arr1, arr2);
            for (int i = 0; i < resultat.Length; i++)
            {
                Console.WriteLine(resultat[i]);
            }
        }
        static string[] Finnsibåda(string[] arr1, string[] arr2)
        {
            Dictionary<string, string> lika = new Dictionary<string, string>();
            foreach (string str1 in arr1)
            {
                foreach(string str2 in arr2)
                {
                    if (str1 == str2)
                    {
                        lika[str1] = str2;
                        break;
                    }
                }
            }
            return lika.Keys.ToArray();
        }
    }
}