using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog : MonoBehaviour
{
    public string[] linie;
    public string[] postacie;
    public Sprite[] zdjpostaci;
    public Image postaczdj;
    public Text postac;
    public Text napis;
    public int linia;
    public bool keyPressed = false;
    public GameObject gracz;
    // Start is called before the first frame update
    void Start()
    {
        postac.text = postacie[linia];
        postaczdj.sprite = zdjpostaci[linia];
        napis.text = linie[linia];
        linia++;
        gracz.GetComponent<playermove>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        keyPressed = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
        keyPressed = false;
        }
        int liniemax = postacie.Length;
        if(keyPressed) {
            if(linia < liniemax) {
                postac.text = postacie[linia];
                napis.text = linie[linia];
                postaczdj.sprite = zdjpostaci[linia];
                linia++;
                keyPressed = false;
            }else {
                gracz.GetComponent<playermove>().enabled = true;
                gameObject.SetActive(false);
            }
        }
    }
}
