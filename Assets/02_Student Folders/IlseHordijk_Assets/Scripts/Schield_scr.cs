using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schield_scr : MonoBehaviour
{
    public float turnSpeed = 300f;
    //public float moveSpeed = 10f;

    [Tooltip("Frequency at which the item will move up and down")]
    public float verticalBobFrequency = 1f;
    [Tooltip("Distance the item will move up and down")]
    public float bobbingAmount = 0.3f;
    [Tooltip("Sound played on pickup")]
    public AudioClip pickupSFX;
    [Tooltip("VFX spawned on pickup")]
    public GameObject pickupVFXPrefab;

    Vector3 m_StartPosition;


    //public GameObject MyToggle;
    public ShieldToggle MyToggle;

    // Start is called before the first frame update
    void Start()
    {
        m_StartPosition = transform.position;
        //MyToggle.SetActive(true);
    }


    void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.red;
       // MyToggle.thingActive = true;
        //MyToggle.SetActive(true);
        MyToggle.shield_found = true;
        Destroy(gameObject);
        if (pickupSFX)
        {
            AudioUtility.CreateSFX(pickupSFX, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

        float bobbingAnimationPhase = ((Mathf.Sin(Time.time * verticalBobFrequency) * 0.5f) + 0.5f) * bobbingAmount;
        transform.position = m_StartPosition + Vector3.up * bobbingAnimationPhase;
    }
}
