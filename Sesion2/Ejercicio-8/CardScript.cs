using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    SpriteRenderer Carta;
    public Sprite front;
    public Sprite back;
    public bool bandera = true;
    GameObject GameManager;
    public string Name;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        Carta = GetComponent<SpriteRenderer>();
        Carta.sprite = back;
       GameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    private void OnMouseDown()
    {
       GameManager.GetComponent<GameManagerScript>().ClickOnCard(Name, index);
        Toogle();
    }

    public void Toogle()
    {
        if (bandera == false)
        {

            Carta.sprite = back;
            bandera = true;

        }
        else
        {
            Carta.sprite = front;
            bandera = false;

        }
    }
        
    // Update is called once per frame
    void Update()
    {

    }
}
    