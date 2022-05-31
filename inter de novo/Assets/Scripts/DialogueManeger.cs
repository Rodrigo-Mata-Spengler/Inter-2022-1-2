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
    [SerializeField] private GameObject caixadeTextoImagem;

    //[SerializeField] private GameObject painelDeTexto;

    [SerializeField] private bool legendas;

    [SerializeField] private GameObject fim;

    private int falaAtual;

    private int dialogoatual;

    private bool fimJogo = false;

    private bool trig = false;

    private PauseScript pause = new PauseScript();
    
    private void Start()
    {
        //this.painelDeTexto.SetActive(false);

        caixadeTextoImagem.SetActive(false);
        falaAtual = 0;
        dialogoatual = 0;
        fim.SetActive(true);
    }
    
    public void PlayNarrative(string[] a,bool b)
    {
        caixadeTextoImagem.SetActive(true);
        falasTexto = a;
        FalasTextoInicio();
        StartCoroutine(Tempo());
        fimJogo = b;
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
            if (fimJogo)
            {
                TelaFim();
            }
            caixadeTextoImagem.SetActive(false);
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
    private void Update()
    {
        if (trig)
        {
            fim.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(fim.GetComponent<CanvasGroup>().alpha,1,0.5f);
        }
    }

    private void TelaFim()
    {
        fim.SetActive(true);
        trig = true;

        Time.timeScale = 0;
        pause.SoltarMouse();
    }
}
