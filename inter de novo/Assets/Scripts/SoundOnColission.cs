using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnColission : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    [SerializeField] private AudioSource audio;

    private bool doOnde = false;

    private void Start()
    {
        doOnde = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (doOnde)
        {
            audio.PlayOneShot(clip);
            doOnde = false;
            Debug.Log("toquei");
        }
    }

    private void Update()
    {
        if (!doOnde && !audio.isPlaying)
        {
            doOnde = true;
        }
    }
}
