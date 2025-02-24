using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate =2;
    private float timer = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();//spawn the first pipes
        
    }

    // Update is called once per frame
    void Update()
    {


        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        }else{

            spawnPipe();
            timer = 0;

        }
        
        
    }
    void spawnPipe(){
        Instantiate(pipe, transform.position, transform.rotation); //spawn new pipes

    }




}
