using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            rd.velocity = new Vector2(5, rd.velocity.y);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rd.velocity = new Vector2(-5, rd.velocity.y);
        }
    }
}
