using System;
using System.IO;

public static class TestHelper
{
    public static string CaptureConsoleOutput(Action action)
    {
        var originalOut = Console.Out;
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            action.Invoke(); // Invoke the action that contains the code with Console.WriteLine

            Console.SetOut(originalOut);
            return sw.ToString();
        }
    }
}