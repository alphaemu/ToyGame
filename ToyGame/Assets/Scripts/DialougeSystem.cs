using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeSystem : MonoBehaviour
{
    public Text dialogue1;
    public Text dialogue2; 

    private bool isDialougeChecked;
    private bool character1;
    private bool character2; 

    // Start is called before the first frame update
    void Start()
    {
        dialogue1.gameObject.SetActive(false);
        dialogue2.gameObject.SetActive(false);
        isDialougeChecked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isDialougeChecked == true)
        {
            if (character1 == true)
            {
                dialogue1.gameObject.SetActive(true);
                isDialougeChecked = false;
            }

            if(character2 == true)
            {
                dialogue2.gameObject.SetActive(true);
                isDialougeChecked = false;
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character1")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            character1 = true; 


        }

        if (other.gameObject.tag == "Character2")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            character2 = true;


        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Character1")
        {
            //Debug.Log("Press E to start dialouge");
            dialogue1.gameObject.SetActive(false);
            isDialougeChecked = false;
            character1 = false;


        }

        if (other.gameObject.tag == "Character2")
        {
            //Debug.Log("Press E to start dialouge");
            dialogue2.gameObject.SetActive(false);
            isDialougeChecked = false;
            character2 = false;


        }
    }




}
