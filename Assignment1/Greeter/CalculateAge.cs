class CalculateAge
{
    public void Age()
    {
        // Ask user to enter DOB
        Console.WriteLine("Please enter your DOB(yyyy/MM/dd)");
        string? DOB = Console.ReadLine();

        // parse the user input DOB to DateTime Object
        if (DateTime.TryParse(DOB, out DateTime Dob))
        {
            string formattedDob = Dob.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine($"Your DOB : {formattedDob}");

            DateTime today = DateTime.Today;
            int ageInYears = today.Year - Dob.Year;
            int ageInMonths = today.Month - Dob.Month;
            int ageInDays = today.Day - Dob.Day;

            // Adjust negative values
            if (ageInMonths < 0 || (ageInMonths == 0 && ageInDays < 0))
            {
                ageInYears--;
                ageInMonths += 12;
            }
            if (ageInDays < 0)
            {
                ageInMonths--;
                if (ageInMonths < 0)
                {
                    ageInYears--;
                    ageInMonths += 12;
                }
                ageInDays += DateTime.DaysInMonth(today.Year, today.Month);
            }

            // Calculate age in weeks and remaining days
            int ageInWeeks = ageInDays / 7;
            ageInDays %= 7;

            Console.WriteLine($"Age as of now: {ageInYears} years, {ageInMonths} months, {ageInWeeks} weeks, {ageInDays} days");
        }
         else
        {
            Console.WriteLine("Invalid date format. Please enter the date in the format yyyy/MM/dd.");
        }
    }
}
