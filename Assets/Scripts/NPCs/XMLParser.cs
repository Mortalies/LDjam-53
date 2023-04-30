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
    
    public Dictionary<int, string> ParseXmlFile(TextAsset file)
    {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
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
            phrases.Add(0, questionText.InnerText);
            phrases.Add(1, answer.InnerText);
            
        }
        return phrases;
    }


}
