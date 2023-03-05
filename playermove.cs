using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject gracz;
    public Sprite graczStojacy;
    public Rigidbody2D rb;
    public bool InputW;
    public bool InputA;
    public bool InputS;
    public bool InputD;
    public float szybkosc = 5f;


    // Update is called once per frame
    void Update()
    {
        if (InputW || InputA || InputS || InputD)
        {
            gracz.GetComponent<Animator>().enabled = true;
        }else {
            gracz.GetComponent<Animator>().enabled = false;
            gracz.GetComponent<SpriteRenderer>().sprite = graczStojacy;
        }
        if (Input.GetKey(KeyCode.W)) {
            InputW = true;
        } else {
			InputW = false;
        }

        if (Input.GetKey(KeyCode.A)) {
            InputA = true;
        } else {
			InputA = false;
        }
        
		if (Input.GetKey(KeyCode.S)) {
            InputS = true;
        } else {
			InputS = false;
        }

        if (Input.GetKey(KeyCode.D)) {
            InputD = true;
        } else {
			InputD = false;
        }

        if (InputW) {
			rb.MovePosition(new Vector2(transform.position.x, transform.position.y + szybkosc * Time.deltaTime));
		}
		if (InputA) {
            rb.MovePosition(new Vector2(transform.position.x - szybkosc * Time.deltaTime, transform.position.y));
        }
		if (InputS) {
            rb.MovePosition(new Vector2(transform.position.x, transform.position.y - szybkosc * Time.deltaTime));
        }
		if (InputD) {
            rb.MovePosition(new Vector2(transform.position.x + szybkosc * Time.deltaTime, transform.position.y));
        }
    }
}
