using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDialogu : MonoBehaviour
{
    public GameObject dialog;
    void OnTriggerEnter2D(Collider2D other) {
        dialog.SetActive(true);
    }
}
