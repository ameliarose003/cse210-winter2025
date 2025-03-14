using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        Order aliceOrder = new Order();
        Address alice = new Address();
        alice.SetAddress("123 Maple Street", "Springfield", "IL", "USA");
        Customer c1 = new Customer("Alice Brown");
        Products aliceProd1 = new Products("Stickers", 333, 2, 10);
        aliceOrder.SetProduct(aliceProd1);
        Products aliceProd2 = new Products("Color Pencils", 386, 7, 1);
        aliceOrder.SetProduct(aliceProd2);
        string aliceAddress = alice.MakeAddress();
        Console.WriteLine(c1.PersonalShippingInfo(aliceAddress));
        Console.WriteLine($"Product price: {aliceOrder.GetTotalPrice()}");
        Console.WriteLine($"Shipping cost: {aliceOrder.GetShippingCost(alice)}");
        Console.WriteLine($"Order total: {aliceOrder.GetTotalAndShippingCost(alice)}");
        aliceOrder.GetPackageLabel();

        Order bryanOrder = new Order();
        Address bryan = new Address();
        bryan.SetAddress("789 Pine Road", "Anytown", "TX", "USA");
        Customer c2 = new Customer("Bryan Evan");
        Products bryanProd1 = new Products("Birthday Cards", 211, 20, 2);
        bryanOrder.SetProduct(bryanProd1);
        Products bryanProd2 = new Products("Birthday Gift Card", 599, 25, 4);
        bryanOrder.SetProduct(bryanProd2);
        Console.WriteLine(c2.PersonalShippingInfo(bryan.MakeAddress()));
        Console.WriteLine($"Product price: {bryanOrder.GetTotalPrice()}");
        Console.WriteLine($"Shipping cost: {bryanOrder.GetShippingCost(bryan)}");
        Console.WriteLine($"Order total: {bryanOrder.GetTotalAndShippingCost(bryan)}");
        bryanOrder.GetPackageLabel();

    }
}