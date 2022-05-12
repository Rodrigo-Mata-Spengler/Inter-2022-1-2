using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullScript : MonoBehaviour
{
    [SerializeField]private Transform theDest;
    [SerializeField] private Color cor = Color.cyan;
    private Renderer render;

    private void Start()
    {
        render = transform.GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        render.material.color = cor;
    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("destino").transform;
        
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().freezeRotation = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
