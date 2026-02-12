
//Player inputs WASD 
//Player moves forward with transform 



using Unity.Mathematics;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed;
    public float rotateSpeed;
    
    void Update()
    {

        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical"); 
        

       Vector3 movement = new Vector3 (0f,0f, movementY);
       float rotate = movementX *rotateSpeed*Time.deltaTime;
        
        transform.Translate(movement *movementSpeed*Time.deltaTime);

        transform.Rotate(Vector3.up,rotate,Space.Self);
    }
}
