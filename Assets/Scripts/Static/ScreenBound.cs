using UnityEngine;

public static class ScreenBound
{
    private static Camera camera;

    public static Vector3 Top => new(
                                  camera.transform.position.x,
                                  camera.transform.position.y + camera.orthographicSize,
                                  0
                                  );

    public static Vector3 Bottom => new(
                                     camera.transform.position.x,
                                     camera.transform.position.y - camera.orthographicSize,
                                     0
                                     );

    public static Vector3 Left => new(
                                   camera.transform.position.x - camera.scaledPixelWidth / (camera.pixelHeight / (camera.orthographicSize)),
                                   camera.transform.position.y,
                                   0
                                   );

    public static Vector3 Right => new(
                                    camera.transform.position.x + camera.scaledPixelWidth / (camera.pixelHeight / (camera.orthographicSize)),
                                    camera.transform.position.y,
                                    0
                                    );

    static ScreenBound()
    {
        camera = Camera.main;
    }
}