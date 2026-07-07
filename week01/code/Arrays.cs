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


        // We would create an initial empty list with the size of the length parameter given. 
        // We would also create a double (currentMultiple) which we will initialize with the number parameter. 
        // At each iteration, we will update the list in the currentindex(determind by our loop), and then increase currentMultiple by the number parameter
        double[] output = new double[length];
        double currentMultiple = number;

        for(var num = 0; num < length; num++)
        {
            output[num] = currentMultiple;
            currentMultiple += number;
        }


        return output; // replace this return statement with your own
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

        // First we would create two new lists (subsection1, subsection2). The first list(subsection1) will splice the end part of the data List, while the second list(subsection2) will splice the first part.
        // To modify the initial list, we will clear all the values in it, then, update it (in the new order, that is subsection1 first, and then subsection2) using the AddRange Method



        List<int> subsection1 = data.GetRange(data.Count - amount, amount);
        List<int> subsection2 = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(subsection1);
        data.AddRange(subsection2);
    }
}
