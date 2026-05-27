using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        //Time.deltaTime은 이전 프레임과 현재 프레임 사이의 시간 간격을 나타냅니다.
        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
