using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPistol : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;

    //public AudioSource doorSound;
    public GameObject activeCross;
    public GameObject pistol;
    public GameObject realPistol;
    public GameObject ammoPanel;




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

                this.gameObject.GetComponent<BoxCollider>().enabled = false;

                actionKey.SetActive(false);
                realPistol.SetActive(true);
                ammoPanel.SetActive(true);
                activeCross.SetActive(false);

                //doorSound.Play();
                Destroy(pistol);

            }
        }

    }
    void OnMouseExit()
    {
        actionKey.SetActive(false);

        activeCross.SetActive(false);
    }
 
}
