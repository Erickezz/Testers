using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    //Variable

    public GameObject Cube;
    public Vector2 Location = new Vector2 (-7, 0);
    public TextMeshProUGUI hi;
    public int score; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hi.text = "score; " + score; 
    }
    public void Spawncube()
    {
        Instantiate(Cube, Location, Quaternion.identity);
    }
}
