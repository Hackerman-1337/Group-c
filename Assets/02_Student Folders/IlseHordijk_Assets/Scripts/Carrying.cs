using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrying : MonoBehaviour
{
    public bool shieldActive;
    //public GameObject _WP;
    
    // Start is called before the first frame update
    void Start()
    {
        shieldActive = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Q))
            shieldActive = !shieldActive;

        if (!shieldActive)
            _WP.SetActive(false);
        else
            _WP.SetActive(true);
        */
    }
}
