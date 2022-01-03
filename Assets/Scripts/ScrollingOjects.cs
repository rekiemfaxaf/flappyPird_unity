﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingOjects : MonoBehaviour {

    private Rigidbody2D rb2d;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        rb2d.velocity = Vector2.left * GameController.instance.scrollSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver) {
            rb2d.velocity = Vector2.zero;
        }
	}
}
