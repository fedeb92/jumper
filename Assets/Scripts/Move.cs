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
    public Wall wall;
    public float maxDistance = 7f;
    
    void Update()
    {
       
        if (MoveOn)
        {
            MoveP();
        }
        
    }

    public void SetTargetPosition(Wall dest)
    {
        if(!dest.Equals(wall)) {

            TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            TargetPosition.z = transform.position.z;

            MoveOn = true;
            wall = dest;

        }

    }
    
    public void MoveP()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);
        if (transform.position == TargetPosition)
        {
            MoveOn = false;
        }
    }
    
    public bool IsReachable(Wall w) {        
        return Vector3.Distance(w.transform.position, transform.position) < maxDistance;
    }
    public bool IsAllowed(Wall w) {

        if(wall!=null && wall.forbidden.Length > 0) {
            foreach (GameObject forbidden in wall.forbidden) {
                if (w.gameObject.Equals(forbidden)) return false;
            }
        }        
        return true;
    }

}



