using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Data", menuName = "Dialogue Data")]
public class DialogueData : ScriptableObject 
{
    [SerializeField]private Dictionary<int, string> _phrases = new Dictionary<int, string>();
    [SerializeField]private TextAsset _textAsset;
    private XMLParser _xmlParser;
    private void OnEnable()
    {
        _xmlParser = new XMLParser();
        _phrases = _xmlParser.ParseXmlFile(_textAsset);
    }
}
