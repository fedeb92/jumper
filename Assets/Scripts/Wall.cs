using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wall : MonoBehaviour

{
    // Start is called before the first frame update
    private Move move;
    private void Start() {

        move = GameObject.FindObjectOfType<Move>();

    }


    private void OnMouseDown() {

        move.SetTargetPosition(this);

    }
}
