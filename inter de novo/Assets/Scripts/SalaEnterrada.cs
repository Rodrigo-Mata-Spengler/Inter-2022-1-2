using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaEnterrada : MonoBehaviour
{
    [SerializeField] private Light luz;
    [SerializeField] private GravityScript grav;
    [SerializeField] private float numTarget = 50f;
    [SerializeField] private float tempo = 1f;

    private bool luzControle = false;

    private float numAtual = 0;
    private void Start()
    {
        luz.enabled = false;
        luz.intensity = 0f;
    }
    public void AtivarLuz()
    {
        luzControle = true;
    }

    public void AtivarGravidade()
    {
        grav.DesligarGrtavidade();
    }

    private void FixedUpdate()
    {
        if (luzControle)
        {
            luz.enabled = true;
            numAtual = Mathf.Lerp(numAtual, numTarget, tempo * Time.deltaTime);
            luz.intensity = numAtual;
        }
    }

}
