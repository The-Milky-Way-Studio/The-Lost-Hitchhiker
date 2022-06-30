using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cosmos
{
    public class something : MonoBehaviour
    {
        
        public static something Instance;
    
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }else if (Instance != this)
            {
                Destroy(this.gameObject);
            }

        }   
        public bool MoveRight;
        public bool MoveLeft;
    }

}
     

    


