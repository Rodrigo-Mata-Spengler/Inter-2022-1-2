using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerControler;
    [SerializeField] private int keyNumber;

    private new Renderer renderer;

    private void Start()
    {
        renderer = transform.GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseDown()
    {
        playerControler.getKey(keyNumber);
        renderer.enabled = false;
        transform.GetComponent<MeshCollider>().enabled = false;
    }
}
