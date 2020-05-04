using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wall : MonoBehaviour

{
    // Start is called before the first frame update
    
    [SerializeField]
    [Range(2, 100)]
    public float speed = 10;
    private Vector3 TargetPosition;
    private Vector3 TargetPositionWall;
    private bool MoveOn = false;
    public GameObject bla;

    
    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
            prueba();
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
        
    }
   
    public void MoveP()
    {
         Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);
        if (transform.position == TargetPosition)
        {
            MoveOn = false;
        }
    }

    public void prueba()
    {
        Debug.Log("fede cool");
    }

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("this work");
    }

}
