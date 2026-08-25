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

            #region Q5) a)
            //What is a Partial Class?

            /*
             * Is a class that can be split across multiple files.
             * The partial keyword allows you to define different parts of the same class in separate .cs files, which are then combined by the compiler into a single class.
             * One class, multiple files. The compiler combines all parts into a single class.
             */
            #endregion

            #region Q5) b)
            //Why would a developer split one class into multiple files?

            /*
             * Keep auto-generated code separate from custom code.
             * Multiple developers can work on the same class simultaneously.
             * Make large classes more manageable and readable.
             */
            #endregion

            #region Q5) c)
            //What is a Partial Method?

            /*
             * Is a method that is defined in one part of a partial class and optionally implemented in another part. 
             * If the method is not implemented, the compiler removes all calls to it and does not generate any code for it.
             *  "Optional method that is only included in the final code if it's implemented".
             */
            #endregion

            #region Q5) d)
            //What happens if a declared partial method has no implementation?

            /*
             * The method is completely removed by the compiler. No code is generated, and no calls to the method are executed.
             * If a partial method has no implementation, it's as if it never existed. The compiler removes the declaration and all calls to it. 
             */
            #endregion

            #region Part 2) Q1)
            //Demonstrate the difference between assigning one object variable to another and creating an actual copy.

            //// Create an address
            //DeliveryAddress address01 = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            ////1. Create Original Shipment
            //StandardShipment shipment01 = new StandardShipment("SH001", "Laptop", 3, 80, address01);

            //Console.WriteLine("--- Original Shipment ---");
            //shipment01.PrintShipment();
            //Console.WriteLine();


            ////2. Assign 
            //Shipment shipment02 = shipment01;

            //Console.WriteLine($"Shipment01 Description: {shipment01.Description}");
            //Console.WriteLine($"Shipment02 Description: {shipment02.Description}");
            //Console.WriteLine($"Same object? {object.ReferenceEquals(shipment01, shipment02)}");

            //// Modify shipment2
            //shipment02.Description = "Gaming Laptop";
            //shipment02.Weight = 5;

            //Console.WriteLine($"Shipment01 Description: {shipment01.Description}");  // Changed
            //Console.WriteLine($"Shipment02 Description: {shipment02.Description}"); // Changed!
            //Console.WriteLine($"Shipment01 Weight: {shipment01.Weight}");            // Changed!
            //Console.WriteLine($"shipment02 Weight: {shipment02.Weight}");          // Changed!
            //Console.WriteLine($"Same object? {object.ReferenceEquals(shipment01, shipment02)}");
            //Console.WriteLine();
            //Console.WriteLine("Both changed! Because they are point to the same object.");
            //Console.WriteLine();


            //// 3. Copy(): creates a new independent object

            //// Reset shipment01 data
            //shipment01.Description = "Laptop";
            //shipment01.Weight = 3;

            //// Creates a new independent copy
            //Shipment shipment03 = shipment01.CopyShipment();

            //Console.WriteLine($"Shipment01 Description: {shipment01.Description}");
            //Console.WriteLine($"Shipment03 Description: {shipment03.Description}");
            //Console.WriteLine($"Same object? {object.ReferenceEquals(shipment01, shipment03)}");

            //// Modify the shipment03
            //shipment03.Description = "Business Laptop";
            //shipment03.Weight = 7;

            //Console.WriteLine($"Shipment01 Description: {shipment01.Description}");  // Still the same!
            //Console.WriteLine($"Shipment03.Description: {shipment03.Description}");          //Changed!
            //Console.WriteLine($"Shipment01 Weight: {shipment01.Weight}");            // Still the same!
            //Console.WriteLine($"Shipment03 Weight: {shipment03.Weight}");                    // Changed!
            //Console.WriteLine($"Same object? {object.ReferenceEquals(shipment01, shipment03)}");
            //Console.WriteLine();
            //Console.WriteLine("Shipment01 is unchanged! Because they are independent copies.");
            //Console.WriteLine();

            #endregion

            #region Part 2) Q2)
            // Create an address
            //DeliveryAddress address = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //// Create Original Shipment

            //StandardShipment shipment01 = new StandardShipment("SH001", "Laptop", 3, 80, address);

            //shipment01.PrintShipment();
            //Console.WriteLine();

            //// Create Shallow Copy using MemberwiseClone()
            //Shipment shipment02 = shipment01.ShallowCopy();

            //Console.WriteLine($"Shipment01 object and Shipment02 object are different? {!object.ReferenceEquals(shipment01, shipment02)}");
            //Console.WriteLine($"Same Address object? {object.ReferenceEquals(shipment01.Destination, shipment02.Destination)}");
            //Console.WriteLine();

            //// Demonstrate: Changing address through copy affects original

            //Console.WriteLine($"Shipment01 Address: {shipment01.Destination.GetFullAddress()}");
            //Console.WriteLine($"Shipment02 Address: {shipment02.Destination.GetFullAddress()}");

            //// Modify the address in shipment02
            //// DeliveryAddress is a struct, so we need to create a new one
            //DeliveryAddress newAddress = new DeliveryAddress("Alexandria", "Corniche", 20);
            //shipment02.Destination = newAddress;

            //Console.WriteLine("After modifying shipment02's address:");
            //Console.WriteLine($"shipment01 Address: {shipment01.Destination.GetFullAddress()}"); //Changed!
            //Console.WriteLine($"shipment02 Address: {shipment02.Destination.GetFullAddress()}");
            //Console.WriteLine();
            //Console.WriteLine($"Same Address object? {object.ReferenceEquals(shipment01.Destination, shipment02.Destination)}");
            //Console.WriteLine();
            //Console.WriteLine("The shipment01 shipment's address is also affected!");
            //Console.WriteLine("They share the same DeliveryAddress object.");
            //Console.WriteLine();

            //DeliveryAddress is a struct (value type), so it was copied independently.
            // Since DeliveryAddress is a struct, assigning a new address creates a copy.
            // The original is not affected because DeliveryAddress is a struct
            #endregion

            #region Part2) Q3)
            //// Create an address
            //DeliveryAddress address = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //// Create Original Shipment
            //StandardShipment shipment01 = new StandardShipment("SH001", "Laptop", 3, 80, address);
            //shipment01.PrintShipment();
            //Console.WriteLine();

            //// Create Deep Copy
            //Shipment shipment02 = shipment01.DeepCopy();

            //Console.WriteLine($"Shipment01 Address: {shipment01.Destination.GetFullAddress()}");
            //Console.WriteLine($"Shipment02 Address: {shipment02.Destination.GetFullAddress()}");
            //Console.WriteLine($"Same DeliveryAddress object? {object.ReferenceEquals(shipment01.Destination, shipment02.Destination)}");
            //Console.WriteLine();


            //// Create a new address for the copy
            //DeliveryAddress newAddress = new DeliveryAddress("Giza", "Pyramids Street", 10);
            //shipment02.Destination = newAddress;

            //Console.WriteLine($"Shipment01 Address: {shipment01.Destination.GetFullAddress()}"); // Cairo (UNCHANGED!)
            //Console.WriteLine($"Shipment02 Address: {shipment02.Destination.GetFullAddress()}"); // Giza (CHANGED!)
            //Console.WriteLine($"Same DeliveryAddress object? {object.ReferenceEquals(shipment01.Destination, shipment02.Destination)}");
            //Console.WriteLine();

            #endregion

            #region Part 2) Q5) & Q6)

            // The static constructor runs BEFORE any of this code executes
            // Even though we haven't accessed any static members yet,
            // the static constructor will run when the first instance is created

            // Create an address
            DeliveryAddress address = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            // CREATE FIRST SHIPMENT
            Console.WriteLine("--- Creating Shipment 1 ---");
            StandardShipment shipment1 = new StandardShipment("SH001", "Laptop", 3, 80, address);
            Console.WriteLine();

            // CREATE SECOND SHIPMENT
            Console.WriteLine("--- Creating Shipment 2 ---");
            ExpressShipment shipment2 = new ExpressShipment("SH002", "Phone", 2, 60, address, 30);
            Console.WriteLine();

            // CREATE THIRD SHIPMENT
            Console.WriteLine("--- Creating Shipment 3 ---");
            InternationalShipment shipment3 = new InternationalShipment("SH003", "TV", 8, 120, address, "Germany", 100);
            Console.WriteLine();

            Console.WriteLine($"Total Shipments Created: {Shipment.TotalShipmentsCreated}");
            Console.WriteLine($"Initialization Time: {Shipment.InitializationTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine();

            int total = Shipment.GetTotalShipmentsCreated();
            Console.WriteLine($"Total Shipments Created : {total}");

            //Also works through the property
            Console.WriteLine($"Via property: {Shipment.TotalShipmentsCreated}");
            #endregion
        }
    }
}
