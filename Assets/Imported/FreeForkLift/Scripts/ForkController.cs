using UnityEngine;
using System.Collections;

public class ForkController : MonoBehaviour {

    public Transform fork; 
    public Transform mast;
    public float speedTranslate; //Platform travel speed
    public Vector3 maxY; //The maximum height of the platform
    public Vector3 minY; //The minimum height of the platform
    public Vector3 maxYmast; //The maximum height of the mast
    public Vector3 minYmast; //The minimum height of the mast

    [Range(-1.0f,1.0f)]
    public float input = 0.0f;

    private bool mastMoveTrue = false; //Activate or deactivate the movement of the mast

    // Update is called once per frame
    void FixedUpdate () {
        if(fork.transform.position.y >= maxYmast.y)
        {
            mastMoveTrue = true;
        }
        if (fork.transform.position.y <= maxYmast.y)
        {
            mastMoveTrue = false;
        }
        if (fork.transform.position.y >= maxY.y )
        {
            fork.transform.position = new Vector3(fork.transform.position.x, maxY.y, fork.transform.position.z);
        }

          if (fork.transform.position.y <= minY.y)
          {
              fork.transform.position = new Vector3(fork.transform.position.x, minY.y, fork.transform.position.z);
          }
        if (mast.transform.position.y >= maxYmast.y)
        {
            mast.transform.position = new Vector3(mast.transform.position.x, maxYmast.y, mast.transform.position.z);
        }

        if (mast.transform.position.y <= minYmast.y)
        {
            mast.transform.position = new Vector3(mast.transform.position.x, minYmast.y, mast.transform.position.z);
        }

        fork.Translate((Vector3.up * input) * speedTranslate * Time.deltaTime);
        if(mastMoveTrue)
        {
            mast.Translate(Vector3.up * speedTranslate * Time.deltaTime);
        }

    }
}
