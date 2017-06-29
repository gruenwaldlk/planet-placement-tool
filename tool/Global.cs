using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetPlacementTool.tool
{
    public enum ToolState { IDLE_, ADD_REMOVE_, SELECT_MOVE_ };
    class Global
    {
        public static ToolState APP_STATE_ = ToolState.IDLE_;
        public static int CANVAS_SIZE_ = 0;
        public static int PROJECT_SCALE_ = 0;
        public const int PROJECT_MIN_SCALE_ = 350; //Corresponds to vanilla map size.
        public static int PROJECT_MAX_SCALE_ = 1100; //Currently arbitrary, but I suspect that larger maps will start clipping with the background.
        public static bool PROJECT_INITIALISED_ = false;
        public static bool PROJECT_DIRTY_ = false;
        public const int PROJECT_SCALE_VARIANT_ = 200;
#if DEBUG
        public const string APP_STATE_IDLE_ = "ToolState.IDLE_\n";
        public const string APP_ADD_REMOVE_ = "ToolState.ADD_REMOVE_\n";
        public const string APP_SELECT_MOVE_ = "ToolState.SELECT_MOVE_\n";
        public const string APP_STATE_DEFAULT_CASE_ = "DEFAULT CASE\n";
#endif
        public static T Clamp<T>(T value, T max, T min)
            where T : System.IComparable<T>
                {
                    T result = value;
                    if (value.CompareTo(max) > 0)
                        result = max;
                    if (value.CompareTo(min) < 0)
                        result = min;
                    return result;
                }
    }
}
