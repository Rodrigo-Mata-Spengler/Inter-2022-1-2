using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuInicial;
    [SerializeField] private GameObject menuCreditos;
    [SerializeField] private GameObject menuAjustes;
    [SerializeField] private GameObject menuComoJogar;

    private void Start()
    {
        menuInicial.SetActive(true);
        menuCreditos.SetActive(false);
        menuAjustes.SetActive(false);
        menuComoJogar.SetActive(false);
    }
    public void FecharJogo()
    {
        Application.Quit();
    }

    public void IniciarJogo()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene("Animação");
    }

    public void Creditos()
    {
        menuInicial.SetActive(false);
        menuCreditos.SetActive(true);
    }

    public void Voltar()
    {
        if (menuCreditos.active)
        {
            menuCreditos.SetActive(false);
            menuInicial.SetActive(true);
        }else if (menuAjustes.active)
        {
            menuAjustes.SetActive(false);
            menuInicial.SetActive(true);
        }
        else if (menuComoJogar.active)
        {
            menuComoJogar.SetActive(false);
            menuInicial.SetActive(true);
        }
    }

    public void Ajustes()
    {
        menuInicial.SetActive(false);
        menuAjustes.SetActive(true);
    }

    public void ComoJogar()
    {
        menuInicial.SetActive(false);
        menuComoJogar.SetActive(true);
    }
}
