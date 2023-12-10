using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsInput;

namespace Type
{
    class prog
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://humanbenchmark.com/tests/typing");

            // Lekérdezzük az összes "myClass" osztállyal rendelkező elemet
            var elements = driver.FindElements(By.ClassName("incomplete"));

            // Iterálunk az elemeken, és kiírjuk a tartalmukat
            string szoveg = "";
            foreach (IWebElement element in elements)
            {
                if (element.Text == "" || element.Text == null || element.Text == string.Empty)
                    szoveg += " ";
                else
                    szoveg += element.Text;
            }
            InputSimulator input = new InputSimulator();

            Console.WriteLine(szoveg);

            input.Keyboard.TextEntry(szoveg);

            Console.ReadKey();

            driver.Quit();
        }
    }
}