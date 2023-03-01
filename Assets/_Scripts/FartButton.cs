using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FartButton : MonoBehaviour
{
    public Farts Farts;
    public float growAmount = 1f; // How much the sprite will grow when clicked
    public float growTime = 0.5f; // How long the growth animation will take
    private bool isGrowing = false;
    private Vector3 startingScale; // The sprite's starting scale


    void Start()
    {
        startingScale = transform.localScale;
    }

    public void OnFartButtonPressed()
    {
        Farts.addFartCount(Farts.getFartsPerClick());
        Farts.addToTotalClicks();
        
        if (!isGrowing)
        {
            isGrowing = true;
            startingScale = transform.localScale;
            StartCoroutine(GrowSprite());   
        }
    }
    
    private IEnumerator GrowSprite()
    {
        float timer = 0f;
        while (timer < growTime)
        {
            float t = timer / growTime;
            transform.localScale = Vector3.Lerp(startingScale, startingScale + Vector3.one * growAmount, t);
            timer += Time.deltaTime;
            yield return null;
        }
        transform.localScale = startingScale + Vector3.one * growAmount;
        //reset scale
        timer = 0f;
        while (timer < growTime)
        {
            float t = timer / growTime;
            transform.localScale = Vector3.Lerp(startingScale + Vector3.one * growAmount, startingScale, t);
            timer += Time.deltaTime;
            yield return null;
        }
        transform.localScale = startingScale;
        isGrowing = false;
    }
}
