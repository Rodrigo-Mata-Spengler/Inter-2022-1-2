using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject menupause;
    [SerializeField] private KeyCode botao = KeyCode.Escape;

    [SerializeField] private GameObject opções;
    private bool isActive = false;

    private Scene scena;

    private void Start()
    {
        opções.SetActive(false);
        menupause.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(botao) && !isActive)
        {
            menupause.SetActive(true);
            Time.timeScale = 0;
            SoltarMouse();
            isActive = true;
        }
        else if (Input.GetKeyDown(botao) && isActive)
        {
            PrenderMouse();
            VoltarAoJogo();
        }
    }

    public void FecharJogo()
    {
        Application.Quit();
    }

    public void VoltarAoJogo()
    {
        menupause.SetActive(false);
        Time.timeScale = 1;
        isActive = false;
        PrenderMouse();
    }

    public void MenuOpcao()
    {
        opções.SetActive(true);
    }

    public void Voltar()
    {
        opções.SetActive(false);
    }
    
    public void SoltarMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PrenderMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void Recarregar()
    {
        scena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scena.name);
    }

    public void GoStartMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
