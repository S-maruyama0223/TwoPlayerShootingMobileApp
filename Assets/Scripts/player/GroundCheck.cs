using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private string groundTag = "Ground";
    private bool groundFlug = false;
    private bool isGroundEnter, isGroundExit, isGroundStay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsGround()
    {
        
        if (isGroundEnter || isGroundStay)
        {
            this.groundFlug = true;    
        }
        else if (isGroundExit)
        {
            this.groundFlug = false;
        }
        isGroundEnter = false;
        isGroundStay = false;
        isGroundExit = false;
        return groundFlug;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundExit = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            isGroundStay = true;
        }
    }
}
