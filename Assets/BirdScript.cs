using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody; // reference to rigid body 2d

    public float flapStrength;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if space has been pressed to flap the bird up
        if (Input.GetKeyDown(KeyCode.Space)==true){

            myRigidbody.linearVelocity =Vector2.up * flapStrength;

        }
     
    
        
    }
}
