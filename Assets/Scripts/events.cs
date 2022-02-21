using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events : MonoBehaviour
{
   

    public void random()
    {
        // Random color
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void ChangePos(float xPos)
    {
        //Position 
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    public void ResizeCube(float sizeMultiplier)
    {
        //Scale
        transform.localScale = sizeMultiplier * Vector3.one;
    }
}
