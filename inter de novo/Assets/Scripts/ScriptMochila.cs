using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMochila : MonoBehaviour
{
    [SerializeField] private GameObject[] docSlots;

    [SerializeField] private PlayerInventory inventario;

    private void Start()
    {
        foreach (GameObject item in docSlots)
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
    }
}
