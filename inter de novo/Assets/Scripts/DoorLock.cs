using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SoundOnColission))]
public class DoorLock : MonoBehaviour
{
    private new Renderer renderer;

    [SerializeReference] private GameObject playerControler;

    JointLimits doorlimits;
    HingeJoint hinge;

    [SerializeField] private int doorNumber;

    [SerializeField] private AudioClip trancado;

    [SerializeField] private AudioClip abriu;

    [SerializeField] private AudioSource audio;

    [SerializeField] private SoundOnColission sound;

    [SerializeField] private DialogueManeger dig;


    private bool doOnce = false;

    [SerializeField] private bool doubleKey;

    [SerializeField] private int keyNumber;

    [SerializeField] private string[] falas;

    [SerializeField] private string[] falas2;

    [SerializeField] private bool temFalas2 = false;

    [SerializeField] private bool temFalas = false;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        doorlimits = hinge.limits;

        doorlimits.max = 0;
        doorlimits.min = 0;

        hinge.limits = doorlimits;

        sound.enabled = false;
        doOnce = true;
    }

    private void OnMouseDown()
    {
        if (playerControler.GetComponent<PlayerInventory>().HaveKeys(doorNumber) && doOnce && !doubleKey)
        {
            doorlimits.max = 90;
            doorlimits.min = -90;
            hinge.limits = doorlimits;
            audio.PlayOneShot(abriu);
            sound.enabled = true;
            doOnce = false;
            if (temFalas2)
            {
                dig.PlayNarrative(falas2, false);
            }
            
        }
        else if (playerControler.GetComponent<PlayerInventory>().HaveKeys(doorNumber) && playerControler.GetComponent<PlayerInventory>().HaveDocs(keyNumber) && doOnce)
        {
            doorlimits.max = 90;
            doorlimits.min = -90;
            hinge.limits = doorlimits;
            audio.PlayOneShot(abriu);
            sound.enabled = true;
            doOnce = false;
            if (temFalas2)
            {
                dig.PlayNarrative(falas2, false);
            }
        }
        else
        {
            audio.PlayOneShot(trancado);

            if (temFalas)
            {
                dig.PlayNarrative(falas, false);
            }
        }
    }
}
