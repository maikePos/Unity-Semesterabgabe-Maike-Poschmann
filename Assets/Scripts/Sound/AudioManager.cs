using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip walking;
    public AudioClip mushrooms;
    public AudioClip recordPlayer;

    private void Start()
    {
        musicSource.clip = background;  
        musicSource.Play();
       
    }
}
