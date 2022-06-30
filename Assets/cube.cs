using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cosmos
{
  
public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            something.Instance.MoveRight = true;
        }
        else
        {
            something.Instance.MoveRight = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            something.Instance.MoveLeft = true;
        }
        else
        {
            something.Instance.MoveLeft = false;
        }
    }   

}
  
}

