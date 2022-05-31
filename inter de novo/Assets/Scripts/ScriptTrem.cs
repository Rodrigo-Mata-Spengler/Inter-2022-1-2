using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTrem : MonoBehaviour
{
    [SerializeField] private GameObject trem;
    [SerializeField] private float speed=2;
    [SerializeField] private Animator desanima;

    private bool acelerar = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Trigger"))
        {
            Acelerar();
            Debug.Log("entrei aaaaa");
        }    
    }

    private void Acelerar()
    {
        desanima.SetTrigger("trem_move");
    }
}
