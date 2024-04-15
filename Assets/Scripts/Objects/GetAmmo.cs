using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAmmo : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject activeCross;
    public GameObject pistol;
    public GameObject ammoBox;





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
                Pistol pistolScript = pistol.GetComponent<Pistol>();
                pistolScript.carriedAmmo += 8;
                if (pistolScript.carriedAmmo >= 40)
                {
                    pistolScript.carriedAmmo = 40;
                }
                pistolScript.UpdateAmmoUI();
                this.gameObject.GetComponent<BoxCollider>().enabled = false;

                actionKey.SetActive(false);
               
                activeCross.SetActive(false);

                Destroy(ammoBox);

            }
        }

    }
    void OnMouseExit()
    {
        actionKey.SetActive(false);

        activeCross.SetActive(false);
    }

}
