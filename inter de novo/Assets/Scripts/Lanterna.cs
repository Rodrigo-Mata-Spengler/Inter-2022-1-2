using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    [SerializeField] private GameObject lanterna;
    [SerializeField] private KeyCode key = KeyCode.F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            lanterna.SetActive(!lanterna.active);
        }
    }
}
