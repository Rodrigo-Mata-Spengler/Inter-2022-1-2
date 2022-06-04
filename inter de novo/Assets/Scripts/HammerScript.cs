using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class HammerScript : MonoBehaviour
    {
        [SerializeField] private PlayerInventory playerController;
        [SerializeField] private DialogueManeger dig;
        [SerializeField] private string[] falas;

        private new Renderer renderer;

        private void Start()
        {
            renderer = transform.GetComponent<MeshRenderer>();
        }

        private void OnMouseEnter()
        {
            renderer.material.color = Color.blue;
        }

        private void OnMouseDown()
        {
            playerController.GetHammer();
            dig.PlayNarrative(falas, false);
            Destroy(transform.gameObject);
        }
    }
}
