using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflies : MonoBehaviour
{
    [SerializeField] Transform[] posF;
    [SerializeField] float spdF =30f;
    Transform nextPos;
    
    // Start is called before the first frame update
    int nextPosI;
    void Start()
    {
        //Debug.Log("is object active: " + gameObject.activeInHierarchy);
        nextPos = posF[0];//does immediately; will edit later for player action
    }
    void Update()
    {
        StartCoroutine(fireflyMovement());   
    }
    //use OnTriggerEnter2D/OnTriggerExit2D for collison bw fireflies and player
    // Update is called once per frame
    //void FixedUpdate()
    //{
    //    MoveFireflies();
    //}
    IEnumerator fireflyMovement()
    {
        yield return new WaitForSeconds(5f);
        MoveFireflies();
       
    }
    void MoveFireflies()//ctr+k+c to block comment; ctr +k+u to undo
    {
        if (transform.position == nextPos.position)//corrects position to new pt
        {
            nextPosI++;
            if (nextPosI >= posF.Length)
            {
                nextPosI = 0;
            }
            nextPos = posF[nextPosI];
        }
        else//moves obj to new position without delay
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position, spdF * Time.deltaTime);
        }
    }
}
