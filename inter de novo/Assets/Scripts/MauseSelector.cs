using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseSelector : MonoBehaviour
{
    // Start is called before the first frame update
    private new Renderer renderer;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseDown()
    {
        renderer.material.color = Color.yellow;
    }
}
