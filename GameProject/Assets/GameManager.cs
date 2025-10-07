using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    //Variables
    public TextMeshProUGUI text;
    public InputActionReference e;
    private int score;
    public InputActionReference s; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       

        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;

        if (e.action.WasPressedThisFrame())
        {
            score++;

        }

      
        if(s.action.WasPressedThisFrame())
        {  score--;}

        if (score >= 10)
        {
            text.color = Color.green;
        }

        else if (score < 0)
        {
            text.color = Color.maroon;
        }

        else
        {
            text.color = Color.indianRed;
        }

    }
}
