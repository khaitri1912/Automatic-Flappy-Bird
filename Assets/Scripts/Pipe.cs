using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 0.5f;
    //[SerializeField] TopPipe topPipe; 

    //public Rect _PipeTopRect;
    public Rect _PipeDownRect, _PipeTopRect;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pipeTop = GameObject.FindGameObjectWithTag("PipeTop");
        GameObject pipeDown = GameObject.FindGameObjectWithTag("PipeDown");/*
        GameObject pipeTop = GameObject.FindGameObjectWithTag("PipeTop");*/
        //_PipeTopRect = topPipe.GetTopRect();
        _PipeTopRect = new Rect(transform.position.x, transform.position.y, pipeTop.GetComponent<SpriteRenderer>().bounds.size.x, pipeTop.GetComponent<SpriteRenderer>().bounds.size.y);
        _PipeDownRect = new Rect(transform.position.x, transform.position.y, pipeDown.GetComponent<SpriteRenderer>().bounds.size.x, pipeDown.GetComponent<SpriteRenderer>().bounds.size.y);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }
    
    void OnDrawGizmos()
    {
        if (_PipeTopRect != null)
        {
            Vector3 topRectPosition = new Vector3(_PipeTopRect.x = transform.position.x + 5.4f, _PipeTopRect.y = transform.position.y + 1.7f, 0);
            Vector3 topRectSize = new Vector3(_PipeTopRect.width = 1.3f, _PipeTopRect.height = 8f, 0);

            Gizmos.color = Color.blue;

            Gizmos.DrawWireCube(topRectPosition + topRectSize / 2, topRectSize);
        }

        if (_PipeDownRect != null)
        {
            Vector3 downRectPosition = new Vector3(_PipeDownRect.x = transform.position.x + 5.4f, _PipeDownRect.y = transform.position.y - 9.1f, 0);
            Vector3 downRectSize = new Vector3(_PipeDownRect.width = 1.3f, _PipeDownRect.height = 8f, 0);

            Gizmos.color = Color.blue;

            Gizmos.DrawWireCube(downRectPosition + downRectSize / 2, downRectSize);
        }
    }

    public Rect GetTopPipeRect()
    {
        return _PipeTopRect;
    }

    public Rect GetDownPipeRect()
    {
        return _PipeDownRect;
    }
}
