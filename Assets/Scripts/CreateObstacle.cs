using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public GameObject obstacle;
    

    private void Start()
    {
        InvokeRepeating("Create", 1.0f, 2.0f);
    }

    public void Create()
    {
        Instantiate(obstacle, new Vector3(12.0f,0f,0f),Quaternion.identity);
    }

    
}
