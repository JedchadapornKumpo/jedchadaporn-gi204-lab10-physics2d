using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float move;
    [SerializeField]float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
