using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject gracz;
    public GameObject camera;
    public float szybkosc = 0.03f;

    void OnCollisionEnter2D(Collision2D collision)
{

        Rigidbody2D rb = gracz.GetComponent<Rigidbody2D>();
        rb.velocity = -rb.velocity;
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(camera.transform.position.x, gracz.transform.position.y, camera.transform.position.z);
    if(Input.GetKey(KeyCode.W)){

       gracz.transform.position = new Vector3(gracz.transform.position.x, gracz.transform.position.y + szybkosc , gracz.transform.position.z);

    }else{
    if(Input.GetKey(KeyCode.S))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x , gracz.transform.position.y - szybkosc, gracz.transform.position.z);
    }else {
        if(Input.GetKey(KeyCode.D))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x + szybkosc , gracz.transform.position.y, gracz.transform.position.z);
    }else{
       if(Input.GetKey(KeyCode.A))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x - szybkosc, gracz.transform.position.y, gracz.transform.position.z);

    } 
    }

    }

   }
   
    }
}
