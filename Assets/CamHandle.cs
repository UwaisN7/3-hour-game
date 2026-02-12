using UnityEngine;

public class CamHandle : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public bool cam1;
    public bool cam2;

    private void Start()
    {
        Cam1.SetActive(true);
        cam1 =true; 
        Cam2.SetActive(true);
        cam2 = false;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
        {
            ChangeCameras();
        }
    }

    void ChangeCameras()
    {
       if (cam1 == true)
        {
            Cam1.SetActive(false);
            cam1 = false;
            Cam2.SetActive(true );
            cam2 = true;
        }

       else if (cam2 == true)
        {
            Cam1.SetActive(true) ;
            cam1 = true;
            Cam2.SetActive(false);
            cam2 = false;
        }
       
    }

}
