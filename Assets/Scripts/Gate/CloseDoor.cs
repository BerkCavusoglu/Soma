using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject closedDoorText;
    public GameObject actionText;
    //public GameObject Hinge;
    public AudioSource doorSound;
    public float waitTime;

    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            actionKey.SetActive(true);
            
            if (!closedDoorText.activeSelf)
                actionText.SetActive(true);
            else
                actionText.SetActive(false);
        }
        else
        {
            actionKey.SetActive(false);
            actionText.SetActive(false);
        }
        if (Input.GetButton("Action"))
        {
            if (theDistance <= 2)
            {
                actionKey.SetActive(false);
                actionText.SetActive(false);
                closedDoorText.SetActive(true);
                StartCoroutine(ClosedDoor());
                doorSound.Play();
            }
        }
    }

    void OnMouseExit()
    {
        actionKey.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator ClosedDoor()
    {
        yield return new WaitForSeconds(waitTime);
        closedDoorText.SetActive(false);
    }
}
