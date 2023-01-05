using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movement move;

    // Start is called before the first frame update
    void onCollisionEnter (Collision collisionInf)
    {
        if (collisionInf.collider.tag == "Obstacle")
        {
            Debug.Log("We hit someone");
            FindObjectOfType<GameManager>().EndGame(); 

        }
    }
}
