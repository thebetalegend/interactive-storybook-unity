// This file contains constants for the interactive storybook.

using UnityEngine;
using Amazon;

public static class Constants {

    // Flags.
    public static bool LOAD_ASSETS_LOCALLY = false;
    public static bool USE_ROS = true;

    // For float comparison.
    public static float EPSILON = 1e-5f;

    // Desired ratio of graphics panel width to entire landscape panel width
    // in landscape display mode.
    public static float LANDSCAPE_GRAPHICS_WIDTH_FRACTION = 0.43f;
    // Desired ratio of graphics panel height to entire landscape panel height
    // in portrait display mode.
    public static float PORTRAIT_GRAPHICS_HEIGHT_FRACTION = 0.66f;
    // Desired ratio of graphics panel height to entire landscape panel height
    // in landscape wide display mode.
    //public static float LANDSCAPE_WIDE_GRAPHICS_HEIGHT_FRACTION = 0.71f;
    public static float LANDSCAPE_WIDE_GRAPHICS_HEIGHT_FRACTION = 0.5f;

    // UI things.
    public static Color SceneObjectHighlightColor = new Color(0, 1, 1, 60f / 255);

    // ROS connection information.
    public static string DEFAULT_ROSBRIDGE_IP = "192.168.1.229";
    public static string DEFAULT_ROSBRIDGE_PORT = "9090";

    // ROS topics.
    public static string STORYBOOK_TO_ROSCORE_TOPIC = "/storybook_to_roscore";
    public static string STORYBOOK_TO_ROSCORE_MESSAGE_TYPE = "/unity_game_msgs/StorybookGameInfo";
    public static string ROSCORE_TO_STORYBOOK_TOPIC = "/roscore_to_storybook";
    public static string ROSCORE_TO_STORYBOOK_MESSAGE_TYPE = "/unity_game_msgs/StorybookCommand";

    // Download URLs.
    public static string IMAGE_BASE_URL = "https://s3.amazonaws.com/storycorpus-images-without-text/images/";
    public static string AUDIO_BASE_URL = "https://s3.amazonaws.com/storycorpus-audio/";
    public static string JSON_BASE_URL = "https://s3.amazonaws.com/storycorpus-interactive-storybook-json/";

    // Amazon S3 Information
    public static string COGNITO_IDENTITY_REGION = RegionEndpoint.USEast1.SystemName;
    public static string S3_REGION = RegionEndpoint.USEast1.SystemName;
    public static string IDENTITY_POOL_ID = "us-east-1:f54fdb54-0d47-4b18-b3e3-59d9d19e3fe3";
    public static string S3_JSON_BUCKET = "storycorpus-interactive-storybook-json";
    public static string S3_IMAGES_BUCKET = "storycorpus-images-without-text";
    public static string S3_AUDIO_BUCKET = "storycorpus-audio";
    public static string S3_CHILD_AUDIO_BUCKET = "storybook-collected-child-audio";
}

// Display Modes.
// Related to ScreenOrientation but also deals with layout of the scene.
public enum DisplayMode {
    LandscapeWide,
    Landscape,
    Portrait
};

// Game Modes.
// Determines whether or not the tablet should autoplay the audio, if we should be evaluating
// the child's speech, if graphics/words are touchable, etc.
public enum GameMode {
    Explore, // No evaluation, just ask what is this, what is that?
    Coaching, // Robot prompts child to read, does evaluation, asks questions.
}
