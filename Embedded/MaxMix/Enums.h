#pragma once

enum Command : int8_t
{
    ERROR = -1,
    NONE = 0,
    TEST = 1,
    OK,
    SETTINGS,
    SESSION_INFO,
    CURRENT_SESSION,
    ALTERNATE_SESSION,
    PREVIOUS_SESSION,
    NEXT_SESSION,
    VOLUME_CURR_CHANGE,
    VOLUME_ALT_CHANGE,
    VOLUME_PREV_CHANGE,
    VOLUME_NEXT_CHANGE,
    DEBUG
};

enum SessionIndex : uint8_t
{
    INDEX_CURRENT,
    INDEX_ALTERNATE,
    INDEX_PREVIOUS,
    INDEX_NEXT,
    INDEX_MAX
};

enum DisplayMode : uint8_t
{
    MODE_SPLASH,
    MODE_OUTPUT,
    MODE_INPUT,
    MODE_APPLICATION,
    MODE_GAME,
    MODE_MAX
};