using UnityEngine;

public class Target : MonoBehaviour
{

    public Gamemanager gm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger when Objects passes through
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.Spawncube();
        gm.score++; 
        Destroy(collision.gameObject);
    }
}
