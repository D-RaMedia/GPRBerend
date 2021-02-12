﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] public GameObject deathPanel;
    protected int Health = 100;
    [SerializeField] Text hitText;

    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);

            deathPanel.SetActive(true);
            Debug.Log("The End");
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown("space"))
        {
            Hit();
        }

    }
    void Hit()
    {
        Health -= 10;
        Debug.Log(Health);
        hitText.text = "Health:" + " " + Health.ToString();
    }
}
