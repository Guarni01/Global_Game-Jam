using UnityEngine;

public class CameraFollow : MonoBehaviour
{

        public Transform Player; 
        public Vector3 offset; 

        void LateUpdate()
        {
            transform.position = Player.position + offset;
        }
    
}
