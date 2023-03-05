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

}
