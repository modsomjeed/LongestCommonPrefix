using System;

namespace LongestCommonPrefix
{
    public class CommonPrefix
    {
        public string checkPrefix (string [] Sentence) {
            string tmp = "";
            string prefix = "";
            foreach (var item in Sentence[0]) {
                int count = 0;
                tmp = tmp+item;
                foreach (var item2 in Sentence)
                {
                    if(item2.StartsWith(tmp)) {
                        ++count;
                    }
                }
                if (count == 3) {
                    prefix = tmp;
                }
            }
            Console.WriteLine(prefix);
            return prefix;
        }
    }
}