using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullScript : MonoBehaviour
{
    [SerializeField]private Transform theDest;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("destino").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().freezeRotation = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
