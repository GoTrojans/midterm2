using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassBehavior : MonoBehaviour {

    int timeCounter;
    int runHash = Animator.StringToHash("run");
    int randHash = Animator.StringToHash("rand_start");
    // set some as real Enemy and some as plain watergrass
    [SerializeField] bool isRealEnemy = true;
    float randomStart;
    Animator anim;

	// Use this for initialization
	void Start () {
        timeCounter = 0;
        anim = GetComponent<Animator>();
        randomStart =  Random.Range(0, 100f);
	}
	
	// Update is called once per frame
	void Update () {
        randomStart--;

        //random animation
        if (randomStart < 0) {
            anim.SetTrigger(randHash);
        }

        timeCounter++;
        if (timeCounter >= 10 && isRealEnemy) {
            // do Attack movement
            anim.SetTrigger(runHash);
        }
		
	}
}
