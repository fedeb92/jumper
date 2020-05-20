using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    [Range(2, 100)]
    public float speed = 10;
    public Transform startpos;
    private Vector3 TargetPosition;
    
    
    private Vector3 TargetPositionWall;
    private bool MoveOn = false;
    public Wall wall;
    public float maxDistance = 7f;

    //line renderer
    public LineRenderer lr;
    public LineRenderer lr2;
   
    void Update()
    {
       
        if (MoveOn)
        {
            MoveP();


        }
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - (Vector2)transform.position;
        startpos.up = direction;
        lr.SetPosition(0, startpos.position);
        lr2.SetPosition(0, startpos.position);

        RaycastHit2D hit = Physics2D.Raycast(startpos.position, startpos.up, maxDistance);
        if(hit.collider != null)
        {
            lr.SetPosition(1, hit.point);
        }
        else
        {
            lr.SetPosition(1, startpos.position + (startpos.up * maxDistance));
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

    void Flip(float rot)
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rot));
    }

}



