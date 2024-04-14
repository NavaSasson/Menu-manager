namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            InterfaceMenuTest interfaceMenuTest = new InterfaceMenuTest();
            DelegateMenuTest delegateMenuTest = new DelegateMenuTest();

            interfaceMenuTest.Show();
            delegateMenuTest.Show();
        }
    }
}