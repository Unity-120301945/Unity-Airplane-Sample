using UnityEngine;

/**
 * 螺旋桨旋转脚本
 */
public class NewMonoBehaviourScript : MonoBehaviour
{
    private float rotationSpeed = 3000f; // 旋转速度
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
