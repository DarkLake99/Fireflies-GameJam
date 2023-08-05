using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflies : MonoBehaviour
{
    [SerializeField] Transform[] posF;
    [SerializeField] float spdF = 30f;
    Transform nextPos;
    bool moveFly = false;
    
    // Start is called before the first frame update
    int nextPosI;
    void Start()
    {
        //Debug.Log("is object active: " + gameObject.activeInHierarchy);
        nextPos = posF[0];//does immediately; will edit later for player action
    }
    void Update()
    {
        MoveFireflies(); 
    }
    //use OnTriggerEnter2D/OnTriggerExit2D for collison bw fireflies and player
    // Update is called once per frame ; outdated
    //void FixedUpdate()
    //{
    //    MoveFireflies();
    //}
    //IEnumerator fireflyMovement()//doesnt work for some reason; the delay
    //{
    //    yield return new WaitForSeconds(5f);
    //    MoveFireflies();
       
    //} // outdated
    void MoveFireflies()//ctr+k+c to block comment; ctr +k+u to undo
    {
        if (moveFly && transform.position == nextPos.position)//corrects position to new pt
        {
            nextPosI++;
            if (nextPosI >= posF.Length)
            {
                nextPosI = 0;
            }
            nextPos = posF[nextPosI];
        }
        else if(moveFly && transform.position != nextPos.position)//moves obj to new position without delay; outdated
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position, spdF * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("is it triggering HERE?");
        if(collision.gameObject.tag=="Player")
        {
            moveFly = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moveFly = false;
        }
    }
}
