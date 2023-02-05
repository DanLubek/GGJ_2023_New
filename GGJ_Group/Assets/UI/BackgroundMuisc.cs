using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMuisc : MonoBehaviour
{
    private void Awake()
    {
        // Search for any game objected tagged as GameMusicAudio
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BGMUSIC");
        // If there are multiple objects with that tag destory the object
        if (backgroundMusic.Length > 1)
        {
            Destroy(gameObject);
        }
        // Set it to not destory on load
        DontDestroyOnLoad(gameObject);
    }
}
