using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnButton : MonoBehaviour
{
    [SerializeField] private KeyCode botao = KeyCode.F;

    [SerializeField] private AudioClip clip;

    [SerializeField] private AudioSource source;

    private void Update()
    {
        if (Input.GetKeyDown(botao))
        {
            source.PlayOneShot(clip);

        }
    }
}
