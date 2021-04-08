﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public Healtbar healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxhealth(maxHealth);
    }

    void Update()
    {
        if(gameObject.tag == "Enemy_Bullet")
        {
            TakeDamage(20);
        }
        if(gameObject.tag == "Enemy")
        {
            TakeDamage(20);
        }
        healthbar.SetHealth(currentHealth);
        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
        }
    }
}