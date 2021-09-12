using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealDisplayTime : MonoBehaviour
{

    private Text clockText;
    
    void Start (){
        clockText = GetComponent<Text>();
    }
    void Update()
    {
        System.DateTime time = System.DateTime.Now;

        clockText.text = time.ToString("HH:mm");
    }
}
