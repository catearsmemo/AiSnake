using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject canavas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="SnakeHead"&&canavas!=null)//碰到头，激活按钮
        { canavas.transform.GetChild(0).gameObject.SetActive(true); }
    }
}
