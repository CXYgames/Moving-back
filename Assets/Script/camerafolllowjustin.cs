
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 8/15/2020
 *
 * @author Justin Scotty 01001010 01010011 01000010
 */
namespace Code
{
    [RequireComponent(typeof(Camera))]
    public class camerafolllowjustin : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [Space(10)]
        [SerializeField] private float zoomLevel = 2; // amount to zoom in, the more the further it zooms
        [SerializeField] private float zoomSpeed = 0.05f; // speed of reaching zoom level
        [Space(10)]
        [SerializeField] private float followSpeed = 0.0875f; // speed to follow target

        private Camera camera;
        private Vector3 cachedTargetPosition;
        private float maxZoom;
        private float minZoom;

        public float offset;

       // public Vector3 m_Offset = Vector3.zero;

        private void Awake()
        {
            camera = GetComponent<Camera>();

            // max zoom is the current zoom of the camera
            // zoom in is lowering size
            maxZoom = camera.orthographicSize;      //pernei to kanoniko zoom pou exeis
            minZoom = maxZoom - zoomLevel;          // gia na dei mexri pou tha paei kanei to kanoniko zoom PLIN to zoom pou dilwses kai exei ena diko tou zoom

            cachedTargetPosition = target.position;
        }

        private void Update()
        {
            // receiving distance to see if target has moved

            //ALLA MONO TO Y-AXIS OXI KAI TO X-AXIS

            var distance = Vector3.Distance(target.position, cachedTargetPosition);     //to target en h mpala - to cached

            // if distance is not 0 it means the target has moved previous frame, so we must zoom in
            Zoom(distance != 0);

            // following target
            Follow();

            // caching position again to see next frame if target has moved
            cachedTargetPosition = target.position;
        }

        private void Follow()
        {
            // get distance of both axis to individually follow an axis, if y is not moved, we shall not follow
            // y position. Vice versa for x axis.
            var distanceX = transform.position.x - target.position.x;   //to target position piannito apo to target diladi apo ton player
            var distanceY = transform.position.y - target.position.y;

            var pos = transform.position;

            // to stop flickering
            if (distanceX < -0.1f || distanceX > 0.1f)
            {
                // move left/right
                pos.x += followSpeed * (distanceX > 0 ? -1 : 1);
            }
            else
            {
                // link to target
                pos.x = target.position.x;
            }
            if (distanceY < -0.1f || distanceY > 0.1f)
            {
                // move up/down
                pos.y += followSpeed * (distanceY > 0 ? -1 : 1);
            }
            else
            {
                // link to target
                pos.y = target.position.y;
            }

            // ^^ if not having these checks the camera will keep following causing it will shake a lot.
            // this way we prevent that by sticking camera to target if it reached the target position.

            pos.y = pos.y + offset;
            transform.position = pos;       //gia na piasei h camera to possition evalen to pos ALLA pio panw exei pos.x kai pos.y ara me to pos epiase tis suntetagmenes pou theloume

        }

        private void Zoom(bool zoomIn)
        {
            // zoom in of out.
            // x ? a : b
            // x = condition
            // a is if condition is true
            // b is if condition is false
            // so if zoomIn is true it will adjust zoom speed to minus (zoom in is lowering size)
            var speed = zoomSpeed * (zoomIn ? -1 : 1);
            camera.orthographicSize += speed;   //ME TO - KANEI ZOOM OUT ME TO + KANEI ZOOM IN

            // clamping will make sure it will not pass maximum or go below minimum level
            camera.orthographicSize = Mathf.Clamp(camera.orthographicSize, minZoom, maxZoom);
        }
    }
}