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
        _mainCamera = Camera.main;

        _screenHalfHeight = _mainCamera.orthographicSize / 8f;
    }

    public bool IsBirdBelowHalfScreen(Vector3 birdPosition)
    {
        if (_mainCamera == null) return false;
        float screenHalfY = _mainCamera.transform.position.y - _screenHalfHeight;

        return birdPosition.y < screenHalfY;

    }
}
