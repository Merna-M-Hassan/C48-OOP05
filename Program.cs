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

            #region Q2) a)
            // What is a Shallow Copy?

            /*
             * Creates a new independent object and take a copy for all fields and paste them in the new independent object.
             * If the field is a value type it takes a copy of the data itself (fields values), if the field is a reference type it takes a copy from its reference (memory address) .
             * If a nested object exists, after copying the new object will refer to the same memory address/reference of the nested object, and any modyfing occur in nested object of the old object or copied object, will affect each other.
             * 
             * Shallow Copy:  is a copy of an object where only the top-level fields are copied. 
             * If the object contains references to other objects, a shallow copy copies the references (memory addresses) to those objects, not the objects themselves.
             */
            #endregion

            #region Q2) b)
            //What is a Deep Copy?

            /*
             * Creates new object, copy all top-level object data to the new created one, if there is a second-level object (nested object) data is also copied.
             * A deep copy creates a new object and recursively copies all nested objects. The original and the copy are completely independent. 
             * 
             *Is a copy of an object where all data is copied, including the objects that the original object references. 
             *Every nested object is also duplicated, creating a completely independent copy with no shared data.
             */
            #endregion

            #region Q2) c)
            //What happens to reference-type members when a shallow copy is created?

            /*
             * Their references (memory addresses) are copied. This means both the original and the copy share the same reference type objects.
             * If you modify a reference-type member through a shallow copy, the original object is also modified because they share the same reference.
             */
            #endregion

            #region Q2) d)
            //What happens to reference-type members when a Deep Copy is created?

            /*
             * Reference type members are completely copied, new instances are created for all reference type objects, creating a completely independent copy with no shared references.
             * Reference type members are completely copied, new independent objects are created for all reference types, ensuring no sharing between original and copy.
             */
            #endregion

            #region Q2) e)
            //Give one situation where Deep Copy would be safer than Shallow Copy.

            /*
             * Deep copy is safer than shallow copy when need to modify a copy without affecting the original.
             */
            #endregion


        }
    }
}
