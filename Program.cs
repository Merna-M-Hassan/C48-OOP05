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

            #region Q3) a)
            //What is a static field, and how is it different from an instance field?

            /*
             * Static field: belongs to the class.
             *  For each creating new object, it contains a new copy of static field. Not shared, each new object has a new independent copt of the static field.
             *  Shared for all instance. 
             *  If need to access static field/member, access it through its belonging class.
             *  Static Field = "shared by all objects" (one copy per class) / "same for everyone"
             * 
             * Differs from an instance field, is the instance field belongs to each individual object (instance) of the class.
             * Instance Field = "belongs to each object" (one copy per object) / "different for each"
             */
            #endregion

            #region Q3) b)
            //What is a static method? Can a static method directly access instance members?

            /*
             * Static method / Class method: is a method that belongs to the class itself, not to any specific instance (object) of the class. It can be called without creating an object of the class.
             * Not need to make instance from the class to access its static method.
             * Access static method directly from its class name.
             * Belongs to its class, not to any object. Can only access what belongs to the class.
             * 
             * No, static method can not acess a non-static/ instance member. If need to access, make both of them static.
             *  Instatnce method: belongs to a specific object. Can access both class-level and object-level members.
             */
            #endregion

            #region Q3) c)
            //What is a static constructor, and when is it executed?

            /*
             * Static constructor: special constructorthat is called automatically to initialize the static members of a class before any static member is accessed or any instance is created. It belongs to the class itself, not to any specific object.
             * Implemented without access modifier. 
             * Can not call static constructor. So, it doesn't accept parameters.
             * It runs only one time, and run before first usage of its class (before creating any object of its class/before access any member inside the class/
             * before calling any static method/member).
             * As the initial configuration, only one time use and before any usage. 
             * Intialize all static members and fields. 
             * "Used to perform one-time intialization"
             * 
             * A static constructor is executed automatically at exactly one of these times:
             * Before the first static member is accessed and before the first instance is created.
             */
            #endregion

            #region Q3) d)
            //What is a static class? Can you create an object from a static class?

            /*
             * Is a class that cannot be instantiated and can only contain static members. 
             * It serves as a container for utility methods and shared data that don't require object state.
             * "A container for utility functions. Don't create objects, just use the methods directly".
             * 
             * A static class has no instance constructors and no instance data. It's designed to be a container for static methods and data only. 
             *  Can not create an object from a static class because it's designed to be a container for shared functionality, not a template for individual objects. 
             *  All members are static and belong to the class itself, not to any instance.
             */
            #endregion

            #region Q4) a)
            //What is an Extension Method?

            /*
             * Extend method: add new methods to existing types without modifying th eoriginal type or creating a new derived type.
             * Extend method without opening/modifying its class.
             */
            #endregion

            #region Q4) b)
            //What keyword must be used in the first parameter of an extension method?

            /*
             * this 
             */
            #endregion

            #region Q4) c)
            //Where must an extension method be declared?

            /*
             * In a static class as a static method.
             */
            #endregion

            #region Q4) d)
            //Can an extension method access private members of the class it extends?

            /*
             * No, Extension methods are just static methods in a static class. They are not part of the class they extend.
             * They operate at the same level of access as any external code.
             */
            #endregion
        }
    }
}
