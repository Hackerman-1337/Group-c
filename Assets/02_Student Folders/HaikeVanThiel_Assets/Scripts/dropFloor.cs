using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropFloor : MonoBehaviour
{
	bool startTimer;
	float timer;  
	public Material materialOrange;
	public Material materialRed;
	
    // Start is called before the first frame update
    void Start()
    {
       	startTimer = false; 
       	timer = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
		if (timer > -1.0f && startTimer){
			timer -= Time.deltaTime;  
			if (timer < 2.0f)
			{
				if (timer >= 1.0f)
					GetComponent<MeshRenderer>().material = materialOrange;
				else if (timer < 1.0f && timer > 0.0f)
					GetComponent<MeshRenderer>().material = materialRed;
				else
					Destroy(this.gameObject);;
			}
		
		}
			 
    }
    
	void OnTriggerEnter(Collider other)
	{
		startTimer = true;
	}
}
