using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocScript : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerControler;
    [SerializeField] private int docNumber;
    [SerializeField] private SanidadeScrip sanidade;
    [SerializeField] private DialogueManeger dig;

    [SerializeField] private string[] falas;

    private new Renderer renderer;

    private void OnMouseDown()
    {
        sanidade.PerdeuSanidade(1);
        playerControler.getDocs(docNumber);
        Destroy(transform.gameObject);
    }

    private void Falar(string[] a) 
    {
        dig.PlayNarrative(a,false);
    }
}
