using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    
    private void Awake()
    {
        // Singleton pattern without using statics
        int numMusicPayer = FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


}
