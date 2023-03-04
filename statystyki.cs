using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class statystyki : MonoBehaviour
{
    public int zdrowie = 100;
    public int zdrowieMAX = 100;
    public int kondycja = 100;
    public int zdrowiePsychiczne = 10;
    public List<int> oceny = new List<int>();
    public float sredniaocen = 0.0f;
    public int pieniadze = 10;
    public int repultacjaSamorzad = 0;
    public int repultacjaScianka = 0;
    public int repultacjaNauczyciele = 0;
    // Start is called before the first frame update
    void Start()
    {
        zdrowie = PlayerPrefs.GetInt("zdrowie");
        zdrowieMAX = PlayerPrefs.GetInt("zdrowieMAX");
        kondycja = PlayerPrefs.GetInt("kondycja");
        zdrowiePsychiczne = PlayerPrefs.GetInt("zdrowiePsychiczne");
        sredniaocen = PlayerPrefs.GetFloat("sredniaocen");
        pieniadze = PlayerPrefs.GetInt("pieniadze");
        repultacjaSamorzad = PlayerPrefs.GetInt("repultacjaSamorzad");
        repultacjaScianka = PlayerPrefs.GetInt("repultacjaScianka");
        repultacjaNauczyciele = PlayerPrefs.GetInt("repultacjaNauczyciele");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("zdrowie", zdrowie);
        PlayerPrefs.SetInt("zdrowieMAX", zdrowieMAX);
        PlayerPrefs.SetInt("kondycja", kondycja);
        PlayerPrefs.SetInt("zdrowiePsychiczne", zdrowiePsychiczne);
        string listaString = string.Join(",", oceny);
        PlayerPrefs.SetString("mojaLista", listaString);
        PlayerPrefs.SetFloat("sredniaocen", sredniaocen);
        PlayerPrefs.SetInt("pieniadze", pieniadze);
        PlayerPrefs.SetInt("repultacjaSamorzad", repultacjaSamorzad);
        PlayerPrefs.SetInt("repultacjaScianka", repultacjaScianka);
        PlayerPrefs.SetInt("repultacjaNauczyciele", repultacjaNauczyciele);
        if(zdrowie > zdrowieMAX) {
            zdrowie = zdrowieMAX;
        }
        if(zdrowie <= 0) {
            Debug.Log("zginoles");
        }
        int suma = 0;
        int ilosc = oceny.Count;
        foreach (int ocena in oceny)
        {
        suma += ocena;
        }

        if (ilosc > 0)
        {
        sredniaocen = (float)suma / ilosc;
        }

            
        }
}
