using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGirl : MonoBehaviour
{
    AudioSource ZGAS;

    public AudioClip screamAC;
    public AudioClip punchAC;

    void Start()
    {
        ZGAS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Scream()
    {
        ZGAS.PlayOneShot(screamAC);
    }
    public void Punch()
    {
        ZGAS .PlayOneShot(punchAC);
    }
}
