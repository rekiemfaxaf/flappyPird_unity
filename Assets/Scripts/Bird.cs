﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    private bool isDead;
    private Rigidbody2D rb2d;
    private Animator anim;
    public float upForce = 200f;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update () {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0)) {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(Vector2.up * upForce);
            anim.SetTrigger("Flap");
        }
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        isDead = true;
        anim.SetTrigger("Die");
        GameController.instance.BirdDie();
        rb2d.velocity = Vector2.zero;
    }
}
