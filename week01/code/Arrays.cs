public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //To begin, I want to create an array of doubles that is the size of the length parameter.  Which mean the number is 3 and the length of the muuultiples would be 5. So we would find the first 5 multiples of 3 which would make the capacity a size of 5 starting from index 0 to 4.  We will create an array of doubles called multiples and set it equal to a new array of doubles with the size of length.
        var multiples = new double[length];
        //Next, I will use a for loop to iterate through the array and fill it with the multiples of the number(3).  We will use the index of the array to determine which multiple we are on.  For example, if we are on the first index (0), we will multiply the number by 1 (0 + 1).  If we are on the second index (1), we will multiply the number by 2 (1 + 1).  This will continue until we reach the end of the array.
        for (var i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        //Finally, I will return the array of multiples o f3 which should return (3, 6, 9, 12, 15) for the example of MultiplesOf(3, 5).

        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To begin, I want to rotate the list to the right by the amount.  I will use the GetRange method as mentioned in the hints to get the last 'amount' elements of the list and store them in a new list called lastElements.
        List<int> lastElements = data.GetRange(data.Count - amount, amount);

        // Next, I will use the GetRange method again to get the remaining elements in the list by couning them, and store them in a new list called remainingElements.

        List<int> remainingElements = data.GetRange(0, data.Count - amount);

        // Then, I will clear the original data list, add the lastElements to the data list followed by the remainingElements similar to the example in the hints page.
        data.Clear();

        data.AddRange(lastElements);

        data.AddRange(remainingElements);

    }
}
