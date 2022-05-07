using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject snake;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="SnakeHead")
        {
            snake.GetComponent<SnakeController>().GetApple();
                int x = Random.Range(0, 19);
                int z = Random.Range(0, 19);
                transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
            
        }
        else if(other.name=="Body(Clone)")
        {
            
            int x = Random.Range(0, 19);
            int z = Random.Range(0, 19);
            transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
        }
    }
}
