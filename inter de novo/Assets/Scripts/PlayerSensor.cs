using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private int numFalas;

    [SerializeField] private string[] falas;

    private bool doOnce;
    private void Start()
    {
        doOnce = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") && doOnce)
        {
            player.GetComponent<DialogueManeger>().PlayNarrative(falas);
            doOnce = false;
            Destroy(transform);
        }
    }
}
