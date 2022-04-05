using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeSanidade : MonoBehaviour
{
    [SerializeField] private SanidadeScrip sanidade;

    private void Start()
    {
        transform.GetComponent<Slider>().maxValue = sanidade.GetVidaMaxima();
        transform.GetComponent<Slider>().value = sanidade.GetVidaMaxima();
    }

    public void PerdeuVida(int a)
    {
        transform.GetComponent<Slider>().value = a;
    }
}
