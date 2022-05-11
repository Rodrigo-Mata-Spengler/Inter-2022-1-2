using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgrecao : MonoBehaviour
{
    [SerializeField] private SanidadeScrip sani;

    [SerializeField] private int vidaAtual;

    [SerializeField] private GameObject player;

    [SerializeField] private string[] falas;

    [SerializeField] private CasaFantasma casa;

    [SerializeField] private GameObject pinelFim;


    private DialogueManeger falar;
    private void Start()
    {
        vidaAtual = sani.GetVidaAtual();

        falar = player.GetComponent<DialogueManeger>();
    }

    public void EventoProg()
    {
        vidaAtual = sani.GetVidaAtual();

        switch (vidaAtual)
        {
            case 2:
                CasaAparecer();
                break;
            case 0:
                FimJogo();
                break;
            default:
                break;
        }
    }

    private void Dialogo(string[] dig,bool b)
    {
        falar.PlayNarrative(dig,b);
    }

    private void CasaAparecer()
    {
        casa.CasaFantasmaAparecer();
    }

    private void FimJogo()
    {
        Dialogo(falas,true);
    }
}
