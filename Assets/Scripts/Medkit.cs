using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject activeCross;
    public GameObject medkitBox;
    public GameObject fullHealthText;
    PlayerHealth player;

    private void Start()
    {
        player = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 4)
        {
            if (player.currentHealth == 100)
            {
                actionKey.SetActive(false);
                activeCross.SetActive(true);
                fullHealthText.SetActive(true);
                StartCoroutine(TextDelete());
            }
            else if (player.currentHealth < 100)
            {
                actionKey.SetActive(true);
                activeCross.SetActive(true);
            }

        }
        else
        {
            actionKey.SetActive(false);
            activeCross.SetActive(false);
        }
        if (Input.GetButton("Action"))
        {
            if (theDistance <= 5)
            {
                if (player.currentHealth < 100)
                {
                    player.currentHealth += 25;
                    player.UpdateText();
                    player.healthBarSlider.value += 25;

                    actionKey.SetActive(false);
                    activeCross.SetActive(false);

                    Destroy(medkitBox);
                }
            }
        }

    }

    IEnumerator TextDelete()
    {
        yield return new WaitForSeconds(1.5f);
        fullHealthText.SetActive(false);
    }

    void OnMouseExit()
    {
        actionKey.SetActive(false);
        activeCross.SetActive(false);
        fullHealthText.SetActive(false);
    }
}
