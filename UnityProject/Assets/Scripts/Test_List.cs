using System.Collections.Generic;
using UnityEngine;

public class Test_List : MonoBehaviour
{
    #region AutoGenerateBindFields
    [SerializeField] private UnityEngine.UI.Button mButton;
    [SerializeField] private UnityEngine.UI.Text mText;
    [SerializeField] private UnityEngine.UI.Image mImage;
    #endregion
   


    public List<int> myList = new List<int>();
}
