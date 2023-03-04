using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest1 : MonoBehaviour
{
     public Text powiadomienie;
     public string nick;
     public InputField nickplace;
     public GameObject gracz;

     void Start() {
        powiadomienie.text = "kliknij Enter by potwiedzić";
        }
      void Update() {
         if (Input.GetKey(KeyCode.Return)) {
            nick = nickplace.GetComponent<InputField>().text;
            PlayerPrefs.SetString("nick", nick);
            powiadomienie.text = "";
            gracz.GetComponent<playermove>().enabled = true;
            gameObject.SetActive(false);
         }
      }
     
}
