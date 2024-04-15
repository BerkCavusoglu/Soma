using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public int destroyTimer = 5;
    
    private void Awake()
    {
        destroyTimer = Random.Range(5, 12);
        Destroy(gameObject, destroyTimer);
    }

    void Start()
    {

    }
    void Update()
    {
        
    }
}
