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
        nextPos = posF[0];//does immediately; will edit later for player action
    }
    //use OnTriggerEnter2D/OnTriggerExit2D for collison bw fireflies and player
    // Update is called once per frame
    void Update()
    {
        MoveFireflies();
    }
    void MoveFireflies()
    {
        if(transform.position == nextPos.position)
        {
            nextPosI++;
            if(nextPosI >= posF.Length) 
            {
                nextPosI = 0;
            }
            nextPos = posF[nextPosI];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position,spdF *Time.deltaTime);
        }
    }
}
