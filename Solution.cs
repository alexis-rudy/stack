using System;
using System.Collections.Generic;

public class BrowserNavigation
{
    private Stack<string> backStack;
    private Stack<string> forwardStack;

    public void VisitNewPage(string page)
    {
        Console.WriteLine($"Visiting: {page}");
        backStack.Push(page);
        forwardStack.Clear(); // Clear forward stack since we are visiting a new page
    }

    public void GoBack()
    {
        if (backStack.Count > 1) // Ensure there is a page to go back to
        {
            string currentPage = backStack.Pop();
            forwardStack.Push(currentPage);
            Console.WriteLine($"Went back to: {backStack.Peek()}");
        }
        else
        {
            Console.WriteLine("No more pages to go back to.");
        }
    }

    public void GoForward()
    {
        if (forwardStack.Count > 0) // Ensure there is a page to go forward to
        {
            string page = forwardStack.Pop();
            backStack.Push(page);
            Console.WriteLine($"Went forward to: {page}");
        }
        else
        {
            Console.WriteLine("No more pages to go forward to.");
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Browsing History:");
        foreach (var page in backStack)
        {
            Console.WriteLine(page);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BrowserNavigation browser = new BrowserNavigation();
        browser.VisitNewPage("Page1");
        browser.VisitNewPage("Page2");
        browser.GoBack();
        browser.VisitNewPage("Page3");
        browser.ShowHistory(); // Should show Page3 and Page1
    }
}