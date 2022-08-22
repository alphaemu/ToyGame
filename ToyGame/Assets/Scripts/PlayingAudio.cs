using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingAudio : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource jumpSound; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            jumpSound.Play(); 
        }
 
    }
}
