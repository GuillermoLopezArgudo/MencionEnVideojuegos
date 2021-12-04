using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;
    SpriteRenderer Carta;

    // Start is called before the first frame update
    void Start()
    {

        Carta = GetComponent<SpriteRenderer>();
        Carta.sprite = back;
        
    }
        
    // Update is called once per frame
    void Update()
    {

    }
}
    