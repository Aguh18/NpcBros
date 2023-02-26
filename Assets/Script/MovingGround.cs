using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pos1, pos2;
    public int speed;
    Vector2 targetpos;
    void Start()
    {
       targetpos = pos2.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, pos1.position)< .1f){
            targetpos = pos2.position;
        }
         if (Vector2.Distance(transform.position, pos2.position)< .1f){
            targetpos = pos1.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed*Time.deltaTime);
        {
            
        }
        void OnDrawGizmos() {
            Gizmos.DrawLine(pos1.position,pos2.position);
        }
    }
}
