 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    private Rect _birdRect;

    private ScreenChecker _screenChecker;

    public float _gravity = -9.8f;
    public float _jumpForce = 0.75f;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        _screenChecker = gameObject.AddComponent<ScreenChecker>();

        // Create a rectangle representing the bird (coordinates, width, height)
        _birdRect = new Rect(transform.position.x, transform.position.y, GetComponent<SpriteRenderer>().bounds.size.x, GetComponent<SpriteRenderer>().bounds.size.y);
        

    }

    // Update is called once per frame
    void Update()
    {
        // Apply gravity
        force += _gravity * Time.deltaTime;
        transform.position += new Vector3(0, force * Time.deltaTime, 0);
        
        // Auto fly without Player input
        if (_screenChecker.IsBirdBelowHalfScreen(transform.position))
        {
            force = _jumpForce;
            Debug.Log("Nhay");
        }

        // Update bird position
        //_birdRect.y += _birdVelocity.y;
        _birdRect.x = transform.position.x - 0.4f;
        _birdRect.y = transform.position.y - 0.3f;
    }


    public Rect GetRect()
    {
        return _birdRect;
    }

    void OnDrawGizmos()
    {
        // Kiểm tra nếu birdRect đã được khởi tạo
        if (_birdRect != null)
        {
            // Chuyển birdRect từ toạ độ game sang toạ độ thế giới
            Vector3 rectPosition = new Vector3(_birdRect.x, _birdRect.y, 0);
            Vector3 rectSize = new Vector3(_birdRect.width, _birdRect.height, 0);

            // Thiết lập màu cho Gizmos
            Gizmos.color = Color.red;

            // Vẽ một khung hình chữ nhật cho birdRect
            Gizmos.DrawWireCube(rectPosition + rectSize / 2, rectSize);
        }
    }
}
