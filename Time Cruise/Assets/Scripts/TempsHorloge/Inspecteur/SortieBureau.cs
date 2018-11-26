﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SortieBureau : MonoBehaviour {

    public GameObject porteBureau;

    private bool ended;
    public UnityEvent OnEnd;

    private void Start()
    {
        porteBureau.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            porteBureau.SetActive(true);
            OnEnd.Invoke();
        }
    }
}