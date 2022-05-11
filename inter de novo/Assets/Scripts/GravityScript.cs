using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    [SerializeField] private GameObject[] objFantasma;
    [SerializeField] private float forca = 1f;
    [SerializeField] private float rote = 1f;
    [SerializeField] private Vector3 roteDir = new Vector3(1, 1, 1);

    [SerializeField] private bool a = false;

    private Rigidbody[] rigFantasma;
    private float b = 0;
    private void Start()
    {
        rigFantasma = new Rigidbody[objFantasma.Length];
        for (int i = 0; i < objFantasma.Length; i++)
        {
            rigFantasma[i] = objFantasma[i].GetComponent<Rigidbody>();
        }
    }

    public void DesligarGrtavidade()
    {
        foreach (var rig in rigFantasma)
        {
            rig.useGravity = false;

            rig.AddForce(transform.up * forca);

            rig.transform.RotateAroundLocal(roteDir, rote);
        }
    }

    private void Update()
    {
        if (a && b==0)
        {
            DesligarGrtavidade();
            b++;
        }
    }
}
