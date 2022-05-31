using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaFantasma : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private float tempo = 6f;
    [SerializeField] private bool aparecer = false;
    [SerializeField] private Collider[] colis�o;
    [SerializeField] private GameObject[] rend;
    [SerializeField] private GameObject Luz;

    [SerializeField] private GameObject animador;
    
    private float targetNumeber = -1f;
    private float currentNumber = 1f;

    private float luztargetNumeber = 35f;
    private float luzcurrentNumber = 0f;

    private void Start()
    {
        CasaFantasmaReset();
    }
    private void Update()
    {
        if (aparecer)
        {
            currentNumber = Mathf.Lerp(currentNumber, targetNumeber, tempo * Time.deltaTime);

            luzcurrentNumber = Mathf.Lerp(luzcurrentNumber, luztargetNumeber, tempo * Time.deltaTime);
            Luz.active = true;
            
            material.SetFloat("Vector1_ddf766dbd6de4da5a5ae03cb28863705", currentNumber);
            aparecer = true;

            Luz.GetComponent<Light>().intensity = luzcurrentNumber;
            foreach (GameObject re in rend)
            {
                re.active = true;
            }
            animador.SetActive(true);
            if ( currentNumber <= -0.5)
            {
                foreach (Collider co in colis�o)
                {
                    co.enabled = true;
                }
                if (currentNumber <= -0.99) {
                    aparecer = false;
                    material.SetFloat("Boolean_f8cb18f941d444d7af7e8748be9c3d8f", 1);
                }
            }
        }
    }

    public void CasaFantasmaAparecer()
    {
        aparecer = !aparecer;
    }

    public void CasaFantasmaReset()
    {
        material.SetFloat("Vector1_ddf766dbd6de4da5a5ae03cb28863705", 1);
        material.SetFloat("Boolean_f8cb18f941d444d7af7e8748be9c3d8f", 0);

        foreach (Collider co in colis�o)
        {
            co.enabled = false;
        }
        foreach (GameObject re in rend)
        {
            re.active = false;
        }

        Luz.active = false;

        animador.SetActive(false);
    }
}
