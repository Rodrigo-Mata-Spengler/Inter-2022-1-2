using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField]private AudioClip clip;

    [SerializeField]private AudioSource audio;
    public void PlayAudio()
    {
        audio.PlayOneShot(clip);
    }
}
