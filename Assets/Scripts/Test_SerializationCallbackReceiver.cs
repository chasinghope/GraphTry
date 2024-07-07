using System;
using System.Collections.Generic;
using UnityEngine;

public class Test_SerializationCallbackReceiverMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver
{
    //Unity doesn't know how to serialize a Dictionary
    public Dictionary<int, string>  _myDictionary = new Dictionary<int, string>();

    public void OnBeforeSerialize()
    {

    }

    public void OnAfterDeserialize()
    {
        
        _myDictionary.Add(1, "one");
        _myDictionary.Add(2, "two");
        _myDictionary.Add(3, "three");
    }

    void OnGUI()
    {
        foreach (var kvp in _myDictionary)
            GUILayout.Label("Key: " + kvp.Key + " value: " + kvp.Value);
    }
}