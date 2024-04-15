using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject tvEffect;

    private void OnTriggerEnter(Collider other) { 
        if (other.tag == "Player")
        {
            tvEffect.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Destroy(tvEffect, 2f);
    }
}
