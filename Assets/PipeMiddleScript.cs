using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{


    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //referencing the logic script from PipeMiddleScript
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");

        if(collision.gameObject.layer ==3){

            logic.addScore(1); //add score function is being called

        }
        
        
    }
}
