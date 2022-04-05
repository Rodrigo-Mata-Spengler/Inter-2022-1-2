using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private int numFalas;

    private Renderer renderer;

    private bool doOnce;

    private void Start()
    {
        renderer = transform.GetComponent<MeshRenderer>();
        doOnce = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") && doOnce)
        {
            player.GetComponent<DialogueManeger>().PlayNarrative(this.numFalas);
            renderer.material.color = Color.green;
            doOnce = false;
        }
    }
}
