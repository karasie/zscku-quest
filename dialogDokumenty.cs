using UnityEngine;
using UnityEngine.UI;

public class dialogDokumenty : MonoBehaviour
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
    public GameObject dokumenty;

    void Start()
    {
        postac.text = postacie[linia];
        postaczdj.sprite = zdjpostaci[linia];
        napis.text = linie[linia];
        linia++;
        gracz.GetComponent<playermove>().enabled = false;
    }

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
                gameObject.SetActive(false);
                dokumenty.SetActive(true);
            }
        }
    }
}
