using System;

public static class HelloWorld
{
    public static string Hello()
    {
        throw new NotImplementedException(message());
    }

    public string message()
    {
        return "Hello, World!";
    }
}
