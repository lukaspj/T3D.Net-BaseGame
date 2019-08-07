using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Enums.Global;

namespace BaseGame.Core.Rendering.GfxData
{
   public class CommonMaterialData
   {
      //-----------------------------------------------------------------------------
      // Anim flag settings - must match material.h
      // These cannot be enumed through the CInterface because it cannot
      // handle the "|" operation for combining them together
      // ie. Scroll | Wave does not work.
      //-----------------------------------------------------------------------------
      public enum AnimFlag
      {
         Scroll = 1,
         Rotate = 2,
         Wave = 4,
         Scale = 8,
         Sequence = 16
      }

      public static GFXSamplerStateData SamplerWrapPoint { get; set; }

      public static GFXSamplerStateData SamplerWrapLinear { get; set; }

      public static GFXSamplerStateData SamplerClampPoint { get; set; }

      public static GFXSamplerStateData SamplerClampLinear { get; set; }

      public static void Init() {
         // Common stateblock definitions
         SamplerClampLinear = new GFXSamplerStateData("SamplerClampLinear") {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeV = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeW = GFXTextureAddressMode.GFXAddressClamp,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear
         };

         SamplerClampPoint = new GFXSamplerStateData("SamplerClampPoint") {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeV = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeW = GFXTextureAddressMode.GFXAddressClamp,
            MagFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MinFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MipFilter = GFXTextureFilterType.GFXTextureFilterPoint
         };

         SamplerWrapLinear = new GFXSamplerStateData("SamplerWrapLinear") {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear
         };

         SamplerWrapPoint = new GFXSamplerStateData("SamplerWrapPoint") {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MinFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MipFilter = GFXTextureFilterType.GFXTextureFilterPoint
         };
      }
   }
}
