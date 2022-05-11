using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanidadeScrip : MonoBehaviour
{
    [SerializeField] private int vidaMax;

    [SerializeField] private int vidaAtual;

    [SerializeField] private bool semSanidade;

    [SerializeField] private BarraDeSanidade barra;

    [SerializeField]private GameProgrecao prog;
    private void Start()
    {
        this.vidaAtual = vidaMax;
        semSanidade = false;
    }

    public bool GetSanidade()
    {
        return semSanidade;
    }

    public int GetVidaAtual()
    {
        return vidaAtual;
    }

    public void PerdeuSanidade(int a)
    {
        if((vidaAtual - a )<= 0)
        {
            vidaAtual -= a;
            this.semSanidade = true;
            barra.PerdeuVida(0);
            prog.EventoProg();
        }
        else
        {
            vidaAtual -= a;

            barra.PerdeuVida(vidaAtual);
            prog.EventoProg();
        }
    }

    public int GetVidaMaxima()
    {
        return vidaMax;
    }
}
