using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;



public class WASD2 : MonoBehaviour
{

    //Variables
    public Rigidbody2D rb;
    public float movespeed;
    private Vector2 _movedirection;
    public InputActionReference move;
    public Gamemanager gm; 

  
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:_movedirection.x * movespeed, y:_movedirection.y * movespeed);
    }

    private void Awake()
    {
       
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _movedirection = move.action.ReadValue<Vector2>(); 
    }

 

    
}
