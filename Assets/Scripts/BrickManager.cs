using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public AudioClip breakSound;
    public AudioSource audioSource;

    public void Start()
    {
        
    }

    public void Break()
    {
        Destroy(gameObject, 0f);
        audioSource.GetComponent<AudioSource>().PlayOneShot(breakSound);
    }
}
