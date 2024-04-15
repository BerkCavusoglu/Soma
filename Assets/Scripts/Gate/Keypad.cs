using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public DoorController doorToOpen;
    public GameObject keypadUI;
    public Text passwordText;
    public string password;
    void Start()
    {

    }


    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            keypadUI.SetActive(true);
        }
    }
}
