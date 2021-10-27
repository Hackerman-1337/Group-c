
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPad : MonoBehaviour
{

    public string password = "1432";
    private string userInput = "";

    [SerializeField]
    GameObject door;

    public AudioClip click;
    public AudioClip open;
    public AudioClip no;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    

    public void ButtonClicked(string number)
    {
        userInput += number;
        audioSource.PlayOneShot(click);
        if (userInput.Length >= 4)
        {
            if (userInput == password)
            {
                Debug.Log("EntryAllowed");
                audioSource.PlayOneShot(open);
                door.transform.position -= new Vector3(0, 10, 0);

            }
            else
            {
                Debug.Log("NO");
                userInput = "";
                audioSource.PlayOneShot(no);
            }
            
        }    
    }
    
}


