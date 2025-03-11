using System;

class Program
{
    static void Main(string[] args)
    {
        Comments c1CssGrid = new Comments("Bob", "Love the step-by-step approach! This makes coding a website seem so much less intimidating.");
        Comments c2CssGrid = new Comments("Alex Codewright", "This CSS tutorial is a game changer! The way you broke down flexbox and grid made everything so clear.");
        Video v1CssGrid = new Video("Learn To Use CSS Grid", "John Smith", 15);
        v1CssGrid._comments.Add(c1CssGrid.DisplayComment());
        v1CssGrid._comments.Add(c2CssGrid.DisplayComment());
        Console.WriteLine(v1CssGrid.DisplayVideo());

        Comments c1HtmlBasics = new Comments("Eli Websmith", "This HTML basics video is a perfect introduction to the language. Clear explanations and great examples!");
        Comments c2HtmlBasics = new Comments("Samantha Tagwell", "Finally, I understand how HTML works! Your breakdown of tags and structure made everything so accessible.");
        Video v1HtmlBasics = new Video("HTML Basics for Beginners", "Jordan Elements", 30);
        v1HtmlBasics._comments.Add(c1HtmlBasics.DisplayComment());
        v1HtmlBasics._comments.Add(c2HtmlBasics.DisplayComment());
        Console.WriteLine(v1HtmlBasics.DisplayVideo());

        Comments c1Javascript = new Comments("Alex Scriptor", "Awesome JavaScript breakdown! The explanations on closures and asynchronous functions were super clear.");
        Comments c2Javascript = new Comments("Nina Devlyn", "Really enjoyed this tutorial. The way you explained async/await has made my code much cleaner.");
        Video v1Javascript = new Video("JavaScript Essentials for Beginners", "Jordan Function", 45);
        v1Javascript._comments.Add(c1Javascript.DisplayComment());
        v1Javascript._comments.Add(c2Javascript.DisplayComment());
        Console.WriteLine(v1Javascript.DisplayVideo());

        Comments c1Node = new Comments("Sam Backend", "Great Node.js tutorial! Loved how you broke down event-driven programming and asynchronous operations.");
        Comments c2Node = new Comments("Jordan Async", "This video clarified a lot about Node's non-blocking architecture and callback patterns.");
        Video v1Node = new Video("Node.js Crash Course for Beginners", "Mia Express", 60);
        v1Node._comments.Add(c1Node.DisplayComment());
        v1Node._comments.Add(c2Node.DisplayComment());
        Console.WriteLine(v1Node.DisplayVideo());


    }
}