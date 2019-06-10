using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap_Music : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;
    public AudioClip sound9;
    public AudioClip sound10;
    public AudioClip sound11;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Button1()
    {
        audioSource.PlayOneShot(sound1);
    }
    public void Button2()
    {
        audioSource.PlayOneShot(sound2);
    }
    public void Button3()
    {
        audioSource.PlayOneShot(sound3);
    }
    public void Button4()
    {
        audioSource.PlayOneShot(sound4);
    }
    public void Button5()
    {
        audioSource.PlayOneShot(sound5);
    }
    public void Button6()
    {
        audioSource.PlayOneShot(sound6);
    }
    public void Button7()
    {
        audioSource.PlayOneShot(sound7);
    }
    public void Button8()
    {
        audioSource.PlayOneShot(sound8);
    }
    public void Button9()
    {
        audioSource.PlayOneShot(sound9);
    }
    public void Button10()
    {
        audioSource.PlayOneShot(sound10);
    }
    public void Button11()
    {
        audioSource.PlayOneShot(sound11);
    }
}
