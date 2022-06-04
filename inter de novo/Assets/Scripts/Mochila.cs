using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mochila : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private KeyCode botao = KeyCode.E;
    [SerializeField] private ScriptMochila mochila;

    private bool isActive;

    private void Start()
    {
        panel.active = false;
        isActive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(botao) && !isActive)
        {
            panel.active = true;
            isActive = true;
            SoltarMouse();
            mochila.UpdateInventory();
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(botao) && isActive)
        {
            panel.active = false;
            PrenderMouse();
            isActive = false;
            Time.timeScale = 1;
        }
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
