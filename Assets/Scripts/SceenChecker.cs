using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChecker : MonoBehaviour
{
    private Camera _mainCamera;
    private float _screenHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        // Lấy camera chính của game
        /*if (_mainCamera == null)
        {
            _mainCamera = Camera.main;

            _screenHalfHeight = _mainCamera.orthographicSize / 8f;
        }*/
        _mainCamera = Camera.main;

        // Tính toán nửa chiều cao của màn hình theo đơn vị thế giới
        _screenHalfHeight = _mainCamera.orthographicSize / 8f; // Đây là nửa chiều cao màn hình
    }

    /*void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _mainCamera = Camera.main;
    }*/

    // Hàm để kiểm tra vị trí của chim so với nửa chiều cao màn hình
    public bool IsBirdBelowHalfScreen(Vector3 birdPosition)
    {
        if (_mainCamera == null) return false;
        // Lấy toạ độ y của điểm nửa chiều cao màn hình
        float screenHalfY = _mainCamera.transform.position.y - _screenHalfHeight;

        // Kiểm tra nếu vị trí y của chim nhỏ hơn nửa chiều cao màn hình
        return birdPosition.y < screenHalfY;

    }
}
