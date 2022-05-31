using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMochila : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventario;

    [SerializeField] private GameObject[] docSlots;

    [SerializeField] private GameObject[] keySlots;

    private void Start()
    {
        foreach (GameObject item in docSlots)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in keySlots)
        {
            item.SetActive(false);
        }
    }
    public void UpdateInventory()
    {
        for (int i = 0; i < docSlots.Length; i++)
        {
            if (inventario.HaveDocs(i))
            {
                docSlots[i].SetActive(true);
            }
        }

        for (int i = 0; i < keySlots.Length; i++)
        {
            if (inventario.HaveKeys(i))
            {
                keySlots[i].SetActive(true);
            }
        }
    }
}
