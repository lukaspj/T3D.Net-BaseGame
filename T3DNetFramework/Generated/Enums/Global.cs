namespace T3DNetFramework.Generated.Enums.Global {

    public enum NavMeshWaterMethod {
        Ignore = 0,
        Solid = 1,
        Impassable = 2
    }

    public enum CoverPointSize {
        Prone = 0,
        Crouch = 1,
        Stand = 2
    }

    public enum afxXM_WaveOpType {
        Add = 0,
        Multiply = 1,
        Replace = 2,
        Mult = 1
    }

    public enum afxXM_WaveParamType {
        None = 0,
        Pos = 1,
        Pos_x = 2,
        Pos_y = 3,
        Pos_z = 4,
        Ori = 5,
        Pos2 = 6,
        Pos2_x = 7,
        Pos2_y = 8,
        Pos2_z = 9,
        Scale = 10,
        Scale_x = 11,
        Scale_y = 12,
        Scale_z = 13,
        Color = 14,
        Color_red = 15,
        Color_green = 16,
        Color_blue = 17,
        Color_alpha = 18,
        Vis = 19,
        Position = 1,
        Position_x = 2,
        Position_y = 3,
        Position_z = 4,
        Orientation = 5,
        Position2 = 6,
        Position2_x = 7,
        Position2_y = 8,
        Position2_z = 9,
        Color_r = 15,
        Color_g = 16,
        Color_b = 17,
        Color_a = 18,
        Visibility = 19
    }

    public enum afxXM_WaveFormType {
        None = 0,
        Sine = 1,
        Square = 2,
        Triangle = 3,
        Sawtooth = 4,
        Noise = 5,
        One = 6
    }

    public enum afxXM_BoxConformType {
        Plusx = 0,
        Minusx = 1,
        Plusy = 2,
        Minusy = 3,
        Plusz = 4,
        Minusz = 5,
        X = 0,
        Y = 2,
        Z = 4
    }

    public enum afxPath3DLoopType {
        Constant = 0,
        Cycle = 1,
        Oscillate = 2
    }

    public enum afxParticlePool_PoolType {
        Normal = 0,
        Twominuspass = 1,
        Twopass = 1
    }

    public enum afxRPGMagicSpell_TargetType {
        Nothing = 0,
        Self = 1,
        Friend = 2,
        Enemy = 3,
        Corpse = 4,
        Free = 5
    }

    public enum afxZodiacPlane_FacingType {
        Up = 0,
        Down = 1,
        Forward = 2,
        Backward = 3,
        Right = 4,
        Left = 5,
        Front = 2,
        Back = 3
    }

    public enum afxZodiacPlane_BlendType {
        Normal = 0,
        Additive = 1,
        Subtractive = 2
    }

    public enum afxZodiac_BlendType {
        Normal = 0,
        Additive = 1,
        Subtractive = 2
    }

    public enum afxProjectile_LaunchDirType {
        TowardPos2Constraint = 0,
        OrientConstraint = 1,
        LaunchDirField = 2
    }

    public enum afxPlayerMovement_OpType {
        Add = 0,
        Multiply = 1,
        Replace = 2,
        Mult = 1
    }

    public enum afxPhraseEffect_PhraseType {
        Triggered = 0,
        Continuous = 1
    }

    public enum afxPhraseEffect_StateType {
        On = 1,
        Off = 2,
        Both = 3
    }

    public enum afxPhraseEffect_MatchType {
        Any = 0,
        All = 1
    }

    public enum afxParticleEmitterPath_OriginType {
        Origin = 0,
        Point = 1,
        Vector = 2,
        Tangent = 3
    }

    public enum afxBillboard_TexFuncType {
        Replace = 0,
        Modulate = 1,
        Add = 2
    }

    public enum afxBillboard_BlendStyle {
        NORMAL = 1,
        ADDITIVE = 2,
        SUBTRACTIVE = 3,
        PREMULTALPHA = 4
    }

    public enum SDLPowerEnum {
        Unknown = -1,
        Empty = 0,
        Low = 1,
        Medium = 2,
        Full = 3,
        Wired = 4,
        Max = 5
    }

    public enum SDLJoystickType {
        Unknown = 0,
        Game_Controller = 1,
        Wheel = 2,
        Arcade_Stick = 3,
        Flight_Stick = 4,
        Dance_Pad = 5,
        Guitar = 6,
        Drum_Kit = 7,
        Arcade_Pad = 8,
        Throttle = 9
    }

    public enum GuiSeparatorType {
        Vertical = 0,
        Horizontal = 1
    }

    public enum GuiParticleGraphType {
        Bar = 3,
        Filled = 2,
        Point = 0,
        Polyline = 1
    }

    public enum GuiGraphType {
        Bar = 3,
        Filled = 2,
        Point = 0,
        PolyLine = 1
    }

    public enum ForestBrushMode {
        Paint = 0,
        Erase = 1,
        EraseSelected = 2
    }

    public enum WorldEditorAlignmentType {
        None = 0,
        PlusX = 1,
        PlusY = 2,
        PlusZ = 3,
        MinusX = 4,
        MinusY = 5,
        MinusZ = 6
    }

    public enum WorldEditorDropType {
        AtOrigin = 0,
        AtCamera = 1,
        AtCameraRot = 2,
        BelowCamera = 3,
        ScreenCenter = 4,
        AtCentroid = 5,
        ToTerrain = 6,
        BelowSelection = 7,
        AtGizmo = 8
    }

    public enum GizmoMode {
        None = 0,
        Move = 1,
        Rotate = 2,
        Scale = 3
    }

    public enum GizmoAlignment {
        World = 0,
        Object = 1
    }

    public enum GuiTheoraTranscoder {
        Auto = 0,
        Generic = 1,
        SSE2420RGBA = 2
    }

    public enum ShadowType {
        Spot = 0,
        PSSM = 1,
        Paraboloid = 2,
        DualParaboloidSinglePass = 3,
        DualParaboloid = 4,
        CubeMap = 5
    }

    public enum ShadowFilterMode {
        None = 0,
        SoftShadow = 1,
        SoftShadowHighQuality = 2
    }

    public enum _TamlFormatMode {
        Xml = 1,
        Binary = 2
    }

    public enum BatchingMode {
        Individual = 0,
        Static_Batching = 2
    }

    public enum CollisionMeshMeshType {
        None = 0,
        Bounds = 1,
        Collision_Mesh = 2,
        Visible_Mesh = 3
    }

    public enum TurretShapeFireLinkType {
        FireTogether = 0,
        GroupedFire = 1,
        IndividualFire = 2
    }

    public enum PhysicsSimType {
        ClientOnly = 0,
        ServerOnly = 1,
        ClientServer = 2
    }

    public enum ParticleBlendStyle {
        NORMAL = 1,
        ADDITIVE = 2,
        SUBTRACTIVE = 3,
        PREMULTALPHA = 4
    }

    public enum TSMeshType {
        None = 0,
        Bounds = 1,
        Collision_Mesh = 2,
        Visible_Mesh = 3
    }

    public enum ShapeBaseImageLightType {
        NoLight = 0,
        ConstantLight = 1,
        SpotLight = 2,
        PulsingLight = 3,
        WeaponFireLight = 4
    }

    public enum ShapeBaseImageRecoilState {
        NoRecoil = 0,
        LightRecoil = 1,
        MediumRecoil = 2,
        HeavyRecoil = 3
    }

    public enum ShapeBaseImageSpinState {
        Ignore = 0,
        Stop = 1,
        SpinUp = 2,
        SpinDown = 3,
        FullSpeed = 4
    }

    public enum ShapeBaseImageLoadedState {
        Ignore = 0,
        Loaded = 1,
        Empty = 2
    }

    public enum PlayerPose {
        Stand = 0,
        Sprint = 1,
        Crouch = 2,
        Prone = 3,
        Swim = 4
    }

    public enum PhysicalZone_ForceType {
        Vector = 0,
        Spherical = 1,
        Cylindrical = 2,
        Sphere = 1,
        Cylinder = 2
    }

    public enum ItemLightType {
        NoLight = 0,
        ConstantLight = 1,
        PulsingLight = 2
    }

    public enum CameraMotionMode {
        Stationary = 0,
        FreeRotate = 1,
        Fly = 2,
        OrbitObject = 3,
        OrbitPoint = 4,
        TrackObject = 5,
        Overhead = 6,
        EditOrbit = 7
    }

    public enum PFXTargetViewport {
        PFXTargetViewport_TargetSize = 0,
        PFXTargetViewport_GFXViewport = 1,
        PFXTargetViewport_NamedInTexture0 = 2
    }

    public enum PFXTargetClear {
        PFXTargetClear_None = 0,
        PFXTargetClear_OnCreate = 1,
        PFXTargetClear_OnDraw = 2
    }

    public enum PFXRenderTime {
        PFXBeforeBin = 0,
        PFXAfterBin = 1,
        PFXAfterDiffuse = 2,
        PFXEndOfFrame = 3,
        PFXTexGenOnDemand = 4
    }

    public enum GuiTSRenderStyles {
        Standard = 0,
        Stereo_side_by_side = 1,
        Stereo_separate = 2
    }

    public enum TSShapeConstructorLodType {
        DetectDTS = 0,
        SingleSize = 1,
        TrailingNumber = 2
    }

    public enum TSShapeConstructorUpAxis {
        X_AXIS = 0,
        Y_AXIS = 1,
        Z_AXIS = 2,
        DEFAULT = 3
    }

    public enum baseTexFormat {
        NONE = 0,
        DDS = 1,
        PNG = 2
    }

    public enum MarkerKnotType {
        Normal = 0,
        Position_Only = 1,
        Kink = 2
    }

    public enum MarkerSmoothingType {
        Spline = 1,
        Linear = 0
    }

    public enum RenderTexTargetSize {
        Windowsize = 0,
        Windowsizescaled = 1,
        Fixedsize = 2
    }

    public enum MaterialWaveType {
        Sin = 0,
        Triangle = 1,
        Square = 2
    }

    public enum MaterialBlendOp {
        None = 0,
        Mul = 1,
        Add = 2,
        AddAlpha = 3,
        Sub = 4,
        LerpAlpha = 5
    }

    public enum MaterialAnimType {
        Scroll = 1,
        Rotate = 2,
        Wave = 4,
        Scale = 8,
        Sequence = 16
    }

    public enum GuiFontCharset {
        ANSI = 0,
        SYMBOL = 1,
        SHIFTJIS = 2,
        HANGEUL = 3,
        HANGUL = 4,
        GB2312 = 5,
        CHINESEBIG5 = 6,
        OEM = 7,
        JOHAB = 8,
        HEBREW = 9,
        ARABIC = 10,
        GREEK = 11,
        TURKISH = 12,
        VIETNAMESE = 13,
        THAI = 14,
        EASTEUROPE = 15,
        RUSSIAN = 16,
        MAC = 17,
        BALTIC = 18
    }

    public enum GuiAlignmentType {
        Left = 0,
        Center = 2,
        Right = 1,
        Top = 3,
        Bottom = 4
    }

    public enum GuiVerticalSizing {
        Bottom = 0,
        Height = 1,
        Top = 2,
        Center = 3,
        Relative = 4,
        AspectTop = 5,
        AspectBottom = 6,
        AspectCenter = 7,
        WindowRelative = 8
    }

    public enum GuiHorizontalSizing {
        Right = 0,
        Width = 1,
        Left = 2,
        Center = 3,
        Relative = 4,
        AspectLeft = 5,
        AspectRight = 6,
        AspectCenter = 7,
        WindowRelative = 8
    }

    public enum GuiGradientPickMode {
        HorizColor = 0,
        HorizAlpha = 1
    }

    public enum GuiColorPickMode {
        Pallete = 0,
        HorizColor = 1,
        VertColor = 2,
        HorizBrightnessColor = 3,
        VertBrightnessColor = 4,
        BlendColor = 5,
        HorizAlpha = 6,
        VertAlpha = 7,
        Dropper = 8
    }

    public enum GuiTabPosition {
        Top = 0,
        Bottom = 1
    }

    public enum GuiVerticalStackingType {
        Top_to_Bottom = 0,
        Bottom_to_Top = 1
    }

    public enum GuiHorizontalStackingType {
        Left_to_Right = 0,
        Right_to_Left = 1
    }

    public enum GuiStackingType {
        Vertical = 0,
        Horizontal = 1,
        Dynamic = 2
    }

    public enum GuiSplitFixedPanel {
        None = 0,
        FirstPanel = 1,
        SecondPanel = 2
    }

    public enum GuiSplitOrientation {
        Vertical = 0,
        Horizontal = 1
    }

    public enum GuiScrollBarBehavior {
        AlwaysOn = 0,
        AlwaysOff = 1,
        Dynamic = 2
    }

    public enum GuiFrameState {
        AlwaysOn = 0,
        AlwaysOff = 1,
        Dynamic = 2
    }

    public enum GuiDockingType {
        None = 1,
        Client = 2,
        Top = 4,
        Bottom = 8,
        Left = 16,
        Right = 32
    }

    public enum GuiAutoScrollDirection {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }

    public enum GuiIconButtonIconLocation {
        None = 0,
        Left = 1,
        Right = 2,
        Center = 3
    }

    public enum GuiIconButtonTextLocation {
        None = 0,
        Bottom = 1,
        Right = 2,
        Top = 3,
        Left = 4,
        Center = 5
    }

    public enum GuiButtonType {
        PushButton = 0,
        ToggleButton = 1,
        RadioButton = 2
    }

    public enum GuiBitmapMode {
        Stretched = 0,
        Centered = 1
    }

    public enum GFXBlendOp {
        GFXBlendOpAdd = 0,
        GFXBlendOpSubtract = 1,
        GFXBlendOpRevSubtract = 2,
        GFXBlendOpMin = 3,
        GFXBlendOpMax = 4
    }

    public enum GFXStencilOp {
        GFXStencilOpKeep = 0,
        GFXStencilOpZero = 1,
        GFXStencilOpReplace = 2,
        GFXStencilOpIncrSat = 3,
        GFXStencilOpDecrSat = 4,
        GFXStencilOpInvert = 5,
        GFXStencilOpIncr = 6,
        GFXStencilOpDecr = 7
    }

    public enum GFXCullMode {
        GFXCullNone = 0,
        GFXCullCW = 1,
        GFXCullCCW = 2
    }

    public enum GFXFormat {
        GFXFormatR8G8B8 = 10,
        GFXFormatR8G8B8A8 = 12,
        GFXFormatR8G8B8A8_SRGB = 15,
        GFXFormatR8G8B8X8 = 13,
        GFXFormatR32F = 16,
        GFXFormatR5G6B5 = 3,
        GFXFormatR5G5B5A1 = 4,
        GFXFormatR5G5B5X1 = 5,
        GFXFormatA4L4 = 2,
        GFXFormatA8L8 = 6,
        GFXFormatA8 = 0,
        GFXFormatL8 = 1,
        GFXFormatBC1 = 28,
        GFXFormatBC2 = 29,
        GFXFormatBC3 = 30,
        GFXFormatBC4 = 31,
        GFXFormatBC5 = 32,
        GFXFormatD32 = 20,
        GFXFormatD24X8 = 21,
        GFXFormatD24S8 = 22,
        GFXFormatD24FS8 = 23,
        GFXFormatD16 = 9,
        GFXFormatR32G32B32A32F = 27,
        GFXFormatR16G16B16A16F = 26,
        GFXFormatL16 = 7,
        GFXFormatR16G16B16A16 = 25,
        GFXFormatR16G16 = 17,
        GFXFormatR16F = 8,
        GFXFormatR16G16F = 18,
        GFXFormatR10G10B10A2 = 19
    }

    public enum GFXTextureTransformFlags {
        GFXTTFDisable = 0,
        GFXTTFFCoord1D = 1,
        GFXTTFFCoord2D = 2,
        GFXTTFFCoord3D = 3,
        GFXTTFFCoord4D = 4,
        GFXTTFProjected = 256
    }

    public enum GFXTextureArgument {
        GFXTADiffuse = 0,
        GFXTACurrent = 1,
        GFXTATexture = 2,
        GFXTATFactor = 3,
        GFXTASpecular = 4,
        GFXTATemp = 5,
        GFXTAConstant = 6,
        OneMinus = 16,
        AlphaReplicate = 32
    }

    public enum GFXTextureOp {
        GFXTOPDisable = 0,
        GFXTOPSelectARG1 = 1,
        GFXTOPSelectARG2 = 2,
        GFXTOPModulate = 3,
        GFXTOPModulate2X = 4,
        GFXTOPModulate4X = 5,
        GFXTOPAdd = 6,
        GFXTOPAddSigned = 7,
        GFXTOPAddSigned2X = 8,
        GFXTOPSubtract = 9,
        GFXTOPAddSmooth = 10,
        GFXTOPBlendDiffuseAlpha = 11,
        GFXTOPBlendTextureAlpha = 12,
        GFXTOPBlendFactorAlpha = 13,
        GFXTOPBlendTextureAlphaPM = 14,
        GFXTOPBlendCURRENTALPHA = 15,
        GFXTOPPreModulate = 16,
        GFXTOPModulateAlphaAddColor = 17,
        GFXTOPModulateColorAddAlpha = 18,
        GFXTOPModulateInvAlphaAddColor = 19,
        GFXTOPModulateInvColorAddAlpha = 20,
        GFXTOPBumpEnvMap = 21,
        GFXTOPBumpEnvMapLuminance = 22,
        GFXTOPDotProduct3 = 23,
        GFXTOPLERP = 24
    }

    public enum GFXTextureFilterType {
        GFXTextureFilterNone = 0,
        GFXTextureFilterPoint = 1,
        GFXTextureFilterLinear = 2,
        GFXTextureFilterAnisotropic = 3,
        GFXTextureFilterPyramidalQuad = 4,
        GFXTextureFilterGaussianQuad = 5
    }

    public enum GFXTextureAddressMode {
        GFXAddressWrap = 0,
        GFXAddressMirror = 1,
        GFXAddressClamp = 2,
        GFXAddressBorder = 3,
        GFXAddressMirrorOnce = 4
    }

    public enum GFXCmpFunc {
        GFXCmpNever = 0,
        GFXCmpLess = 1,
        GFXCmpEqual = 2,
        GFXCmpLessEqual = 3,
        GFXCmpGreater = 4,
        GFXCmpNotEqual = 5,
        GFXCmpGreaterEqual = 6,
        GFXCmpAlways = 7
    }

    public enum GFXBlend {
        GFXBlendZero = 0,
        GFXBlendOne = 1,
        GFXBlendSrcColor = 2,
        GFXBlendInvSrcColor = 3,
        GFXBlendSrcAlpha = 4,
        GFXBlendInvSrcAlpha = 5,
        GFXBlendDestAlpha = 6,
        GFXBlendInvDestAlpha = 7,
        GFXBlendDestColor = 8,
        GFXBlendInvDestColor = 9,
        GFXBlendSrcAlphaSat = 10
    }

    public enum GFXAdapterType {
        OpenGL = 0,
        D3D11 = 1,
        NullDevice = 2
    }

    public enum MBReturnVal {
        OK = 1,
        Cancelled = 2,
        Retry = 3,
        DontSave = 4
    }

    public enum MBIcons {
        Information = 1,
        Warning = 0,
        Stop = 3,
        Question = 2
    }

    public enum MBButtons {
        Ok = 0,
        OkCancel = 1,
        RetryCancel = 2,
        SaveDontSave = 3,
        SaveDontSaveCancel = 4
    }

    public enum LogLevel {
        Normal = 0,
        Warning = 1,
        Error = 2
    }

    public enum SFXChannel {
        Volume = 0,
        Pitch = 1,
        Priority = 2,
        PositionX = 3,
        PositionY = 4,
        PositionZ = 5,
        RotationX = 6,
        RotationY = 7,
        RotationZ = 8,
        VelocityX = 9,
        VelocityY = 10,
        VelocityZ = 11,
        ReferenceDistance = 12,
        MaxDistance = 13,
        ConeInsideAngle = 14,
        ConeOutsideAngle = 15,
        ConeOutsideVolume = 16,
        Cursor = 17,
        Status = 18,
        User0 = 19,
        User1 = 20,
        User2 = 21,
        User3 = 22
    }

    public enum SFXDistanceModel {
        Linear = 0,
        Logarithmic = 1,
        Exponential = 2
    }

    public enum SFXStatus {
        Playing = 1,
        Stopped = 2,
        Paused = 3
    }

    public enum SFXPlayListStateMode {
        StopWhenDeactivated = 0,
        PauseWhenDeactivated = 1,
        IgnoreWhenDeactivated = 2
    }

    public enum SFXPlayListReplayMode {
        IgnorePlaying = 0,
        RestartPlaying = 1,
        KeepPlaying = 2,
        StartNew = 3,
        SkipIfPlaying = 4
    }

    public enum SFXPlayListTransitionMode {
        None = 0,
        Wait = 1,
        WaitAll = 2,
        Stop = 3,
        StopAll = 4
    }

    public enum SFXPlayListRandomMode {
        NotRandom = 0,
        StrictRandom = 1,
        OrderedRandom = 2
    }

    public enum SFXPlayListLoopMode {
        All = 0,
        Single = 1
    }

}
