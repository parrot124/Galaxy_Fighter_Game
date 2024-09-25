using UnityEngine;

public static class ScreenBound
{
    private static Camera _camera;

    public static Vector3 Top => new Vector3(_camera.transform.position.x,
                                      _camera.transform.position.y + _camera.orthographicSize,
                                      0);

    public static Vector3 Bottom => new Vector3(_camera.transform.position.x,
                                         _camera.transform.position.y - _camera.orthographicSize,
                                         0);

    public static Vector3 Left => new Vector3(_camera.transform.position.x - _camera.scaledPixelWidth / (_camera.pixelHeight / (_camera.orthographicSize)) ,
                                              _camera.transform.position.y,
                                              0);

    public static Vector3 Right => new Vector3(_camera.transform.position.x + _camera.scaledPixelWidth / (_camera.pixelHeight / (_camera.orthographicSize)),
                                               _camera.transform.position.y,
                                               0);
    static ScreenBound()
    {
        _camera = Camera.main;
    }
}