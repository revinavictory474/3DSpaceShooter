﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int playerHealth = 1;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GetDamage(int damage)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
            Destruction();
    }

    private void Destruction()
    {
        Destroy(gameObject);
    }
}