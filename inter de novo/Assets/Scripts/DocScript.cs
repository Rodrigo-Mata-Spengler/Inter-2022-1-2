using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocScript : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerControler;
    [SerializeField] private int docNumber;
    [SerializeField] private SanidadeScrip sanidade;

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
        sanidade.PerdeuSanidade(1);
        playerControler.getDocs(docNumber);
        Destroy(transform.gameObject);
    }
}
