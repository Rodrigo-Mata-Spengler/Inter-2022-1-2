using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManeger : MonoBehaviour
{
    [SerializeField] private string[] falasTexto;

    [SerializeField] private AudioClip[] falas;

    //[SerializeField] private KeyCode keyToPress = KeyCode.Return;

    [SerializeField] private Text caixadeTexto;

    //[SerializeField] private GameObject painelDeTexto;

    [SerializeField] private bool legendas;

    private int falaAtual;

    private int dialogoatual;
    
    private void Start()
    {
        //this.painelDeTexto.SetActive(false);

        falaAtual = 0;
        dialogoatual = 0;
    }
    
    public void PlayNarrative(string[] a)
    {
        falasTexto = a;
        FalasTextoInicio();
        StartCoroutine(Tempo());
    }

    private void FalasTextoInicio()
    {
        //this.painelDeTexto.SetActive(true);
        this.caixadeTexto.text = falasTexto[falaAtual];

    }
    private void ProximaFala()
    {
        falaAtual++;

        if (falaAtual == falasTexto.Length)
        {
            this.caixadeTexto.text = "";
            falaAtual = 0;
        }
        else
        {
            FalasTextoInicio();
            StartCoroutine(Tempo());
        }

    }
     IEnumerator Tempo()
    {
        yield return new WaitForSecondsRealtime(10f);

        ProximaFala();
}

}
