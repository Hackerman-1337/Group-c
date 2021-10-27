using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Behaviour : MonoBehaviour
{
    public float turnSpeed = 300f;
    public float moveSpeed = 10f;

    //public GameObject _Shield_Object;
    //public Carrying _Shield_Object;

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.SetActive(true);
    }


    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        // _Shield_Object.shieldActive = true;
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
    }
}
