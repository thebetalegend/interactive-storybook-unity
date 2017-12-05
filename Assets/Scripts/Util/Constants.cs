// This file contains constants for the interactive storybook.

public static class Constants
{

    // Desired ratio of graphics panel width to entire landscape panel width
    // in landscape display mode.
    public static float LANDSCAPE_GRAPHICS_WIDTH_FRACTION = 0.43f;
    // Desired ratio of graphics panel height to entire landscape panel height
    // in portrait display mode.
    public static float PORTRAIT_GRAPHICS_HEIGHT_FRACTION = 0.66f;
    // Desired ratio of graphics panel height to entire landscape panel height
    // in landscape wide display mode.
    public static float LANDSCAPE_WIDE_GRAPHICS_HEIGHT_FRACTION = 0.71f;

    // ROS connection.
    public static bool USE_ROS = true;
    public static string DEFAULT_ROSBRIDGE_IP = "192.168.1.149";
    public static string DEFAULT_ROSBRIDGE_PORT = "9090";

    // ROS topics.

}

// Display Modes.
// Related to ScreenOrientation but also deals with layout of the scene.
public enum DisplayMode
{
    LandscapeWide,
    Landscape,
    Portrait
};
