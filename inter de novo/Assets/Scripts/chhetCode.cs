using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chhetCode : MonoBehaviour
{
    [SerializeField] private KeyCode key = KeyCode.P;

    private bool ctlr = false;

    [SerializeField] private GameObject cheatSheet;

    [SerializeField] private PlayerInventory player;

    [SerializeField] private CasaFantasma casa;

    private void Start()
    {
        cheatSheet.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(key) && !ctlr)
        {
            cheatSheet.SetActive(true);
            ctlr = true;

        }else if (Input.GetKeyDown(key) && ctlr)
        {
            cheatSheet.SetActive(false);
            ctlr = false;
        }
    }

    public void GetAllDocs()
    {
        player.HaveAllDocs();
    }

    public void GetAllkeys()
    {
        player.HaveAllKeys();
    }
    public void ResetCasaFantasma()
    {
        casa.CasaFantasmaReset();
    }

    public void PlayCasaFantasma()
    {
        casa.CasaFantasmaPlay();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("Blocagem 1");
    }

}
