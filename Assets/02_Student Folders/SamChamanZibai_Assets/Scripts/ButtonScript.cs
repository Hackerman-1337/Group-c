using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // Required when using Event data.

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    public int keypadNumber = 1;
    
    public UnityEvent KeypadClicked;

    void OnTriggerEnter(Collider Player)
    {
        KeypadClicked.Invoke();  
    }

}


