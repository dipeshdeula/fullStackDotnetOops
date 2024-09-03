//Step 1: Declare a delegate
delegate int CalculateDelegate(int num);

namespace fullStackOops.Delegates
{

    //Delegates
    //A Delegates is a pointer to a method
    //But it is object-oriented, secured and type-safe than function pointer
    //that means, a delegate holds the address of a method which can be called using that delegates
    //for static method, delegate encapsulates method only
    //But for instance method, it encapsulates method and instance both
    //There are three steps involved while working with delegates
    //1. Declare a delegate
    //2. Create a delegate object or set a target method
    //3. Call the method using delegate object or invoke the delegate object

    
    internal class DelegateExample
    {
      
        static int number = 100;
        public static int Addition(int num)
        {
            number += num;
            return number;
        }

        public static int Multiply(int num)
        {
            number += num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }

        public static void Main(string[] args)
        {
            //static method doe't need instance to call
            Addition(20);
            Console.WriteLine(getNumber());

            //Step 2: Create a delegate object or set a target method
            CalculateDelegate c = new CalculateDelegate(Addition);
            CalculateDelegate c1 = new CalculateDelegate(Multiply);

            //step 3: Invoke a delegate
            c(10);
            Console.WriteLine(getNumber());
            c1(20);
            Console.WriteLine(getNumber());
            
        }


    }
}
