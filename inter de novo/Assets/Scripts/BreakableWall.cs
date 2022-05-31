using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerManeger;

    private Renderer renderer;

    [SerializeField] private int vida = 4;

    [SerializeField] private int vidatotal = 4;

    [SerializeField] private AudioClip clip;

    [SerializeField] private AudioClip quebrou;

    [SerializeField] private AudioClip semChave;

    [SerializeField] private AudioSource audio;

    private void Start()
    {
        vida = vidatotal;
    }

    private void OnMouseDown()
    {
        if (playerManeger.HasHammer())
        {
            if(vida == vidatotal)
            {
                this.vida -= 1;
                audio.PlayOneShot(clip);
            }
            else if (vida == 2)
            {
                this.vida -= 1;
                audio.PlayOneShot(clip);
            }
            else if (vidatotal == 0)
            {
                this.vida -= 1;
                audio.PlayOneShot(clip);
            }
            else
            {
                audio.PlayOneShot(quebrou);
                Destroy(transform.gameObject);
            }
        }
        else
        {
            audio.PlayOneShot(semChave);
        }
    }
}
