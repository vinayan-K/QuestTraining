
           // Code for finding the sum of the series "10_200_300_3" //
            string pattern = "10_200_300_3";
            int sum = 0;
            string number = "";

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] != '_')
                {
                    number += pattern[i];
                }
                else
                {
                    if (number != "")
                    {
                        sum += int.Parse(number);
                        number = "";
                    }
                }
            }

            if (number != "")
            {
                sum += int.Parse(number);
            }

            Console.WriteLine(sum);