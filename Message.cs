//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

public class Message : MonoBehaviour
{
    string message;
    bool targetMessage;

    string chatMessage1;
    string chatMessage2;
    public Message(string message, bool targetMessage)
    {
        this.message = message;
        this.targetMessage = targetMessage;
    }
    public Message(string message1, string message2)
    {
        this.chatMessage1 = message1;
        this.chatMessage2 = message2;
    }

    public string getMessage()
    {
        return message;
    }

    public bool getTargetMessage()
    {
        return targetMessage;
    }


    public string getMessage1()
    {
        return chatMessage1;
    }

    public string getMessage2()
    {
        return chatMessage2;
    }


}

