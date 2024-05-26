using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject window;

    private bool _canOpen = false;
    
    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Submit") && _canOpen)
         {
            OpenWindow();
         }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            _canOpen = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            _canOpen = false;
        }
    }

    void OpenWindow()
    {
        window.SetActive(true);
    }
}
