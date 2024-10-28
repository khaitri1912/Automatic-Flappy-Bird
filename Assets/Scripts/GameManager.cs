using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FlappyBird bird;
    public Pipe pipes;
    //[SerializeField] TopPipe topPipe;

    //public Rect pipeTopRect;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckCollision())
        {
            Debug.Log("Thua");
            Time.timeScale = 0;
        }
    }

    public bool CheckCollision()
    {
        Rect birdRect = bird.GetRect();
        Rect pipeTopRect = pipes.GetTopPipeRect();
        Rect pipeDownRect = pipes.GetDownPipeRect();

        if (birdRect.Overlaps(pipeTopRect) || birdRect.Overlaps(pipeDownRect))
        {
            return true;
        }
        return false;
    }
}
