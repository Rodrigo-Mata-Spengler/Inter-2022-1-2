using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTrem : MonoBehaviour
{
    [SerializeField] private GameObject trem;
    [SerializeField] private float speed=2;
    [SerializeField] private Animator desanima;

    private bool doOnce = true;

    private void Start()
    {
        doOnce = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colidiu aqui");
        if (other.transform.CompareTag("Player") && doOnce)
        {
            Acelerar();
            doOnce = false;
        }
    }
    private void Acelerar()
    {
        desanima.SetTrigger("trem_move");
    }
}
