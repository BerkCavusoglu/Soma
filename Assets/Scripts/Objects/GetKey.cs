using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;

    public GameObject getKeyText;
    //public AudioSource doorSound;
    public GameObject activeCross;

    public bool keyTaken;
    public GameObject key;

  
    void Start()
    {
        keyTaken = false;
    }

    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            actionKey.SetActive(true);
            
            activeCross.SetActive(true);
        }
        else
        {
            actionKey.SetActive(false);
            
            activeCross.SetActive(false);
        }
        if (Input.GetButton("Action"))
        {
            if (theDistance <= 2)
            {
                keyTaken = true;

                this.gameObject.GetComponent<CapsuleCollider>().enabled = false;

                actionKey.SetActive(false);
                getKeyText.SetActive(true);
                StartCoroutine(KeyTakenText());
                activeCross.SetActive(false);

                //doorSound.Play();
                key.GetComponent<MeshRenderer>().enabled = false;
            }
        }

    }
    void OnMouseExit()
    {
        actionKey.SetActive(false);

        activeCross.SetActive(false);
    }
    IEnumerator KeyTakenText()
    {
        yield return new WaitForSeconds(2f);
        getKeyText.SetActive(false);
    }
}
