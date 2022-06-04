using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
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
    public void HaveAllKeys()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            keys[i] = true;
        }
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

    public bool[] HaveDocs()
    {
        return docs;
    }

    public void HaveAllDocs()
    {
        for (int i = 0; i < docs.Length; i++)
        {
            docs[i] = true;
        }
    }

}
