using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeSystem : MonoBehaviour
{
    // Teddy bear dialogues 
    public GameObject teddyBearDialogue1;
    public GameObject teddyBearDialogue1Part2; 
    public GameObject teddyBearDialogue2;
    public GameObject teddyBearDialogue3;

    // Penguin dialgoues
    public GameObject penguinDialogue1;
    public GameObject penguinDialogue2;

    // Gremlin Dialogues 
    public GameObject gremlinDialogue;

    // Interaction popups
    public GameObject notifBear1;
    public GameObject notifBear2;
    public GameObject notifBear3;
    public GameObject notifPenguin1;
    public GameObject notifPenguin2;
    public GameObject notifGremlin;

    // Player Location

    private bool isDialougeChecked;
    private bool character1;
    private bool character2;

    // Teddy Bear bools
    private bool teddyBear1;
    private bool teddyBear1part2; 
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
        // Dialogue = Invisible
        teddyBearDialogue1.SetActive(false);
        teddyBearDialogue1Part2.SetActive(false); 
        teddyBearDialogue2.SetActive(false);
        teddyBearDialogue3.SetActive(false);
        penguinDialogue1.SetActive(false);
        penguinDialogue2.SetActive(false);
        gremlinDialogue.SetActive(false);

        // Popups = Invisible
        notifBear1.SetActive(false);
        notifBear2.SetActive(false);
        notifBear3.SetActive(false);
        notifPenguin1.SetActive(false);
        notifPenguin2.SetActive(false);
        notifGremlin.SetActive(false);

        isDialougeChecked = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && isDialougeChecked == true)
        {
            if (teddyBear1 == true)
            {
                teddyBearDialogue1.SetActive(true);
                isDialougeChecked = false;
            }

            if (teddyBear1part2 == true)
            {
                teddyBearDialogue1Part2.SetActive(true);
                isDialougeChecked = false;
            }

            if (penguin1 == true)
            {
                penguinDialogue1.SetActive(true);
                isDialougeChecked = false;
            }

            if (gremlin == true)
            {
                gremlinDialogue.SetActive(true);
                isDialougeChecked = false;
            }

            if (teddyBear2 == true)
            {
                teddyBearDialogue2.SetActive(true);
                isDialougeChecked = false;
            }

            if (penguin2 == true)
            {
                penguinDialogue2.SetActive(true);
                isDialougeChecked = false;
            }

            if (teddyBear3 == true)
            {
                teddyBearDialogue3.SetActive(true);
                isDialougeChecked = false;
            }

        }
    }


    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "TeddyBear1")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear1 = true;
            notifBear1.SetActive(true);
        }

        if (other.gameObject.tag == "TeddyBear1Part2")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear1part2 = true;
        }

        if (other.gameObject.tag == "TeddyBear2")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear2 = true;
            notifBear2.SetActive(true);
        }

        if (other.gameObject.tag == "TeddyBear3")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            teddyBear3 = true;
            notifBear3.SetActive(true);
        }


        if (other.gameObject.tag == "Penguin1")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            penguin1 = true;
            notifPenguin1.SetActive(true);
        }

        if (other.gameObject.tag == "Penguin2")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            penguin2 = true;
            notifPenguin2.SetActive(true);


        }

        if (other.gameObject.tag == "Gremlin")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;
            gremlin = true;
            notifGremlin.SetActive(true);
        }
    }

   
    

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "TeddyBear1")
        {
            Debug.Log("Left Trigger for Teddy Bear 1");
            teddyBearDialogue1.SetActive(false);
            isDialougeChecked = false;
            teddyBear1 = false;
            notifBear1.SetActive(false);
        }

        if (other.gameObject.tag == "TeddyBear1Part2")
        {
            Debug.Log("Left Trigger for Teddy Bear 1");
            teddyBearDialogue1Part2.SetActive(false);
            isDialougeChecked = false;
            teddyBear1part2 = false;
        }

        if (other.gameObject.tag == "TeddyBear2")
        {
            teddyBearDialogue2.SetActive(false);
            isDialougeChecked = false;
            teddyBear2 = false;
            notifBear2.SetActive(false);
        }

        if (other.gameObject.tag == "TeddyBear3")
        {
            teddyBearDialogue3.SetActive(false);
            isDialougeChecked = false;
            teddyBear3 = false;
            notifBear3.SetActive(false);
        }

        if (other.gameObject.tag == "Penguin1")
        {
            penguinDialogue1.SetActive(false);
            isDialougeChecked = false;
            penguin1 = false;
            notifPenguin1.SetActive(false);
        }

        if (other.gameObject.tag == "Penguin2")
        {
            penguinDialogue2.SetActive(false);
            isDialougeChecked = false;
            penguin2 = false;
            notifPenguin2.SetActive(false);
        }

        if (other.gameObject.tag == "Gremlin")
        {
            gremlinDialogue.SetActive(false);
            isDialougeChecked = false;
            gremlin = false;
            notifGremlin.SetActive(false);
        }

    }

}
