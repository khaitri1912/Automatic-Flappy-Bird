﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChecker : MonoBehaviour
{
    private Camera _mainCamera;
    private float _screenHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        // Lấy camera chính của game
        _mainCamera = Camera.main;

        // Tính toán nửa chiều cao của màn hình theo đơn vị thế giới
        _screenHalfHeight = _mainCamera.orthographicSize / 8f; // Đây là nửa chiều cao màn hình
    }

    // Hàm để kiểm tra vị trí của chim so với nửa chiều cao màn hình
    public bool IsBirdBelowHalfScreen(Vector3 birdPosition)
    {
        // Lấy toạ độ y của điểm nửa chiều cao màn hình
        float screenHalfY = _mainCamera.transform.position.y - _screenHalfHeight;

        // Kiểm tra nếu vị trí y của chim nhỏ hơn nửa chiều cao màn hình
        return birdPosition.y < screenHalfY;
    }
}