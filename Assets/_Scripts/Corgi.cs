using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    public Farts Farts;

    void Update()
    {
        if (Farts.getTotalClicks() % 20 == 0 && Farts.getTotalClicks() != 0)
            SpinCorgi();
    }
    
    //spin corgi over the span of 500 ms
    void SpinCorgi()
    {
        StartCoroutine(SpinCorgiCoroutine());
    }
    
    //spin corgi once over 500ms then stop
    IEnumerator SpinCorgiCoroutine()
    {
        float time = 0;
        float duration = 0.5f;
        float startRotation = transform.rotation.z;
        float endRotation = startRotation + 360;
        while (time < duration)
        {
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(startRotation, endRotation, time / duration));
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = Quaternion.Euler(0, 0, endRotation);
    }
}
