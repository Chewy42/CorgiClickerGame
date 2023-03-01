using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FartCounter : MonoBehaviour
{

    public Text fartCounterText;
    public Farts Farts;

    void Start()
    {
        ResetFartCount();
    }

    public void ResetFartCount()
    {
        Farts.setFartCount(0);
        fartCounterText.text = Farts.getFartCount().ToString();
    }
    
    public void UpdateFartCounter()
    {
        fartCounterText.text = Farts.getFartCount().ToString();
    }
    
    
}
