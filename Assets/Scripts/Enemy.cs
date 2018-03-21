using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 10;

    ScoreBoard scoreBoard;
    Renderer rend;

	// Use this for initialization
	void Start () {
        AddNonTriggerBoxCollider();
        //scoreBoard = FindObjectOfType<ScoreBoard>();
        rend = GetComponent<Renderer>();
        //Invoke("FlashOut", 6.5f);
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    void FlashOut() {
        rend.enabled = false;
        Invoke("FlashIn", 1.5f);
    }     

    void FlashIn() {
        rend.enabled = true;
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        //scoreBoard.ScoreHit(scorePerHit);
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent; // parent it in the game objects hierarchy to make it tidy
        Destroy(gameObject);
    }
}
