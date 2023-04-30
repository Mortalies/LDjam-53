using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;
using Microsoft.Win32.SafeHandles;
using UnityEditor;

public class XMLParser : MonoBehaviour
{
    
    public Dictionary<DialogeType, string> ParseXmlFile(TextAsset file)
    {
        Dictionary<DialogeType, string> phrases = new Dictionary<DialogeType, string>();
        string data = file.text;
        string totVal = "";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(new StringReader(data));
        string xmlPathPattern = "//Questions/Question";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);
        foreach (XmlNode node in myNodeList)
        {
            XmlNode questionText = node.FirstChild;
            XmlNode answer = questionText.NextSibling;
            totVal += "questionText: " + questionText.InnerText + "\n answer: " + answer.InnerText + "\n\n";
            phrases.Add(DialogeType.Player, questionText.InnerText);
            phrases.Add(DialogeType.Soul, answer.InnerText);
            
        }
        return phrases;
    }


}
