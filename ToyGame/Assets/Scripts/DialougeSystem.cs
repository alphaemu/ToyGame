using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialougeSystem : MonoBehaviour
{
    public Text dialogue1;

    private bool isDialougeChecked;

    // Start is called before the first frame update
    void Start()
    {
        dialogue1.gameObject.SetActive(false);
        isDialougeChecked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isDialougeChecked == true)
        {
            dialogue1.gameObject.SetActive(true);
            isDialougeChecked = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("Press E to start dialouge");
            isDialougeChecked = true;


        }
    }
}
