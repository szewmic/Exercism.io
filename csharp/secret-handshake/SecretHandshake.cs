using System;
using System.Collections;
using System.Collections.Generic;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        List<string> handshakeSequence = new List<string>();

        string binary = Convert.ToString(commandValue, 2).PadLeft(5, '0');

        if (binary[4] == '1')
            handshakeSequence.Add("wink");
        if (binary[3] == '1')
            handshakeSequence.Add("double blink");
        if (binary[2] == '1')
            handshakeSequence.Add("close your eyes");
        if (binary[1] == '1')
            handshakeSequence.Add("jump");
        if (binary[0] == '1')
            handshakeSequence.Reverse();

        return handshakeSequence.ToArray();
    }
}
