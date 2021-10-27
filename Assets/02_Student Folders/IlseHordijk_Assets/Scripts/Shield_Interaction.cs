using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Interaction : MonoBehaviour
{
    public Carrying MyCarry;
    // Start is called before the first frame update
    void Start()
    {

        MyCarry.shieldActive = true;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        { // toggle
            //MyCarry.SetActive(false);
            MyCarry.shieldActive = !MyCarry.shieldActive;
            //shieldActive = !shieldActive;
            // Object_Carry.SetActive(false);
            //Object_Carry.shieldActive = !Object_Carry.shieldActive;
        } //if


    }
}
