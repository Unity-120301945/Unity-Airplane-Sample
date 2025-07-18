using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 飞机飞行控制脚本
 */
public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20f;
    private float rotationSpeed = 80f;
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb; // 声明刚体变量

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 获取刚体组件
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("💥 撞上了: " + collision.gameObject.name);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal"); // 获取水平输入（左右方向键或A/D键）

        // move the plane forward at a constant rate
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        Vector3 move = transform.forward * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move); // 用刚体移动，启用碰撞检测

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
        // 计算旋转（绕 X 轴旋转）
        Quaternion turn = Quaternion.Euler(Vector3.left * verticalInput * rotationSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * turn); // 用刚体旋转
    }
}
