using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] public bool hasLupa;
    [SerializeField] private bool hasHammer;
    [SerializeField] private bool[] keys;
    [SerializeField] private bool[] docs;


    private void Start()
    {
        hasHammer = false;

        for(int i = 0; i < keys.Length; i++)
        {
            keys[i] = false;
        }

        for (int i = 0; i < docs.Length; i++)
        {
            docs[i] = false;
        }
    }
    public bool HaveKeys(int a)
    {
        return keys[a];
    }

    public void getKey(int a)
    {
        keys[a] = true;
    }

    public void GetHammer()
    {
        this.hasHammer = true;
    }

    public bool HasHammer()
    {
        return this.hasHammer;
    }

    public void getDocs(int a)
    {
        docs[a] = true;
    }

    public bool HaveDocs(int a)
    {
        return docs[a];
    }

    public void GetLupa()
    {
        this.hasLupa = true;
    }

    public bool Haslupa()
    {
        return this.hasLupa;
    }
}
