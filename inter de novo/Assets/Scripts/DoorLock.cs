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

    private bool doOnce = false;

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
        if (playerControler.GetComponent<PlayerInventory>().HaveKeys(doorNumber) && doOnce)
        {
            doorlimits.max = 90;
            doorlimits.min = -90;
            hinge.limits = doorlimits;
            audio.PlayOneShot(abriu);
            sound.enabled = false;
            doOnce = false;
        }
        else
        {
            audio.PlayOneShot(trancado);
        }
    }
}
