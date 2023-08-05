using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] Transform platPoint;
    [SerializeField] bool movePlat;
    [SerializeField] bool fireflyLike;//optional code to create platforms that closes when fireflies are near
    [SerializeField] float spdPlat = 20f;
    public Fireflies fly;
    private Transform oldPt;
    bool trigMoveEnter=false;
    bool trigMoveExit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        oldPt = this.transform;
    }

    void Update()
    {
        if ( trigMoveEnter ) 
        {
            transform.position = Vector3.MoveTowards(oldPt.position, platPoint.position, spdPlat * Time.deltaTime);
            trigMoveEnter = false;
        }
        else if(trigMoveExit)
        {
            Debug.Log("did it exit properly? & oldPt: "+ oldPt.transform);
            transform.position = Vector3.MoveTowards(platPoint.position, oldPt.position, spdPlat * Time.deltaTime);
            trigMoveExit = false;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("is platform triggering?");
        if (collision.gameObject.tag == "Firefly")
        {
            Debug.Log("entered trigger state by firefly frm plat");
            trigMoveEnter = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Firefly")
        {
            Debug.Log("exit plat trigger by firefly");
            trigMoveExit = true;
        }
    }
}
