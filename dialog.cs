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
        int liniemax = postacie.Length;
        if(Input.GetKeyDown(KeyCode.E)) {
            if(linia < liniemax) {
                postac.text = postacie[linia];
                napis.text = linie[linia];
                postaczdj.sprite = zdjpostaci[linia];
                linia++;
                keyPressed = false;
            } else {
                gracz.GetComponent<playermove>().enabled = true;
                gameObject.SetActive(false);
            }
        }
    }
}
