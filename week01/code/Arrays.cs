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
        // Creates an array of the given length to hold the multiples
        // Loops from 1 to length, storing each multiple at index i - 1
        // Returns the completed array of multiples
        var result = new double[length];
        for (int i = 1; i <= length; i++)
        {
            result[i - 1] = number * i;
        }
            return result;
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
        // 1. Calculate the split point: data.Count - amount
        // 2. Extract the tail chunk (last 'amount' items) using GetRange
        // 3. Remove those same items from data using RemoveRange
        // 4. Insert the tail chunk at the front of data using InsertRange
        int splitPoint = data.Count - amount;
        List<int> tailChunk = data.GetRange(splitPoint, amount);
        data.RemoveRange(splitPoint, amount);
        data.InsertRange(0, tailChunk);
    }
}
