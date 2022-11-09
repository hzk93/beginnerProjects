namespace beginnerProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is the main calling method below are all the classes\n");
            //mathsTable mathstable = new mathsTable();
            //mathstable.myTable();
            //DivideByZero dividebyzero = new DivideByZero();
            //dividebyzero.dividebyZ();
            calcHandlExcep calcHandlExcep = new calcHandlExcep();
            calcHandlExcep.calculator();

            
        }
    }
}