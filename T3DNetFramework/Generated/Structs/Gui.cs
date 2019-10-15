using System;
using System.Runtime.InteropServices;
using T3DNetFramework.Engine;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;

namespace T3DNetFramework.Generated.Structs.Gui {

    public class RectSpacingI : IEngineStruct {
        [StructLayout(LayoutKind.Explicit)]
        public struct InternalStruct {
            [FieldOffset(0)] public int leftPadding;
            [FieldOffset(12)] public int rightPadding;
            [FieldOffset(4)] public int topPadding;
            [FieldOffset(8)] public int bottomPadding;
        }
        
        public InternalStruct internalStruct;
        
        public IntPtr internalStructPtr;
        
        public int LeftPadding { get; set; }
        public int RightPadding { get; set; }
        public int TopPadding { get; set; }
        public int BottomPadding { get; set; }
        
        public RectSpacingI() { }
        
        public RectSpacingI(InternalStruct data) { 
            internalStruct = data;
			Free();
        }
        
        public RectSpacingI(string s) {
            string[] strings = s.Split(' ');
            LeftPadding = GenericMarshal.StringTo<int>(strings[0]);            
            RightPadding = GenericMarshal.StringTo<int>(strings[1]);            
            TopPadding = GenericMarshal.StringTo<int>(strings[2]);            
            BottomPadding = GenericMarshal.StringTo<int>(strings[3]);            
        }
        
        public void Alloc() {
            internalStruct.leftPadding = LeftPadding;
            internalStruct.rightPadding = RightPadding;
            internalStruct.topPadding = TopPadding;
            internalStruct.bottomPadding = BottomPadding;
            internalStructPtr = StructMarshal.StructToIntPtr(internalStruct);
        }
        
        public void Free() {
            LeftPadding = internalStruct.leftPadding;
            RightPadding = internalStruct.rightPadding;
            TopPadding = internalStruct.topPadding;
            BottomPadding = internalStruct.bottomPadding;
            if (internalStructPtr != IntPtr.Zero) {
                StructMarshal.FreeStructPtr<InternalStruct>(internalStructPtr);
            }
            internalStructPtr = IntPtr.Zero;
        }
        
        public override string ToString() {
            string s = "";
            s += " " + GenericMarshal.ToString(LeftPadding);            
            s += " " + GenericMarshal.ToString(RightPadding);            
            s += " " + GenericMarshal.ToString(TopPadding);            
            s += " " + GenericMarshal.ToString(BottomPadding);            
            return s.Substring(1);
        }
    }
}