using UnityEngine;

// A tiny placeholder script — this is the only file you need to edit
// for this week's practice. Change the moveSpeed, add a comment,
// anything small is fine.
public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
