using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;
    SpriteRenderer Carta;
    public Sprite front;
    public bool bandera = true;

    // Start is called before the first frame update
    void Start()
    {

        Carta = GetComponent<SpriteRenderer>();
        Carta.sprite = back;
        
        
        
    }

    private void OnMouseDown()
    {
            
        if(bandera == false)
        {
            Carta.sprite = back;
            bandera = true;
        }
        else
        {
            Carta.sprite = front;
            bandera = false;
        }

        
        Debug.Log("CLIC"+ name);
    }
        
    // Update is called once per frame
    void Update()
    {

    }
}
    