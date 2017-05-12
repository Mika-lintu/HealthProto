using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour {

    public float startHealth;
    public float health;
    
    HealthUI hUI;


    void Start () {
        health = startHealth;
        hUI = GameObject.FindGameObjectWithTag("HealthUI").GetComponent<HealthUI>();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, startHealth);
        hUI.MinusHealth(damage);

        if (health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        gameObject.SetActive(false);
        hUI.DisableHealthBar();
    }
}
