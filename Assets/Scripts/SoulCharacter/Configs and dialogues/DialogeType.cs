using UnityEngine.UIElements.Experimental;

public struct Message
{
    //public DialogueType dialogueType;
    public string value;
    public string name;
    public Message(string _value, string _name)
    {
        value = _value;
        name = _name;
        //dialogueType = type;
    }
}
public enum DialogueType
{
    Player,
    Soul
}
