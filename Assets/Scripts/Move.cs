using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    [Range(2, 100)]
    public float speed = 10;
    private Vector3 TargetPosition;
    private Vector3 TargetPositionWall;
    private bool MoveOn = false;
    public GameObject wall;

    void Start()
    {

    }
    
    void Update()
    {
        
         if (Input.GetMouseButton(0))
         {
             SetTargetPosition();
         }
        if (MoveOn)
        {
            MoveP();
        }
        
    }

    public void SetTargetPosition()
    {
        TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TargetPosition.z = transform.position.z;

        MoveOn = true;
        Debug.Log("hit");
    }
    
    public void MoveP()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);
        if (transform.position == TargetPosition)
        {
            MoveOn = false;
        }
    }
    


}



