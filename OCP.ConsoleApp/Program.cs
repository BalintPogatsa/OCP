namespace OCP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textButton = new Button() { Type = ContentType.Text, Content = "Click Me" };
            Console.WriteLine(textButton.RenderAsXml());
        }
    }
}
