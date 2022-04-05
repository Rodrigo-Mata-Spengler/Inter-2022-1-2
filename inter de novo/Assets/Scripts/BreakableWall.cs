using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerManeger;

    private Renderer renderer;

    [SerializeField] private int vida = 4;

    [SerializeField] private int vidatotal = 4;

    private void Start()
    {
        renderer = transform.GetComponent<MeshRenderer>();
        vida = vidatotal;
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.green;
    }

    private void OnMouseDown()
    {
        if (playerManeger.HasHammer())
        {
            if(vida == vidatotal)
            {
                renderer.material.color = Color.yellow;
                this.vida -= 1;
            }
            else if (vida == 2)
            {
                renderer.material.color = Color.red;
                this.vida -= 1;

            }
            else if (vidatotal == 0)
            {
                renderer.material.color = Color.red;
                this.vida -= 1;
            }
            else
            {
                Destroy(transform.gameObject);
            }
        }
    }
}
