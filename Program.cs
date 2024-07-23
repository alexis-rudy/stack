public class BrowserNavigation
{

    // Method to simulate visiting a new page
    public void VisitNewPage(string page)
    {
        // Implement this method
    }

    // Method to simulate going back to the previous page
    public void GoBack()
    {
        // Implement this method
    }

    // Method to simulate going forward to the next page
    public void GoForward()
    {
        // Implement this method
    }

    // Method to show the browsing history
    public void ShowHistory()
    {
        // Implement this method
    }
}
public static class ProgramTest
{
    public static void Run(){
    // Example usage of BrowserNavigation
    BrowserNavigation browser = new BrowserNavigation();

    // Test visiting new pages
    browser.VisitNewPage("https://www.google.com");
    browser.VisitNewPage("https://www.github.com");
    browser.VisitNewPage("https://www.microsoft.com");

    // Test going back
    browser.GoBack(); // Should go back to "https://www.github.com"
    browser.GoBack(); // Should go back to "https://www.google.com"

    // Test going forward
    browser.GoForward(); // Should go forward to "https://www.github.com"

    // Test showing browsing history
    browser.ShowHistory(); // Should display the browsing history

    // Add more test cases as needed
}
}
