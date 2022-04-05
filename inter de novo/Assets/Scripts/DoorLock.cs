using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    private new Renderer renderer;

    [SerializeReference] private GameObject playerControler;

    JointLimits doorlimits;
    HingeJoint hinge;

    [SerializeField] private int doorNumber;

    void Start()
    {
        renderer = transform.GetChild(0).GetComponent<MeshRenderer>();
        hinge = GetComponent<HingeJoint>();

        doorlimits = hinge.limits;

        doorlimits.max = 0;
        doorlimits.min = 0;

        hinge.limits = doorlimits;
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.green;
    }

    private void OnMouseDown()
    {
        if (playerControler.GetComponent<PlayerInventory>().HaveKeys(doorNumber))
        {
            renderer.material.color = Color.red;
            doorlimits.max = 90;
            doorlimits.min = -90;
            hinge.limits = doorlimits;
        }
    }
}
