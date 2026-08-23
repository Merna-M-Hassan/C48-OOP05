namespace Assignment_9_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)  a)
            //What happens when you assign one object variable to another object variable?

            /*
             * It defers from reference type (like class object) and value type (like struct). 
             * 
             * If assign two classes with each others (two reference data type), their reference (memory address) will be the same / 
             * refer to the same object (memory address) in heap. When assign one class variable to another, the reference will be coppied, not the object.
             * Also modifying through one variable affects the other.
             * 
             * If assign two structs with each other (two value types), a new stack frame will be created and only the data (fields) will be copied.
             * They wil be two separate frame in struct with identical data values.
             *  If one of them is modified, the other not affected. Because they are completely independent coppies.
             */
            #endregion

            #region Q1)  b)
            //Does assigning one object to another create a new object? Explain.

            /*
             * In reference type case (like class): No new object is created. Instead, copying the reference (memory address) to the same object.
             * Both variables point to the same existing object.
             * 
             * In value type case (like struct): Yes, a new independent copy/stack frame is created. 
             * The entire data is copied.
             */
            #endregion

            #region Q1) c)
            //What is the difference between copying an object and copying its reference?

            /*
             * Copying object: means creating a new independent copy of the object with the same data.
             * 
             * Copying reference: means copying the memory address that points to where the object is located, not the object itself.
             */
            #endregion

        }
    }
}
