﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;


 void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CompleteLevel();
    }
}

