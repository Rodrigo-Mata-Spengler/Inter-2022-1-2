using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSensor : MonoBehaviour
{
    [SerializeField] private SalaEnterrada sala;
    [SerializeField] private bool opcao = false;

    private bool doOnce;
    private void Start()
    {
        doOnce = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") && doOnce)
        {
            if (opcao)
            {
                sala.AtivarLuz();
            }
            else
            {
                sala.AtivarGravidade();
            }
            doOnce = false;
            Destroy(transform.gameObject);
        }
    }
}
