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

    private void Start()
    {
        //this.painelDeTexto.SetActive(false);
    }
    
    public void PlayNarrative(int tocar)
    {
        FalasTextoInicio(tocar);
        StartCoroutine(TesteNum1());
    }

    private void FalasTextoInicio(int a)
    {
        //this.painelDeTexto.SetActive(true);
        this.caixadeTexto.text = falasTexto[a];

    }

    private void FalasTextoFim()
    {
        //this.painelDeTexto.SetActive(false);
        this.caixadeTexto.text = "";

    }

     IEnumerator TesteNum1()
    {
        yield return new WaitForSecondsRealtime(10f);

        this.caixadeTexto.text = "";
    }

}
