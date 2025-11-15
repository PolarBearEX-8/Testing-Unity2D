using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public RectTransform crosshairUI; // ← เพิ่มช่องรับ crosshair UI

    void Start()
    {
        // ซ่อนเมาส์จริง
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        // ---- 1. กล้องตามผู้เล่น ----
        transform.position = new Vector3(
            player.position.x + offset.x,
            player.position.y + offset.y,
            offset.z
        );

        // ---- 2. Crosshair UI ตามเมาส์ ----
        if (crosshairUI != null)
        {
            crosshairUI.position = Input.mousePosition;
        }
    }
}
