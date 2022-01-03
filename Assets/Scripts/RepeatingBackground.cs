using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontalLenght;

    private void Awake() {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    // Use this for initialization
    void Start () {
        groundHorizontalLenght = groundCollider.size.x;
    }

    private void RespositionBackground() {
        transform.Translate(Vector2.right * groundHorizontalLenght * 2f);
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -groundHorizontalLenght) {
            RespositionBackground();
        }
	}
}
