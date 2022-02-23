using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texts : MonoBehaviour
{
    public GameObject txColors;
    

    
    
    //Hide Texts
    void Start()
    {
        txColors.SetActive(false);
        
    }

    // Mouse on UI
    void OnMouseEnter()
    {
            txColors.SetActive(true);
    }

    void OnMouseExit()
    {
        txColors.SetActive(false);
    }
}
