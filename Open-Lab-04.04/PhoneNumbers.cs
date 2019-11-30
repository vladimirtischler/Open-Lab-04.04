using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string prefix = "";
            string firstSection = "";
            string secondSection = "";
            for (int a = 0; a < 3; a++)
            {
                prefix += numbers[a];
            }
            for (int b = 3; b < 6; b++)
            {
                firstSection += numbers[b];
            }
            for (int c = 6; c < 10; c++)
            {
                secondSection += numbers[c];
            }
            return $"({prefix}) {firstSection}-{secondSection}";
        }

    }
}
