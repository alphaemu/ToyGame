using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeSystem : MonoBehaviour
{
    // Teddy bear dialogues 
    public Text teddyBearDialogue1;
    public Text teddyBearDialogue2;
    public Text teddyBearDialogue3;

    // Penguin dialgoues
    public Text penguinDialogue1;
    public Text penguinDialogue2;

    // Gremlin Dialogues 
    public Text gremlinDialogue;


    private bool isDialougeChecked;
    private bool character1;
    private bool character2;

    // Teddy Bear bools
    private bool teddyBear1;
    private bool teddyBear2;
    private bool teddyBear3;

    // Penguin bools
    private bool penguin1;
    private bool penguin2;

    // Gremlin bools
    private bool gremlin; 


    // Start is called before the first frame update
    void Start()
    {
        
        isDialougeChecked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isDialougeChecked == true)
        {
            if (teddyBear1 == true)
            {
                teddyBearDialogue1.gameObject.SetActive(true);
                isDialougeChecked = false;
            }

            if(penguin1 == true)
            {
                penguinDialogue1.gameObject.SetActive(true);
                isDialougeChecked = false;
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TeddyBear")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear1 = true; 
        }

        if (other.gameObject.tag == "TeddyBear2")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear2 = true;
        }

        if (other.gameObject.tag == "TeddyBear3")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear3 = true;
        }


        if (other.gameObject.tag == "Penguin1")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            penguin1 = true;


        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "TeddyBear1")
        {
            //Debug.Log("Press E to start dialouge");
            teddyBearDialogue1.gameObject.SetActive(false);
            isDialougeChecked = false;
            teddyBear1 = false;


        }

        if (other.gameObject.tag == "Penguin1")
        {
            //Debug.Log("Press E to start dialouge");
            penguinDialogue1.gameObject.SetActive(false);
            isDialougeChecked = false;
            penguin1 = false;


        }
    }




}
