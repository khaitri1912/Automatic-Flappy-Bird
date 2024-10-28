using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPipe : MonoBehaviour
{
    private Rect _TopPipeRect;


    // Start is called before the first frame update
    void Start()
    {
        _TopPipeRect = new Rect(transform.position.x, transform.position.y, GetComponent<SpriteRenderer>().bounds.size.x, GetComponent<SpriteRenderer>().bounds.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        //_TopPipeRect.x = transform.position.x - 0.7f;
        //_TopPipeRect.y = transform.position.y - 4.1f;*/
    }

    public Rect GetTopRect()
    {
        return _TopPipeRect;
    }

    private void OnDrawGizmos()
    {

        if (_TopPipeRect != null )
        {
            Vector3 topRectPosition = new Vector3(_TopPipeRect.x = transform.position.x - 0.7f, _TopPipeRect.y, 0);
            Vector3 topRectSize = new Vector3(_TopPipeRect.width, _TopPipeRect.height, 0);

            Gizmos.color = Color.blue;

            Gizmos.DrawWireCube(topRectPosition + topRectSize / 2, topRectSize);
        }
    }
}
