using System;


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 6, 36, 37);

        Scripture scripture = new Scripture("(36) Look unto me in every thought; doubt not, fear not. (37) Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven. Amen.");

        Word hide = new Word();
        Console.WriteLine("Press enter to hide words for easier memorizing or type in 'quit' to end.");
        Console.WriteLine(reference.GetDisplayContent(scripture));
        string action = Console.ReadLine();
        while (action == "" && action.ToLower() != "quit")
        {

            if (scripture.IsAllHidden())
            {
                Console.WriteLine("All words have been hidden. I hope you're ready for the test!");
                break;
            }
            scripture.RandomHideWord(hide, 3);
            Console.Clear();
            Console.WriteLine("Press enter to hide words for easier memorizing or type in 'quit' to end.");
            Console.WriteLine(reference.GetDisplayContent(scripture));

            action = Console.ReadLine();
        }
    }
}