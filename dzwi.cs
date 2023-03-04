using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dzwi : MonoBehaviour
{
    public int scena;
    public Text powiadomienie;
    void OnTriggerStay2D(Collider2D other)
    {
        powiadomienie.text = "kliknij E aby wejść";
        if (Input.GetKey(KeyCode.E)) {
            SceneManager.LoadScene(scena);
            other.GetComponent<playermove>().enabled = false;
        }
    }
}
