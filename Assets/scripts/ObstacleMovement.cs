using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 2f, raycastHeight;
    public LayerMask playerLayer;
    public Transform raycastPos;

    bool rayCalled;

    

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
        ScoreRaycast();
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void ScoreRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(raycastPos.position, Vector2.down, raycastHeight,playerLayer);

        if(hit && rayCalled == false)
        {
            gameManager.instance.ScoreUpdate();
            rayCalled= true;    
        }
    }
}
