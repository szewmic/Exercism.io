using System;
using System.Linq;

public class SimpleCipher
{
    private string _key;
    private Random drawer = new Random();
    public SimpleCipher()
    {
        // Key = RandomString(100);
        Key = "aaaaaaaaaaaaaaaaaa";
    }
    public string RandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[drawer.Next(s.Length)]).ToArray());
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }
    
    public string Key 
    {
        get
        {
            return _key;
        }
        set
        {
            _key = value;
        }
    }

    public string Encode(string plaintext)
    {
        return String.Concat(plaintext.Select((s, i) => s += _key[i]));
    }

    public string Decode(string ciphertext)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

}