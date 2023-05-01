using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;
using Microsoft.Win32.SafeHandles;
using UnityEditor;

public class XMLParser
{
    
    public List<Message> ParseXmlFile(TextAsset file)
    {
        List<Message> messages = new List<Message>();
        string data = file.text;
        string totVal = "";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(new StringReader(data));
        string xmlPathPattern = "//Dialogue/Question";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);
        foreach (XmlNode node in myNodeList)
        {
            XmlNode name = node.FirstChild;
            XmlNode questionText = name.NextSibling;
            totVal += "questionText: " + questionText.InnerText + "\n answer: " + name.InnerText + "\n\n";
            messages.Add(new Message(questionText.InnerText, name.InnerText));

        }
        return messages;
    }


}
