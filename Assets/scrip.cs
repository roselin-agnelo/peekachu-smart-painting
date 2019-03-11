using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrip : MonoBehaviour
{
    public Text Textbox;
    // Start is called before the first frame update
    public void plusClick()
    {
        Debug.Log("Here");
        Textbox.text= "1";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
