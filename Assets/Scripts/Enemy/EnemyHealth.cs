using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    EnemyAI enemy;
    public GameObject bloodEffect;
    private CapsuleCollider col; // CapsuleCollider deðiþkenini tanýmladýk

    void Start()
    {
        enemy = GetComponent<EnemyAI>();
        col = GetComponent<CapsuleCollider>(); // col deðiþkenini baþlatýyoruz
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
        }
    }

    public void ReduceHealth(float reduceHealth)
    {
        enemyHealth -= reduceHealth;
        if (enemyHealth <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
        bloodEffect.SetActive(true);
        enemy.canAttack = false;

        // Kapsül collider'ýný devre dýþý býrakýyoruz
        col.enabled = false;

        Destroy(gameObject, 10f);
    }
}
