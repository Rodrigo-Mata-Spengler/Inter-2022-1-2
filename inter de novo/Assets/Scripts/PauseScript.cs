using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject menupause;
    [SerializeField] private KeyCode botao = KeyCode.Escape;
    private bool isActive = false;

    private void Start()
    {
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
            Debug.Log("entrou !!");
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
    }
    
    private void SoltarMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void PrenderMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
