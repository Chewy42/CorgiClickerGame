using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farts : MonoBehaviour
{
    private float fartCount;
    private float fartsPerClick;
    private float fartsPerSecond;
    private int totalClicks;

    public FartCounter FartCounter;
    void Start()
    {
        FartCounter.ResetFartCount();
        StartCoroutine(addFartsPerSecond());
        fartsPerClick = 1;
    }

    public float getFartCount()
    {
        return fartCount;
    }
    
    public void setFartCount(float newFartCount)
    {
        fartCount = newFartCount;
        FartCounter.UpdateFartCounter();
    }
    
    public void addFartCount(float fartCountToAdd)
    {
        fartCount += fartCountToAdd;
        
        if (fartCount < 0)
            fartCount = 0;
        
        FartCounter.UpdateFartCounter();
    }
    
    public void setFartsPerClick(float newFartsPerClick)
    { 
        fartsPerClick = newFartsPerClick;
    }

    public float getFartsPerClick()
    {
        return fartsPerClick;
    }
    
    public void setFartsPerSecond(float newFartsPerSecond)
    {
        fartsPerSecond = newFartsPerSecond;
    }
    
    public float getFartsPerSecond()
    {
        return fartsPerSecond;
    }
    
    //create coroutine that runs every second and adds farts per second
    IEnumerator addFartsPerSecond()
    {
        while (true)
        {
            addFartCount(fartsPerSecond);
            yield return new WaitForSeconds(1);
        }
    }

    public void addToTotalClicks()
    {
        totalClicks++;
    }
    
    public int getTotalClicks()
    {
        return totalClicks;
    }

}
