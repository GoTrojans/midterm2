using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok as long as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;
    LifeBoard lifeBoard;

    void Start() {
        lifeBoard = FindObjectOfType<LifeBoard>();
    }

    void OnTriggerEnter(Collider other)
    {
        bool dead = lifeBoard.LoseLife();
        if (dead) {
            StartDeathSequence();
            deathFX.SetActive(true);
            Invoke("ReloadScene", levelLoadDelay);
        }
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");

    }

    private void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
    }
}
