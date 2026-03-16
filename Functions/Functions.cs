using System.Linq;

namespace Functions
{
    public class FunctionService
    {
        public bool IsValidGrade(int grade)
        {
            return grade >= 1 && grade <= 5;
        }

        public string HosszabbSzo(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return s1;

            if (s2.Length > s1.Length)
                return s2;

            return "egyformák";
        } 
        
        public bool IsOpen( int hour)
        {
            return hour >= 8 && hour < 16;
        }
        public string WordConversion(string word)
        {
            string vowels = "aáeéiíoóöõuúüû";
            string result = "";
            foreach (char c in word)
            {
                if (vowels.Contains(char.ToLower(c)))
                {
                    result += ".";
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }
            return result;
        }
    }

}