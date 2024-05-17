using OpenQA.Selenium;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja przeglądarki Chrome
            IWebDriver driver = new OpenQA.Selenium.Edge.EdgeDriver();

            try
            {
                // Przejdź do strony Google
                driver.Navigate().GoToUrl("https://www.google.pl");

                // Znajdź pole wyszukiwania
                IWebElement searchBox = driver.FindElement(By.Name("q"));

                // Wpisz zapytanie do pola wyszukiwania
                searchBox.SendKeys("Selenium WebDriver");

                // Znajdź przycisk "Szukaj" i kliknij go
                searchBox.Submit();

                // Czekaj kilka sekund, aby zobaczyć wyniki (opcjonalnie)
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Wystąpił błąd: {e.Message}");
            }
            finally
            {
                // Zamknij przeglądarkę
                driver.Quit();
            }

        }
    }
}
