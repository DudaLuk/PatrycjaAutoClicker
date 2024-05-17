using OpenQA.Selenium;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Browser_job();
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                }
                catch (Exception)
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromMinutes(5));
                    //jak zbanują czekamy 5 minut
                }

            }



            static void Browser_job()
            {
                // Inicjalizacja przeglądarki Chrome
                IWebDriver driver = new OpenQA.Selenium.Edge.EdgeDriver();

                try
                {
                    // Przejdź do strony Google
                    driver.Navigate().GoToUrl("https://www.shecodes.io/contests/urban-garden-challenge/contest_entries/patrycja-oosthuizen-polish-b3d6f284-7841-4f83-869e-66fac50854fd/preview");

                    // Znajdź pole wyszukiwania
                    //IWebElement searchBox = driver.FindElement(By.Name("q"));
                    IWebElement webElement = driver.FindElement(By.ClassName("btn-secondary"));
                    webElement.Click();
                    // Wpisz zapytanie do pola wyszukiwania
                    //searchBox.SendKeys("Selenium WebDriver");

                    // Znajdź przycisk "Szukaj" i kliknij go
                    //searchBox.Submit();

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
}
