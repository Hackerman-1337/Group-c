using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldToggle : MonoBehaviour
{
    public bool thingActive;
    public GameObject _Thingy;
    public GameObject DW;
    public bool shield_found;
    public Damageable person;
    [Tooltip("Sound played on pickup")]
    public AudioClip pickupSFX;
    private bool been;
   

    // Start is called before the first frame update
    void Start()
    {
        thingActive = true;
        shield_found = false;
        _Thingy.SetActive(false);
        been = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shield_found)
        {
            DW.SetActive(false);
            if (Input.GetKeyDown(KeyCode.T) || !been)
            {
                been = true;
                if (Input.GetKeyDown(KeyCode.T))
                    thingActive = !thingActive;

                if (!thingActive)
                {
                    _Thingy.SetActive(false);
                    person.damageMultiplier = 2f;
                    if (pickupSFX)
                    {
                        AudioUtility.CreateSFX(pickupSFX, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
                    }
                }
                else
                {
                    _Thingy.SetActive(true);
                    person.damageMultiplier = 0.4f;
                    if (pickupSFX)
                    {
                        AudioUtility.CreateSFX(pickupSFX, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
                    }
                }
            }
        }
        
    }
}
